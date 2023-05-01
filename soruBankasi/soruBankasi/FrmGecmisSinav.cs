using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soruBankasi
{
    public partial class FrmGecmisSinav : Form
    {
        public FrmGecmisSinav()
        {
            InitializeComponent();
        }

        List<Sinav> sinavlar = new List<Sinav>();
        Db_soru db = new Db_soru();
        int soru_no = 0;
        List<Soru> sorular = new List<Soru>();
        char cevap = 'Z';

        private void FrmGecmisSinav_Load(object sender, EventArgs e)
        {
            refreshExam();
        }

        private void cb_exam_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorular = sinavlar[cb_exam.SelectedIndex].getSinavSorulari();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            soru_no++;
            if (soru_no < sorular.Count())
            {
                refreshQuestion();
                if (soru_no == sorular.Count() - 1)
                {
                    btn_next.Visible = false;
                }
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            soru_no--;
            if (soru_no >= 0)
            {
                refreshQuestion();
                if (soru_no == 0)
                {
                    btn_prev.Visible = false;
                }
            }
        }

        private void refreshExam()
        {
            sinavlar = db.getAktifSinavlar(Data.DOgrenci.getId());
            cb_exam.Items.Clear();
            foreach (Sinav sinav in sinavlar)
            {
                cb_exam.Items.Add(sinav.getSinavAdi());
            }
        }

        private void refreshQuestion()
        {
            lbl_soru_no.Text = (soru_no + 1).ToString() + " / " + sorular.Count();
            lbl_soru.Text = sorular[soru_no].getMetin();
            lbl_a.Text = sorular[soru_no].getA();
            lbl_b.Text = sorular[soru_no].getB();
            lbl_c.Text = sorular[soru_no].getC();
            lbl_d.Text = sorular[soru_no].getD();
            lbl_e.Text = sorular[soru_no].getE();
        }
    }
}
