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
    public partial class FrmAktifSinav : Form
    {
        public FrmAktifSinav()
        {
            InitializeComponent();
        }
        List<Sinav> sinavlar = new List<Sinav>();
        Db_soru db = new Db_soru();
        int soru_no = 0;
        List<Soru> sorular = new List<Soru>();
        char cevap = 'Z';

        private void FrmAktifSinav_Load(object sender, EventArgs e)
        {
            refreshExam();
        }

        private void btn_basla_bitir_Click(object sender, EventArgs e)
        {
            if(btn_basla_bitir.Text == "Başla")
            {
                cb_exam.Visible = false;
                btn_sonraki.Visible = true;
                lbl_soru_no.Visible = true;
                btn_basla_bitir.Text = "Bitir";

                lbl_soru.Visible = true;
                rb_a.Visible = true;
                rb_b.Visible = true;
                rb_c.Visible = true;
                rb_d.Visible = true;
                rb_e.Visible = true;

                refreshQuestion();
            }
            else
            {

            }
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            if (soru_no +1 <= sorular.Count()-1)
            {
                db.setCevap(sorular[soru_no].getId(), cevap);
                cevap = 'Z';
                soru_no++;
                refreshQuestion();
            }
            else
            {
                btn_sonraki.Visible = false;
                lbl_soru.Visible = false;
                rb_a.Visible = false;
                rb_b.Visible = false;
                rb_c.Visible = false;
                rb_d.Visible = false;
                rb_e.Visible = false;

                btn_basla_bitir.Text = "Başla";
            }
        }

        private void cb_sinav_SelectedIndexChanged(object sender, EventArgs e)
        {
           sorular = sinavlar[cb_exam.SelectedIndex].getSinavSorulari();
        }

        private void refreshExam()
        {
            sinavlar = db.getSinavlar();
            cb_exam.Items.Clear();
            foreach (Sinav sinav in sinavlar)
            {
                cb_exam.Items.Add(sinav.getSinavAdi());
            }
        }
        private void refreshQuestion()
        {
            lbl_soru_no.Text = (soru_no +1).ToString() + " / " + sorular.Count();
            lbl_soru.Text = sorular[soru_no].getMetin();
            rb_a.Text = sorular[soru_no].getA();
            rb_b.Text = sorular[soru_no].getB();
            rb_c.Text = sorular[soru_no].getC();
            rb_d.Text = sorular[soru_no].getD();
            rb_e.Text = sorular[soru_no].getE();
        }

        private void rb_a_CheckedChanged(object sender, EventArgs e)
        {
            cevap = 'A';
        }

        private void rb_b_CheckedChanged(object sender, EventArgs e)
        {
            cevap = 'B';
        }

        private void rb_c_CheckedChanged(object sender, EventArgs e)
        {
            cevap = 'C';
        }

        private void rb_d_CheckedChanged(object sender, EventArgs e)
        {
            cevap = 'D';
        }

        private void rb_e_CheckedChanged(object sender, EventArgs e)
        {
            cevap = 'E';
        }
    }
}
