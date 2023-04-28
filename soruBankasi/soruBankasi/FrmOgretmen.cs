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

        }

        private void btn_ogrenci_list_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmOgrenciList());
        }

        private void btn_sinav_list_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSinavList());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        Form activeForm;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_app.Controls.Add(childForm);
            pnl_app.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FrmOgretmen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
