namespace soruBankasi
{
    partial class FrmOgretmen
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
            this.btn_ogrenci_list = new System.Windows.Forms.Button();
            this.btn_sinav_list = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_app = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ogrenci_list
            // 
            this.btn_ogrenci_list.Location = new System.Drawing.Point(44, 72);
            this.btn_ogrenci_list.Name = "btn_ogrenci_list";
            this.btn_ogrenci_list.Size = new System.Drawing.Size(199, 32);
            this.btn_ogrenci_list.TabIndex = 2;
            this.btn_ogrenci_list.Text = "Öğrenci Listesi";
            this.btn_ogrenci_list.UseVisualStyleBackColor = true;
            this.btn_ogrenci_list.Click += new System.EventHandler(this.btn_ogrenci_list_Click);
            // 
            // btn_sinav_list
            // 
            this.btn_sinav_list.Location = new System.Drawing.Point(44, 167);
            this.btn_sinav_list.Name = "btn_sinav_list";
            this.btn_sinav_list.Size = new System.Drawing.Size(199, 32);
            this.btn_sinav_list.TabIndex = 2;
            this.btn_sinav_list.Text = "Sınav Listesi";
            this.btn_sinav_list.UseVisualStyleBackColor = true;
            this.btn_sinav_list.Click += new System.EventHandler(this.btn_sinav_list_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_ogrenci_list);
            this.panel1.Controls.Add(this.btn_sinav_list);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 626);
            this.panel1.TabIndex = 4;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(44, 262);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(199, 32);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Çıkış yap";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_app
            // 
            this.pnl_app.AutoSize = true;
            this.pnl_app.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_app.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_app.Location = new System.Drawing.Point(281, 0);
            this.pnl_app.Name = "pnl_app";
            this.pnl_app.Size = new System.Drawing.Size(1000, 626);
            this.pnl_app.TabIndex = 5;
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 626);
            this.Controls.Add(this.pnl_app);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmOgretmen";
            this.Text = "FrmOgretmen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOgretmen_FormClosed);
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ogrenci_list;
        private System.Windows.Forms.Button btn_sinav_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_app;
        private System.Windows.Forms.Button btn_exit;
    }
}