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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool isOgretmen;

        private void btn_pnl_ogrenci_Click(object sender, EventArgs e)
        {
            pnl_ogrenci.Visible = true;
            pnl_ogretmen.Visible = false;
            btn_giris.Visible = true;
            btn_kayit.Visible = true;
            isOgretmen = false;
        }

        private void btn_pnl_ogretmen_Click(object sender, EventArgs e)
        {
            pnl_ogrenci.Visible = false;
            pnl_ogretmen.Visible = true;
            btn_giris.Visible = true;
            btn_kayit.Visible = true;
            isOgretmen = true;
        }


        private void btn_kayit_Click(object sender, EventArgs e)
        {

            Db_soru db_Soru = new Db_soru();

            if (isOgretmen == true)
            {
                db_Soru.addOgretmen(new Ogretmen(txt_ogretmen_ad.Text, txt_ogretmen_no.Text, txt_ogretmen_sifre.Text));
            }
            else if (isOgretmen == false)
            {
                db_Soru.addOgrenci(new Ogrenci(txt_ogrenci_ad.Text,txt_ogrenci_no.Text,txt_ogrenci_sinif.Text,txt_ogrenci_sube.Text));
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Db_soru db_Soru = new Db_soru();

            if (isOgretmen == true)
            {

                Ogretmen ogretmen = db_Soru.logInOgretmen(txt_ogretmen_no.Text, txt_ogretmen_sifre.Text);

                if (ogretmen != null)
                {
                    Data.DOgretmen = ogretmen;
                    FrmOgretmen frmOgretmen = new FrmOgretmen();
                    frmOgretmen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("böyle bir öğretmen kayıtlı değil");
                }
            }
            else if (isOgretmen == false)
            {
                Ogrenci ogrenci = db_Soru.logInOgrenci(txt_ogrenci_no.Text);

                if (ogrenci != null)
                {
                    Data.DOgrenci = ogrenci;
                    FrmOgrenci frmOgrenci = new FrmOgrenci();
                    frmOgrenci.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("böyle bir öğrenci kayıtlı değil");
                }
            }
        }
    }
}
