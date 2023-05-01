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
            refreshExam();
            if (btn_basla_bitir.Text == "Başla")
            {
                soru_no = 0;
                if (sinavlar.Count() > 0)
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
                    MessageBox.Show("aktif sınavınız yok");
                }
            }
            else
            {
                while(soru_no < sorular.Count())
                {
                    saveAnswer();
                    soru_no++;
                }
                finishExam();
            }

        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            saveAnswer();
            soru_no++;
            if (soru_no < sorular.Count())
            {
                refreshQuestion();
                if (soru_no == sorular.Count() - 1)
                {
                    btn_sonraki.Visible = false;
                }
            }
        }

        private void cb_sinav_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorular = sinavlar[cb_exam.SelectedIndex].getSinavSorulari();
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
            rb_a.Text = sorular[soru_no].getA();
            rb_b.Text = sorular[soru_no].getB();
            rb_c.Text = sorular[soru_no].getC();
            rb_d.Text = sorular[soru_no].getD();
            rb_e.Text = sorular[soru_no].getE();
        }

        private void saveAnswer()
        {
            db.setCevap(sorular[soru_no].getSinavId(), sorular[soru_no].getId(), cevap);

            rb_a.Checked = false;
            rb_b.Checked = false;
            rb_c.Checked = false;
            rb_d.Checked = false;
            rb_e.Checked = false;
            cevap = 'Z';
        }

        private void finishExam()
        {
            btn_basla_bitir.Text = "Başla";
            soru_no = 0;
            sorular.Clear();
            refreshExam();

            btn_sonraki.Visible = false;
            lbl_soru_no.Visible = false;
            lbl_soru.Visible = false;
            rb_a.Visible = false;
            rb_b.Visible = false;
            rb_c.Visible = false;
            rb_d.Visible = false;
            rb_e.Visible = false;
            cb_exam.Visible = true;
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
