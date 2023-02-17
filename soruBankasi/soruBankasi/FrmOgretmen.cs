using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soruBankasi
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

            txt_ad.Text = Data.DOgretmen.getName();
            txt_no.Text = Data.DOgretmen.getNo();
            txt_sifre.Text = Data.DOgretmen.getSifre();
            SoruList();
            OgrenciList();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if (btn_cikis.Text == "Çıkış Yap")
            {
                Data.DOgretmen = null;
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (btn_cikis.Text == "Kaydet")
            {
                Data.DOgretmen.setName(txt_ad.Text);
                Data.DOgretmen.setNo(txt_no.Text);
                Data.DOgretmen.setSifre(txt_sifre.Text);
                Data.ogretmenler[Data.DOgretmen.getId()] = Data.DOgretmen;

                txt_ad.Enabled = false;
                txt_no.Enabled = false;
                txt_sifre.Enabled = false;

                btn_cikis.Text = "Çıkış Yap";
                btn_duzenle.Text = "Düzenle";
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (btn_duzenle.Text == "Düzenle")
            {
                txt_ad.Enabled = true;
                txt_no.Enabled = true;
                txt_sifre.Enabled = true;

                btn_cikis.Text = "Kaydet";
                btn_duzenle.Text = "Vazgeç";
            }
            else if (btn_duzenle.Text == "Vazgeç")
            {
                txt_ad.Enabled = false;
                txt_no.Enabled = false;
                txt_sifre.Enabled = false;

                txt_ad.Text = Data.DOgretmen.getName();
                txt_no.Text = Data.DOgretmen.getNo();
                txt_sifre.Text = Data.DOgretmen.getSifre();

                btn_cikis.Text = "Çıkış Yap";
                btn_duzenle.Text = "Düzenle";
            }


        }

        private void OgrenciList()
        {

            foreach (Ogrenci ogrenci in Data.ogrenciler)
            {
                Panel panel = new Panel();
                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();

                panel.BackColor = Color.Teal;
                panel.Margin = new Padding(20);

                panel.Size = new Size(200, 270);
                panel.Controls.Add(lbl1);
                panel.Controls.Add(lbl2);
                panel.Controls.Add(lbl3);

                lbl1.Location = new Point(70, 70);
                lbl2.Location = new Point(70, 140);
                lbl3.Location = new Point(70, 210);

                lbl1.Text = ogrenci.getName();
                lbl2.Text = ogrenci.getNo();
                lbl3.Text = ogrenci.getSinif() + " " + ogrenci.getSube();

                flp_ogrenciler.Controls.Add(panel);
            }
        }
        private void SoruList()
        {
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {

        }
    }
}
