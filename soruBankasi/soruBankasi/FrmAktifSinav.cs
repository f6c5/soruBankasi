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
        Db_soru db = new Db_soru();
        List<Sinav> sinavlarim = new List<Sinav>();
        Soru soru;

        private void FrmAktifSinav_Load(object sender, EventArgs e)
        {

        }

        private void btn_basla_bitir_Click(object sender, EventArgs e)
        {

        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {

        }

        private void cb_sinav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshExam()
        {
            cb_exam.Items.Clear();
            sinavlarim = db.getSinavlarim(Data.DOgretmen.getId());
            foreach (Sinav sinav in sinavlarim)
            {
                cb_exam.Items.Add(sinav.getSinavAdi());
            }
        }
    }
}
