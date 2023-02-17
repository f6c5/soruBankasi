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
            this.tab_ogretmen = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flp_ogrenciler = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flp_sinav = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_soru = new System.Windows.Forms.Panel();
            this.txt_soru_metni = new System.Windows.Forms.TextBox();
            this.lbl_soru_sayisi = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cevap = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tab_ogretmen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flp_sinav.SuspendLayout();
            this.pnl_soru.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // tab_ogretmen
            // 
            this.tab_ogretmen.Controls.Add(this.tabPage1);
            this.tab_ogretmen.Controls.Add(this.tabPage2);
            this.tab_ogretmen.Controls.Add(this.tabPage3);
            this.tab_ogretmen.Location = new System.Drawing.Point(392, 12);
            this.tab_ogretmen.Name = "tab_ogretmen";
            this.tab_ogretmen.SelectedIndex = 0;
            this.tab_ogretmen.Size = new System.Drawing.Size(877, 602);
            this.tab_ogretmen.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flp_ogrenciler);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenciler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flp_ogrenciler
            // 
            this.flp_ogrenciler.AutoScroll = true;
            this.flp_ogrenciler.Location = new System.Drawing.Point(6, 6);
            this.flp_ogrenciler.Name = "flp_ogrenciler";
            this.flp_ogrenciler.Size = new System.Drawing.Size(857, 553);
            this.flp_ogrenciler.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flp_sinav);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sınav ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(869, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sınavlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flp_sinav
            // 
            this.flp_sinav.AutoScroll = true;
            this.flp_sinav.Controls.Add(this.pnl_soru);
            this.flp_sinav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_sinav.Location = new System.Drawing.Point(6, 6);
            this.flp_sinav.Name = "flp_sinav";
            this.flp_sinav.Size = new System.Drawing.Size(857, 553);
            this.flp_sinav.TabIndex = 0;
            // 
            // pnl_soru
            // 
            this.pnl_soru.Controls.Add(this.btn_vazgec);
            this.pnl_soru.Controls.Add(this.btn_kaydet);
            this.pnl_soru.Controls.Add(this.txt_e);
            this.pnl_soru.Controls.Add(this.label9);
            this.pnl_soru.Controls.Add(this.txt_d);
            this.pnl_soru.Controls.Add(this.label8);
            this.pnl_soru.Controls.Add(this.txt_c);
            this.pnl_soru.Controls.Add(this.label7);
            this.pnl_soru.Controls.Add(this.txt_b);
            this.pnl_soru.Controls.Add(this.label6);
            this.pnl_soru.Controls.Add(this.txt_cevap);
            this.pnl_soru.Controls.Add(this.label10);
            this.pnl_soru.Controls.Add(this.txt_a);
            this.pnl_soru.Controls.Add(this.label5);
            this.pnl_soru.Controls.Add(this.lbl_soru_sayisi);
            this.pnl_soru.Controls.Add(this.txt_soru_metni);
            this.pnl_soru.Location = new System.Drawing.Point(10, 10);
            this.pnl_soru.Margin = new System.Windows.Forms.Padding(10);
            this.pnl_soru.Name = "pnl_soru";
            this.pnl_soru.Size = new System.Drawing.Size(829, 297);
            this.pnl_soru.TabIndex = 0;
            // 
            // txt_soru_metni
            // 
            this.txt_soru_metni.Location = new System.Drawing.Point(101, 13);
            this.txt_soru_metni.Multiline = true;
            this.txt_soru_metni.Name = "txt_soru_metni";
            this.txt_soru_metni.Size = new System.Drawing.Size(715, 139);
            this.txt_soru_metni.TabIndex = 0;
            // 
            // lbl_soru_sayisi
            // 
            this.lbl_soru_sayisi.AutoSize = true;
            this.lbl_soru_sayisi.Location = new System.Drawing.Point(9, 18);
            this.lbl_soru_sayisi.Name = "lbl_soru_sayisi";
            this.lbl_soru_sayisi.Size = new System.Drawing.Size(55, 24);
            this.lbl_soru_sayisi.TabIndex = 1;
            this.lbl_soru_sayisi.Text = "Soru:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(67, 171);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(62, 29);
            this.txt_a.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "A-)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "B-)";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(238, 171);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(62, 29);
            this.txt_b.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "C-)";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(409, 171);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(62, 29);
            this.txt_c.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "D-)";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(580, 171);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(62, 29);
            this.txt_d.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(710, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "E-)";
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(763, 171);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(62, 29);
            this.txt_e.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cevap:";
            // 
            // txt_cevap
            // 
            this.txt_cevap.Location = new System.Drawing.Point(101, 241);
            this.txt_cevap.Name = "txt_cevap";
            this.txt_cevap.Size = new System.Drawing.Size(62, 29);
            this.txt_cevap.TabIndex = 2;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(599, 237);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(214, 39);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.Location = new System.Drawing.Point(373, 237);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(214, 39);
            this.btn_vazgec.TabIndex = 3;
            this.btn_vazgec.Text = "Vazgeç";
            this.btn_vazgec.UseVisualStyleBackColor = true;
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 626);
            this.Controls.Add(this.tab_ogretmen);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmOgretmen";
            this.Text = "FrmOgretmen";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_ogretmen.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flp_sinav.ResumeLayout(false);
            this.pnl_soru.ResumeLayout(false);
            this.pnl_soru.PerformLayout();
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
        private System.Windows.Forms.TabControl tab_ogretmen;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flp_ogrenciler;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flp_sinav;
        private System.Windows.Forms.Panel pnl_soru;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_soru_sayisi;
        private System.Windows.Forms.TextBox txt_soru_metni;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_cevap;
        private System.Windows.Forms.Label label10;
    }
}