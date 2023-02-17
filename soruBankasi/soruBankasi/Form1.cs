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
            Data.ogrenciler.Add(new Ogrenci(0, "ayşe", "538", "12", "b"));
            Data.ogrenciler.Add(new Ogrenci(1, "berat", "432", "11", "a"));
            Data.ogrenciler.Add(new Ogrenci(2, "ali", "438", "11", "f"));
            Data.ogrenciler.Add(new Ogrenci(3, "mehmet", "111", "12", "a"));
            Data.ogrenciler.Add(new Ogrenci(4, "acun", "123", "10", "b"));

            Data.ogretmenler.Add(new Ogretmen(0, "ferhat", "539", "13579"));
            Data.ogretmenler.Add(new Ogretmen(0, "aylin", "524", "456"));
            Data.ogretmenler.Add(new Ogretmen(0, "ümit", "124", "1234"));
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
            bool isKayitli = false;

            if (isOgretmen == true)
            {
                for (int i = 0; i < Data.ogretmenler.Count; i++)
                {
                    if (Data.ogretmenler[i].getNo() == txt_ogretmen_no.Text)
                    {
                        isKayitli = true;
                        break;
                    }
                };

                if (isKayitli == true)
                {

                    MessageBox.Show("böyle bir öğretmen zaten kayıtlı");
                }
                else
                {
                    Data.ogretmenler.Add(new Ogretmen(Data.ogretmenler.Count, txt_ogretmen_ad.Text, txt_ogretmen_no.Text, txt_ogretmen_sifre.Text));
                    MessageBox.Show("kayıt başarılı");
                }

            }
            else if (isOgretmen == false)
            {
                for (int i = 0; i < Data.ogrenciler.Count; i++)
                {
                    if (Data.ogrenciler[i].getNo() == txt_ogrenci_no.Text)
                    {
                        MessageBox.Show("böyle bir öğrenci zaten kayıtlı");
                        isKayitli = true;
                    }
                };

                if (isKayitli == false)
                {
                    Data.ogrenciler.Add(new Ogrenci(Data.ogrenciler.Count, txt_ogrenci_ad.Text, txt_ogrenci_no.Text, txt_ogrenci_sinif.Text, txt_ogrenci_sube.Text));
                    MessageBox.Show("kayıt başarılı");
                }
            }


        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            bool isKayitli = false;

            if (isOgretmen == true)
            {
                for (int i = 0; i < Data.ogretmenler.Count; i++)
                {
                    if (Data.ogretmenler[i].getNo() == txt_ogretmen_no.Text && Data.ogretmenler[i].getSifre() == txt_ogretmen_sifre.Text)
                    {
                        isKayitli = true;
                        Data.DOgretmen = Data.ogretmenler[i];
                        break;
                    }
                }

                if (isKayitli == true)
                {
                    FrmOgretmen frmOgretmen = new FrmOgretmen();
                    frmOgretmen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("böyle bir kişi yok");
                }
            }
            else if (isOgretmen == false)
            {
                for (int i = 0; i < Data.ogrenciler.Count; i++)
                {
                    if (Data.ogrenciler[i].getNo() == txt_ogrenci_no.Text)
                    {
                        isKayitli = true;
                        Data.DOgrenci = Data.ogrenciler[i];
                        break;
                    }
                }

                if (isKayitli == true)
                {
                    FrmOgrenci frmOgrenci = new FrmOgrenci();
                    frmOgrenci.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("böyle bir kişi yok");
                }
            }
        }
    }
}
