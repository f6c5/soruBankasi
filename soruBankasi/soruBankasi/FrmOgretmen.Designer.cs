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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.btn_ogrenci_list = new System.Windows.Forms.Button();
            this.btn_sinav_list = new System.Windows.Forms.Button();
            this.btn_sinif_ort = new System.Windows.Forms.Button();
            this.sube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ogrenciler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Controls.Add(this.btn_duzenle);
            this.panel1.Controls.Add(this.txt_sifre);
            this.panel1.Controls.Add(this.txt_no);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 596);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cikis.Location = new System.Drawing.Point(207, 489);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(138, 42);
            this.btn_cikis.TabIndex = 1;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_duzenle.Location = new System.Drawing.Point(34, 489);
            this.btn_duzenle.Margin = new System.Windows.Forms.Padding(6);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(138, 42);
            this.btn_duzenle.TabIndex = 1;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Enabled = false;
            this.txt_sifre.Location = new System.Drawing.Point(168, 281);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(6);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(163, 29);
            this.txt_sifre.TabIndex = 0;
            // 
            // txt_no
            // 
            this.txt_no.Enabled = false;
            this.txt_no.Location = new System.Drawing.Point(168, 188);
            this.txt_no.Margin = new System.Windows.Forms.Padding(6);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(163, 29);
            this.txt_no.TabIndex = 0;
            // 
            // txt_ad
            // 
            this.txt_ad.Enabled = false;
            this.txt_ad.Location = new System.Drawing.Point(168, 96);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(6);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(163, 29);
            this.txt_ad.TabIndex = 0;
            // 
            // btn_ogrenci_list
            // 
            this.btn_ogrenci_list.Location = new System.Drawing.Point(411, 21);
            this.btn_ogrenci_list.Name = "btn_ogrenci_list";
            this.btn_ogrenci_list.Size = new System.Drawing.Size(150, 32);
            this.btn_ogrenci_list.TabIndex = 2;
            this.btn_ogrenci_list.Text = "öğrenciler";
            this.btn_ogrenci_list.UseVisualStyleBackColor = true;
            this.btn_ogrenci_list.Click += new System.EventHandler(this.btn_ogrenci_list_Click);
            // 
            // btn_sinav_list
            // 
            this.btn_sinav_list.Location = new System.Drawing.Point(757, 21);
            this.btn_sinav_list.Name = "btn_sinav_list";
            this.btn_sinav_list.Size = new System.Drawing.Size(150, 32);
            this.btn_sinav_list.TabIndex = 2;
            this.btn_sinav_list.Text = "sınavlar";
            this.btn_sinav_list.UseVisualStyleBackColor = true;
            // 
            // btn_sinif_ort
            // 
            this.btn_sinif_ort.Location = new System.Drawing.Point(1103, 21);
            this.btn_sinif_ort.Name = "btn_sinif_ort";
            this.btn_sinif_ort.Size = new System.Drawing.Size(150, 32);
            this.btn_sinif_ort.TabIndex = 2;
            this.btn_sinif_ort.Text = "sınıflar";
            this.btn_sinif_ort.UseVisualStyleBackColor = true;
            // 
            // sube
            // 
            this.sube.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sube.HeaderText = "Şube";
            this.sube.Name = "sube";
            this.sube.ReadOnly = true;
            // 
            // sinif
            // 
            this.sinif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sinif.HeaderText = "Sınıf";
            this.sinif.Name = "sinif";
            this.sinif.ReadOnly = true;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.no.HeaderText = "Numara";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Ad soyad";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dgv_ogrenciler
            // 
            this.dgv_ogrenciler.AllowUserToAddRows = false;
            this.dgv_ogrenciler.AllowUserToDeleteRows = false;
            this.dgv_ogrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ogrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.no,
            this.sinif,
            this.sube});
            this.dgv_ogrenciler.Location = new System.Drawing.Point(411, 78);
            this.dgv_ogrenciler.Name = "dgv_ogrenciler";
            this.dgv_ogrenciler.ReadOnly = true;
            this.dgv_ogrenciler.Size = new System.Drawing.Size(858, 536);
            this.dgv_ogrenciler.TabIndex = 3;
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 626);
            this.Controls.Add(this.dgv_ogrenciler);
            this.Controls.Add(this.btn_sinif_ort);
            this.Controls.Add(this.btn_sinav_list);
            this.Controls.Add(this.btn_ogrenci_list);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmOgretmen";
            this.Text = "FrmOgretmen";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_ogrenci_list;
        private System.Windows.Forms.Button btn_sinav_list;
        private System.Windows.Forms.Button btn_sinif_ort;
        private System.Windows.Forms.DataGridViewTextBoxColumn sube;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridView dgv_ogrenciler;
    }
}