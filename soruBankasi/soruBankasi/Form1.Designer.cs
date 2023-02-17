namespace soruBankasi
{
    partial class Form1
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
            this.btn_kayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ogrenci_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ogrenci_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ogrenci_sinif = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_sube = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ogretmen_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ogretmen_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ogretmen_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.pnl_ogretmen = new System.Windows.Forms.Panel();
            this.btn_pnl_ogrenci = new System.Windows.Forms.Button();
            this.btn_pnl_ogretmen = new System.Windows.Forms.Button();
            this.pnl_ogrenci = new System.Windows.Forms.Panel();
            this.pnl_ogretmen.SuspendLayout();
            this.pnl_ogrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(431, 481);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(227, 52);
            this.btn_kayit.TabIndex = 0;
            this.btn_kayit.Text = "Kayıt Yap";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Visible = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(206, 143);
            this.txt_ogrenci_ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(226, 26);
            this.txt_ogrenci_ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "No:";
            // 
            // txt_ogrenci_no
            // 
            this.txt_ogrenci_no.Location = new System.Drawing.Point(206, 194);
            this.txt_ogrenci_no.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ogrenci_no.Name = "txt_ogrenci_no";
            this.txt_ogrenci_no.Size = new System.Drawing.Size(226, 26);
            this.txt_ogrenci_no.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şube:";
            // 
            // txt_ogrenci_sinif
            // 
            this.txt_ogrenci_sinif.Location = new System.Drawing.Point(206, 248);
            this.txt_ogrenci_sinif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ogrenci_sinif.Name = "txt_ogrenci_sinif";
            this.txt_ogrenci_sinif.Size = new System.Drawing.Size(92, 26);
            this.txt_ogrenci_sinif.TabIndex = 2;
            // 
            // txt_ogrenci_sube
            // 
            this.txt_ogrenci_sube.Location = new System.Drawing.Point(340, 248);
            this.txt_ogrenci_sube.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ogrenci_sube.Name = "txt_ogrenci_sube";
            this.txt_ogrenci_sube.Size = new System.Drawing.Size(92, 26);
            this.txt_ogrenci_sube.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ad Soyad:";
            // 
            // txt_ogretmen_ad
            // 
            this.txt_ogretmen_ad.Location = new System.Drawing.Point(178, 143);
            this.txt_ogretmen_ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ogretmen_ad.Name = "txt_ogretmen_ad";
            this.txt_ogretmen_ad.Size = new System.Drawing.Size(226, 26);
            this.txt_ogretmen_ad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "No:";
            // 
            // txt_ogretmen_no
            // 
            this.txt_ogretmen_no.Location = new System.Drawing.Point(178, 194);
            this.txt_ogretmen_no.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ogretmen_no.Name = "txt_ogretmen_no";
            this.txt_ogretmen_no.Size = new System.Drawing.Size(226, 26);
            this.txt_ogretmen_no.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Şifre:";
            // 
            // txt_ogretmen_sifre
            // 
            this.txt_ogretmen_sifre.Location = new System.Drawing.Point(178, 251);
            this.txt_ogretmen_sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ogretmen_sifre.Name = "txt_ogretmen_sifre";
            this.txt_ogretmen_sifre.PasswordChar = '*';
            this.txt_ogretmen_sifre.Size = new System.Drawing.Size(226, 26);
            this.txt_ogretmen_sifre.TabIndex = 2;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(724, 481);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(227, 52);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Visible = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // pnl_ogretmen
            // 
            this.pnl_ogretmen.Controls.Add(this.txt_ogretmen_ad);
            this.pnl_ogretmen.Controls.Add(this.txt_ogretmen_sifre);
            this.pnl_ogretmen.Controls.Add(this.label5);
            this.pnl_ogretmen.Controls.Add(this.label6);
            this.pnl_ogretmen.Controls.Add(this.txt_ogretmen_no);
            this.pnl_ogretmen.Controls.Add(this.label7);
            this.pnl_ogretmen.Location = new System.Drawing.Point(431, 12);
            this.pnl_ogretmen.Name = "pnl_ogretmen";
            this.pnl_ogretmen.Size = new System.Drawing.Size(520, 426);
            this.pnl_ogretmen.TabIndex = 3;
            this.pnl_ogretmen.Visible = false;
            // 
            // btn_pnl_ogrenci
            // 
            this.btn_pnl_ogrenci.Location = new System.Drawing.Point(70, 180);
            this.btn_pnl_ogrenci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pnl_ogrenci.Name = "btn_pnl_ogrenci";
            this.btn_pnl_ogrenci.Size = new System.Drawing.Size(255, 52);
            this.btn_pnl_ogrenci.TabIndex = 0;
            this.btn_pnl_ogrenci.Text = "Öğrenci";
            this.btn_pnl_ogrenci.UseVisualStyleBackColor = true;
            this.btn_pnl_ogrenci.Click += new System.EventHandler(this.btn_pnl_ogrenci_Click);
            // 
            // btn_pnl_ogretmen
            // 
            this.btn_pnl_ogretmen.Location = new System.Drawing.Point(70, 268);
            this.btn_pnl_ogretmen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pnl_ogretmen.Name = "btn_pnl_ogretmen";
            this.btn_pnl_ogretmen.Size = new System.Drawing.Size(255, 52);
            this.btn_pnl_ogretmen.TabIndex = 0;
            this.btn_pnl_ogretmen.Text = "Öğretmen";
            this.btn_pnl_ogretmen.UseVisualStyleBackColor = true;
            this.btn_pnl_ogretmen.Click += new System.EventHandler(this.btn_pnl_ogretmen_Click);
            // 
            // pnl_ogrenci
            // 
            this.pnl_ogrenci.Controls.Add(this.txt_ogrenci_ad);
            this.pnl_ogrenci.Controls.Add(this.label1);
            this.pnl_ogrenci.Controls.Add(this.txt_ogrenci_sube);
            this.pnl_ogrenci.Controls.Add(this.label2);
            this.pnl_ogrenci.Controls.Add(this.txt_ogrenci_sinif);
            this.pnl_ogrenci.Controls.Add(this.txt_ogrenci_no);
            this.pnl_ogrenci.Controls.Add(this.label4);
            this.pnl_ogrenci.Controls.Add(this.label3);
            this.pnl_ogrenci.Location = new System.Drawing.Point(431, 12);
            this.pnl_ogrenci.Name = "pnl_ogrenci";
            this.pnl_ogrenci.Size = new System.Drawing.Size(520, 426);
            this.pnl_ogrenci.TabIndex = 4;
            this.pnl_ogrenci.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.pnl_ogrenci);
            this.Controls.Add(this.pnl_ogretmen);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_pnl_ogretmen);
            this.Controls.Add(this.btn_pnl_ogrenci);
            this.Controls.Add(this.btn_kayit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_ogretmen.ResumeLayout(false);
            this.pnl_ogretmen.PerformLayout();
            this.pnl_ogrenci.ResumeLayout(false);
            this.pnl_ogrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogrenci_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ogrenci_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ogrenci_sinif;
        private System.Windows.Forms.TextBox txt_ogrenci_sube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ogretmen_ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ogretmen_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ogretmen_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Panel pnl_ogretmen;
        private System.Windows.Forms.Button btn_pnl_ogrenci;
        private System.Windows.Forms.Button btn_pnl_ogretmen;
        private System.Windows.Forms.Panel pnl_ogrenci;
    }
}

