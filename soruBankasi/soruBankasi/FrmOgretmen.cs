using Google.Protobuf.Compiler;
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

        private void btn_ogrenci_list_Click(object sender, EventArgs e)
        {
            Db_soru db_Soru = new Db_soru();
            foreach (var item in db_Soru.getOgrenciler())
            {
                dgv_ogrenciler.Rows.Add(item.getName(),item.getNo(), item.getSinif(), item.getSube());
            }
        }
    }
}
