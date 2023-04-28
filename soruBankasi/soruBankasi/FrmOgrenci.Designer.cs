namespace soruBankasi
{
    partial class FrmOgrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_app = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_aktif_sinav = new System.Windows.Forms.Button();
            this.btn_gecmis_sinav = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_app
            // 
            this.pnl_app.AutoSize = true;
            this.pnl_app.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_app.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_app.Location = new System.Drawing.Point(281, 0);
            this.pnl_app.Name = "pnl_app";
            this.pnl_app.Size = new System.Drawing.Size(1186, 831);
            this.pnl_app.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_gecmis_sinav);
            this.panel1.Controls.Add(this.btn_aktif_sinav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 831);
            this.panel1.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(40, 283);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(199, 32);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Çıkış yap";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_aktif_sinav
            // 
            this.btn_aktif_sinav.Location = new System.Drawing.Point(40, 61);
            this.btn_aktif_sinav.Name = "btn_aktif_sinav";
            this.btn_aktif_sinav.Size = new System.Drawing.Size(199, 32);
            this.btn_aktif_sinav.TabIndex = 2;
            this.btn_aktif_sinav.Text = "Aktif Sınavlar";
            this.btn_aktif_sinav.UseVisualStyleBackColor = true;
            // 
            // btn_gecmis_sinav
            // 
            this.btn_gecmis_sinav.Location = new System.Drawing.Point(40, 172);
            this.btn_gecmis_sinav.Name = "btn_gecmis_sinav";
            this.btn_gecmis_sinav.Size = new System.Drawing.Size(199, 32);
            this.btn_gecmis_sinav.TabIndex = 2;
            this.btn_gecmis_sinav.Text = "Geçmiş Sınavlar";
            this.btn_gecmis_sinav.UseVisualStyleBackColor = true;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.pnl_app);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOgrenci_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_app;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_aktif_sinav;
        private System.Windows.Forms.Button btn_gecmis_sinav;
    }
}