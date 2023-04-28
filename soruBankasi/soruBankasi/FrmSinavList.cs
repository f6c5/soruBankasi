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
    public partial class FrmSinavList : Form
    {
        public FrmSinavList()
        {
            InitializeComponent();
        }
        Db_soru db = new Db_soru();
        List<Sinav> sinavlarim = new List<Sinav>();
        Soru soru;

        private void FrmSinavList_Load(object sender, EventArgs e)
        {
            refreshExam();
        }

        private void btn_add_exam_Click(object sender, EventArgs e)
        {
            pnl_add_exam.Visible = true;
            pnl_question_data.Visible = false;
        }

        private void btn_create_exam_Click(object sender, EventArgs e)
        {
            db.addSinav(txt_new_exam_name.Text, Data.DOgretmen.getId(), dtp_new_exam_date.Value);
            refreshExam();
        }

        private void btn_del_exam_Click(object sender, EventArgs e)
        {
            if (cb_exam.SelectedItem != null)
            {
                if (MessageBox.Show("Sınavı silmek istediğinizden emin misiniz?\n\rbu işlem geri alınamaz", "Sınavı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.deleteSinav(sinavlarim[cb_exam.SelectedIndex].getId());
                    refreshExam();
                }
            }
            else
            {
                MessageBox.Show("silmek istediğiniz sınavı seçin");
            }
        }

        private void cb_exam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_exam.SelectedItem != null)
            {
                cb_question.Enabled = true;
                cb_question.SelectedItem = null;
                cb_question.Items.Clear();

                for (int i = 0; i < sinavlarim[cb_exam.SelectedIndex].getSinavSorulari().Count; i++)
                {
                    cb_question.Items.Add("Soru " + (i + 1));
                }
            }
        }

        private void cb_question_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_question.SelectedItem != null)
            {
                pnl_edit_open();
                soru = sinavlarim[cb_exam.SelectedIndex].getSinavSorulari()[cb_question.SelectedIndex];
                txt_question.Text = soru.getMetin();
                txt_a.Text = soru.getA();
                txt_b.Text = soru.getB();
                txt_c.Text = soru.getC();
                txt_d.Text = soru.getD();
                txt_e.Text = soru.getE();
                cb_answer.SelectedIndex = 4 - ('E' - soru.getCevap().ToCharArray()[0]);
            }
        }

        private void btn_add_question_Click(object sender, EventArgs e)
        {
            if (cb_exam.SelectedItem != null)
            {
                pnl_add_open();
            }
            else
            {
                MessageBox.Show("soru eklemek istediğiniz sınavı seçin");
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_question.Text) && !string.IsNullOrEmpty(txt_a.Text) && !string.IsNullOrEmpty(txt_b.Text) && !string.IsNullOrEmpty(txt_c.Text) && !string.IsNullOrEmpty(txt_d.Text) && !string.IsNullOrEmpty(txt_e.Text) && cb_answer.SelectedIndex != -1)
            {

                if (btn_edit.Text == "Düzenle")
                {
                    soru.setMetin(txt_question.Text);
                    soru.setA(txt_a.Text);
                    soru.setB(txt_b.Text);
                    soru.setC(txt_c.Text);
                    soru.setD(txt_d.Text);
                    soru.setE(txt_e.Text);
                    soru.setCevap(cb_answer.SelectedItem.ToString());
                    db.updateSoru(soru);
                }

                if (btn_edit.Text == "Ekle")
                {
                    Soru yeniSoru = new Soru(sinavlarim[cb_exam.SelectedIndex].getId());
                    MessageBox.Show(txt_question.Text);
                    yeniSoru.setMetin(txt_question.Text);
                    yeniSoru.setA(txt_a.Text);
                    yeniSoru.setB(txt_b.Text);
                    yeniSoru.setC(txt_c.Text);
                    yeniSoru.setD(txt_d.Text);
                    yeniSoru.setE(txt_e.Text);
                    yeniSoru.setCevap(cb_answer.SelectedItem.ToString());
                    db.addSoru(yeniSoru);
                }
                refreshExam();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (btn_del.Text == "Sil")
            {
                db.deleteSoru(soru.getId());
                pnl_edit_close();
                refreshExam();
            }
            refreshExam();
        }

        private void pnl_edit_open()
        {
            pnl_add_exam.Visible = false;
            pnl_question_data.Visible = true;
            txt_question.ReadOnly = false;
            txt_a.ReadOnly = false;
            txt_b.ReadOnly = false;
            txt_c.ReadOnly = false;
            txt_d.ReadOnly = false;
            txt_e.ReadOnly = false;
            cb_answer.Enabled = true;
            txt_question.Text = "";
            txt_a.Text = "";
            txt_b.Text = "";
            txt_c.Text = "";
            txt_d.Text = "";
            txt_e.Text = "";
            btn_edit.Text = "Düzenle";
            btn_del.Text = "Sil";
        }

        private void pnl_edit_close()
        {
            pnl_question_data.Visible = false;
            txt_question.ReadOnly = true;
            txt_a.ReadOnly = true;
            txt_b.ReadOnly = true;
            txt_c.ReadOnly = true;
            txt_d.ReadOnly = true;
            txt_e.ReadOnly = true;
            cb_answer.Enabled = false;
        }
        private void pnl_add_open()
        {
            pnl_add_exam.Visible = false;
            pnl_question_data.Visible = true;
            txt_question.ReadOnly = false;
            txt_a.ReadOnly = false;
            txt_b.ReadOnly = false;
            txt_c.ReadOnly = false;
            txt_d.ReadOnly = false;
            txt_e.ReadOnly = false;
            cb_answer.Enabled = true;
            txt_question.Text = "";
            txt_a.Text = "";
            txt_b.Text = "";
            txt_c.Text = "";
            txt_d.Text = "";
            txt_e.Text = "";
            btn_edit.Text = "Ekle";
            btn_del.Text = "İptal";
        }
        private void refreshExam()
        {
            cb_exam.Items.Clear();
            sinavlarim = db.getSinavlarim(Data.DOgretmen.getId());
            foreach (Sinav sinav in sinavlarim)
            {
                cb_exam.Items.Add(sinav.getSinavAdi());
            }
            cb_question.Items.Clear();
        }
    }
}
