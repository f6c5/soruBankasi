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
    public partial class FrmOgrenciList : Form
    {
        public FrmOgrenciList()
        {
            InitializeComponent();
        }

        private void FrmOgrenciList_Load(object sender, EventArgs e)
        {
            ogrenci_list();
        }

        Db_soru db = new Db_soru();
        List<Sinav> sinavlarim = new List<Sinav>();

        private void ogrenci_list()
        {
            flp_ogrenci_list.Controls.Clear();

            Db_soru db_Soru = new Db_soru();

            foreach (var kisi in db_Soru.getOgrenciler())
            {
                Button btn_ogrenci = new Button();
                btn_ogrenci.Name = kisi.getId().ToString();
                btn_ogrenci.Width = 150;
                btn_ogrenci.Height = 200;
                btn_ogrenci.Text = kisi.getName() + "\n" + kisi.getNo() + "\n" + kisi.getSinif() + "/" + kisi.getSube();
                btn_ogrenci.Click += new EventHandler(ogrenciSecme);
                flp_ogrenci_list.Controls.Add(btn_ogrenci);
            }

        }

        private void ogrenciSecme(object sender, EventArgs e)
        {
            Db_soru db_Soru = new Db_soru();
            Ogrenci ogrenci = db_Soru.getOgrenci(Convert.ToInt32(((Button)sender).Name));

            if (ogrenci != null)
            {
                txt_ad.Text = ogrenci.getName();
                txt_no.Text = ogrenci.getNo();
                txt_sinif.Text = ogrenci.getSinif() + "/" + ogrenci.getSube();
            }
        }
    }
}
