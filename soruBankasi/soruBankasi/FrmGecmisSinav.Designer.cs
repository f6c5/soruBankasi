namespace soruBankasi
{
    partial class FrmGecmisSinav
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_soru = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_exam = new System.Windows.Forms.ComboBox();
            this.lbl_not = new System.Windows.Forms.Label();
            this.lbl_soru_no = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_e = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_e);
            this.panel2.Controls.Add(this.lbl_d);
            this.panel2.Controls.Add(this.lbl_c);
            this.panel2.Controls.Add(this.lbl_b);
            this.panel2.Controls.Add(this.lbl_a);
            this.panel2.Controls.Add(this.lbl_soru);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 538);
            this.panel2.TabIndex = 12;
            // 
            // lbl_soru
            // 
            this.lbl_soru.AutoSize = true;
            this.lbl_soru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_soru.Location = new System.Drawing.Point(38, 32);
            this.lbl_soru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soru.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_soru.Name = "lbl_soru";
            this.lbl_soru.Size = new System.Drawing.Size(55, 24);
            this.lbl_soru.TabIndex = 24;
            this.lbl_soru.Text = "Soru:";
            this.lbl_soru.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_exam);
            this.panel3.Controls.Add(this.lbl_not);
            this.panel3.Controls.Add(this.lbl_soru_no);
            this.panel3.Controls.Add(this.btn_prev);
            this.panel3.Controls.Add(this.btn_next);
            this.panel3.Controls.Add(this.btn_browse);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 62);
            this.panel3.TabIndex = 13;
            // 
            // cb_exam
            // 
            this.cb_exam.FormattingEnabled = true;
            this.cb_exam.Location = new System.Drawing.Point(137, 16);
            this.cb_exam.Name = "cb_exam";
            this.cb_exam.Size = new System.Drawing.Size(233, 32);
            this.cb_exam.TabIndex = 6;
            this.cb_exam.Text = "Sınav Seç";
            this.cb_exam.SelectedIndexChanged += new System.EventHandler(this.cb_exam_SelectedIndexChanged);
            // 
            // lbl_not
            // 
            this.lbl_not.AutoSize = true;
            this.lbl_not.Location = new System.Drawing.Point(425, 19);
            this.lbl_not.Name = "lbl_not";
            this.lbl_not.Size = new System.Drawing.Size(39, 24);
            this.lbl_not.TabIndex = 5;
            this.lbl_not.Text = "Not";
            this.lbl_not.Visible = false;
            // 
            // lbl_soru_no
            // 
            this.lbl_soru_no.AutoSize = true;
            this.lbl_soru_no.Location = new System.Drawing.Point(48, 19);
            this.lbl_soru_no.Name = "lbl_soru_no";
            this.lbl_soru_no.Size = new System.Drawing.Size(35, 24);
            this.lbl_soru_no.TabIndex = 5;
            this.lbl_soru_no.Text = "0/0";
            this.lbl_soru_no.Visible = false;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(605, 12);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(102, 39);
            this.btn_prev.TabIndex = 3;
            this.btn_prev.Text = "Önceki";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Visible = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(713, 12);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(102, 39);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Sonraki";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(821, 12);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(167, 39);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "İncele";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_a.Location = new System.Drawing.Point(38, 138);
            this.lbl_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_a.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(23, 24);
            this.lbl_a.TabIndex = 24;
            this.lbl_a.Text = "A";
            this.lbl_a.Visible = false;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_b.Location = new System.Drawing.Point(38, 211);
            this.lbl_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_b.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(22, 24);
            this.lbl_b.TabIndex = 24;
            this.lbl_b.Text = "B";
            this.lbl_b.Visible = false;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_c.Location = new System.Drawing.Point(38, 284);
            this.lbl_c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_c.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(23, 24);
            this.lbl_c.TabIndex = 24;
            this.lbl_c.Text = "C";
            this.lbl_c.Visible = false;
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_d.Location = new System.Drawing.Point(38, 357);
            this.lbl_d.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_d.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(23, 24);
            this.lbl_d.TabIndex = 24;
            this.lbl_d.Text = "D";
            this.lbl_d.Visible = false;
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_e.Location = new System.Drawing.Point(38, 430);
            this.lbl_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_e.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(23, 24);
            this.lbl_e.TabIndex = 24;
            this.lbl_e.Text = "E";
            this.lbl_e.Visible = false;
            // 
            // FrmGecmisSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmGecmisSinav";
            this.Text = "FrmGecmisSinav";
            this.Load += new System.EventHandler(this.FrmGecmisSinav_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_soru;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_exam;
        private System.Windows.Forms.Label lbl_not;
        private System.Windows.Forms.Label lbl_soru_no;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
    }
}