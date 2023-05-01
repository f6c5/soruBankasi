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
            refreshExam();
            if (btn_browse.Text == "İncele" && sorular.Count() > 0)
            {

                soru_no = 0;
                if (sinavlar.Count() > 0)
                {
                    lbl_soru.Visible = true;
                    lbl_a.Visible = true;
                    lbl_b.Visible = true;
                    lbl_c.Visible = true;
                    lbl_d.Visible = true;
                    lbl_e.Visible = true;
                    lbl_soru_no.Visible = true;
                    lbl_not.Visible = true;
                    btn_next.Visible = true;
                    btn_prev.Visible = true;
                    refreshQuestion();
                }
                else
                {
                    MessageBox.Show("aktif sınavınız yok");
                }
            }
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
            sinavlar = db.getGecmisSinavlar();
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
            switch (sorular[soru_no].getCevap())
            {
                case "A":
                    lbl_a.ForeColor = Color.Green;
                    lbl_b.ForeColor = Color.Black;
                    lbl_c.ForeColor = Color.Black;
                    lbl_d.ForeColor = Color.Black;
                    lbl_e.ForeColor = Color.Black;
                    break;
                case "B":
                    lbl_a.ForeColor = Color.Black;
                    lbl_b.ForeColor = Color.Green;
                    lbl_c.ForeColor = Color.Black;
                    lbl_d.ForeColor = Color.Black;
                    lbl_e.ForeColor = Color.Black;
                    break;
                case "C":
                    lbl_a.ForeColor = Color.Black;
                    lbl_b.ForeColor = Color.Black;
                    lbl_c.ForeColor = Color.Green;
                    lbl_d.ForeColor = Color.Black;
                    lbl_e.ForeColor = Color.Black;
                    break;
                case "D":
                    lbl_a.ForeColor = Color.Black;
                    lbl_b.ForeColor = Color.Black;
                    lbl_c.ForeColor = Color.Black;
                    lbl_d.ForeColor = Color.Green;
                    lbl_e.ForeColor = Color.Black;
                    break;
                case "E":
                    lbl_a.ForeColor = Color.Black;
                    lbl_b.ForeColor = Color.Black;
                    lbl_c.ForeColor = Color.Black;
                    lbl_d.ForeColor = Color.Black;
                    lbl_e.ForeColor = Color.Green;
                    break;
                default:
                    break;
            }
        }
    }
}
