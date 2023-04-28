namespace soruBankasi
{
    partial class FrmOgrenciList
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_ogrenci = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_sinif = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_ogrenci_list = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_sinav = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_exam = new System.Windows.Forms.ComboBox();
            this.lbl_not = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ogrenci = new System.Windows.Forms.Label();
            this.flp_ogrenci_list_sinav = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tab_ogrenci.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_sinav.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ogrenci);
            this.tabControl1.Controls.Add(this.tab_sinav);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 50);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_ogrenci
            // 
            this.tab_ogrenci.Controls.Add(this.panel1);
            this.tab_ogrenci.Controls.Add(this.flp_ogrenci_list);
            this.tab_ogrenci.Location = new System.Drawing.Point(4, 54);
            this.tab_ogrenci.Name = "tab_ogrenci";
            this.tab_ogrenci.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ogrenci.Size = new System.Drawing.Size(988, 538);
            this.tab_ogrenci.TabIndex = 0;
            this.tab_ogrenci.Text = "Öğrenciler";
            this.tab_ogrenci.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_sinif);
            this.panel1.Controls.Add(this.txt_no);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(657, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 532);
            this.panel1.TabIndex = 1;
            // 
            // txt_sinif
            // 
            this.txt_sinif.Location = new System.Drawing.Point(84, 207);
            this.txt_sinif.Name = "txt_sinif";
            this.txt_sinif.ReadOnly = true;
            this.txt_sinif.Size = new System.Drawing.Size(200, 24);
            this.txt_sinif.TabIndex = 1;
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(84, 119);
            this.txt_no.Name = "txt_no";
            this.txt_no.ReadOnly = true;
            this.txt_no.Size = new System.Drawing.Size(200, 24);
            this.txt_no.TabIndex = 1;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(84, 31);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(200, 24);
            this.txt_ad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sınıf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // flp_ogrenci_list
            // 
            this.flp_ogrenci_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_ogrenci_list.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flp_ogrenci_list.Location = new System.Drawing.Point(3, 3);
            this.flp_ogrenci_list.Name = "flp_ogrenci_list";
            this.flp_ogrenci_list.Padding = new System.Windows.Forms.Padding(10);
            this.flp_ogrenci_list.Size = new System.Drawing.Size(652, 532);
            this.flp_ogrenci_list.TabIndex = 0;
            // 
            // tab_sinav
            // 
            this.tab_sinav.Controls.Add(this.panel2);
            this.tab_sinav.Controls.Add(this.flp_ogrenci_list_sinav);
            this.tab_sinav.Location = new System.Drawing.Point(4, 54);
            this.tab_sinav.Name = "tab_sinav";
            this.tab_sinav.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sinav.Size = new System.Drawing.Size(988, 538);
            this.tab_sinav.TabIndex = 2;
            this.tab_sinav.Text = "Sınav Sonuçları";
            this.tab_sinav.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_exam);
            this.panel2.Controls.Add(this.lbl_not);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_ogrenci);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(657, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 532);
            this.panel2.TabIndex = 3;
            // 
            // cb_exam
            // 
            this.cb_exam.FormattingEnabled = true;
            this.cb_exam.Location = new System.Drawing.Point(88, 141);
            this.cb_exam.Name = "cb_exam";
            this.cb_exam.Size = new System.Drawing.Size(194, 26);
            this.cb_exam.TabIndex = 1;
            // 
            // lbl_not
            // 
            this.lbl_not.AutoSize = true;
            this.lbl_not.Location = new System.Drawing.Point(88, 198);
            this.lbl_not.Name = "lbl_not";
            this.lbl_not.Size = new System.Drawing.Size(29, 18);
            this.lbl_not.TabIndex = 0;
            this.lbl_not.Text = "not";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Not:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sınav:";
            // 
            // lbl_ogrenci
            // 
            this.lbl_ogrenci.AutoSize = true;
            this.lbl_ogrenci.Location = new System.Drawing.Point(46, 28);
            this.lbl_ogrenci.Name = "lbl_ogrenci";
            this.lbl_ogrenci.Size = new System.Drawing.Size(38, 18);
            this.lbl_ogrenci.TabIndex = 0;
            this.lbl_ogrenci.Text = "label";
            // 
            // flp_ogrenci_list_sinav
            // 
            this.flp_ogrenci_list_sinav.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_ogrenci_list_sinav.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flp_ogrenci_list_sinav.Location = new System.Drawing.Point(3, 3);
            this.flp_ogrenci_list_sinav.Name = "flp_ogrenci_list_sinav";
            this.flp_ogrenci_list_sinav.Padding = new System.Windows.Forms.Padding(10);
            this.flp_ogrenci_list_sinav.Size = new System.Drawing.Size(652, 532);
            this.flp_ogrenci_list_sinav.TabIndex = 2;
            // 
            // FrmOgrenciList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenciList";
            this.Text = "FrmOgrenciList";
            this.Load += new System.EventHandler(this.FrmOgrenciList_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_ogrenci.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_sinav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_ogrenci;
        private System.Windows.Forms.TabPage tab_sinav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flp_ogrenci_list;
        private System.Windows.Forms.TextBox txt_sinif;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ogrenci;
        private System.Windows.Forms.FlowLayoutPanel flp_ogrenci_list_sinav;
        private System.Windows.Forms.Label lbl_not;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_exam;
    }
}