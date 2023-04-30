namespace soruBankasi
{
    partial class FrmSinavList
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
            this.cb_exam = new System.Windows.Forms.ComboBox();
            this.cb_question = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_question = new System.Windows.Forms.Button();
            this.btn_add_exam = new System.Windows.Forms.Button();
            this.pnl_question_data = new System.Windows.Forms.Panel();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_answer = new System.Windows.Forms.ComboBox();
            this.pnl_add_exam = new System.Windows.Forms.Panel();
            this.btn_create_exam = new System.Windows.Forms.Button();
            this.dtp_new_exam_date = new System.Windows.Forms.DateTimePicker();
            this.txt_new_exam_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_del_exam = new System.Windows.Forms.Button();
            this.pnl_question_data.SuspendLayout();
            this.pnl_add_exam.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_exam
            // 
            this.cb_exam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_exam.FormattingEnabled = true;
            this.cb_exam.Location = new System.Drawing.Point(43, 17);
            this.cb_exam.Margin = new System.Windows.Forms.Padding(4);
            this.cb_exam.Name = "cb_exam";
            this.cb_exam.Size = new System.Drawing.Size(199, 26);
            this.cb_exam.TabIndex = 0;
            this.cb_exam.Text = "Sınav Seç";
            this.cb_exam.SelectedIndexChanged += new System.EventHandler(this.cb_exam_SelectedIndexChanged);
            // 
            // cb_question
            // 
            this.cb_question.Enabled = false;
            this.cb_question.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_question.FormattingEnabled = true;
            this.cb_question.Location = new System.Drawing.Point(250, 17);
            this.cb_question.Margin = new System.Windows.Forms.Padding(4);
            this.cb_question.Name = "cb_question";
            this.cb_question.Size = new System.Drawing.Size(199, 26);
            this.cb_question.TabIndex = 1;
            this.cb_question.Text = "Soru Seç";
            this.cb_question.SelectedIndexChanged += new System.EventHandler(this.cb_question_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(22, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 3);
            this.panel1.TabIndex = 3;
            // 
            // btn_add_question
            // 
            this.btn_add_question.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_question.Location = new System.Drawing.Point(834, 13);
            this.btn_add_question.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_question.Name = "btn_add_question";
            this.btn_add_question.Size = new System.Drawing.Size(153, 32);
            this.btn_add_question.TabIndex = 4;
            this.btn_add_question.Text = "Soru Ekle";
            this.btn_add_question.UseVisualStyleBackColor = true;
            this.btn_add_question.Click += new System.EventHandler(this.btn_add_question_Click);
            // 
            // btn_add_exam
            // 
            this.btn_add_exam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_exam.Location = new System.Drawing.Point(673, 13);
            this.btn_add_exam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_exam.Name = "btn_add_exam";
            this.btn_add_exam.Size = new System.Drawing.Size(153, 32);
            this.btn_add_exam.TabIndex = 4;
            this.btn_add_exam.Text = "Sınav Ekle";
            this.btn_add_exam.UseVisualStyleBackColor = true;
            this.btn_add_exam.Click += new System.EventHandler(this.btn_add_exam_Click);
            // 
            // pnl_question_data
            // 
            this.pnl_question_data.Controls.Add(this.txt_e);
            this.pnl_question_data.Controls.Add(this.txt_d);
            this.pnl_question_data.Controls.Add(this.txt_c);
            this.pnl_question_data.Controls.Add(this.txt_b);
            this.pnl_question_data.Controls.Add(this.txt_a);
            this.pnl_question_data.Controls.Add(this.txt_question);
            this.pnl_question_data.Controls.Add(this.btn_del);
            this.pnl_question_data.Controls.Add(this.btn_edit);
            this.pnl_question_data.Controls.Add(this.label7);
            this.pnl_question_data.Controls.Add(this.label6);
            this.pnl_question_data.Controls.Add(this.label5);
            this.pnl_question_data.Controls.Add(this.label4);
            this.pnl_question_data.Controls.Add(this.label3);
            this.pnl_question_data.Controls.Add(this.label2);
            this.pnl_question_data.Controls.Add(this.label1);
            this.pnl_question_data.Controls.Add(this.cb_answer);
            this.pnl_question_data.Location = new System.Drawing.Point(0, 69);
            this.pnl_question_data.Name = "pnl_question_data";
            this.pnl_question_data.Size = new System.Drawing.Size(1000, 530);
            this.pnl_question_data.TabIndex = 5;
            this.pnl_question_data.Visible = false;
            // 
            // txt_e
            // 
            this.txt_e.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_e.Location = new System.Drawing.Point(82, 420);
            this.txt_e.Multiline = true;
            this.txt_e.Name = "txt_e";
            this.txt_e.ReadOnly = true;
            this.txt_e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_e.Size = new System.Drawing.Size(833, 40);
            this.txt_e.TabIndex = 26;
            // 
            // txt_d
            // 
            this.txt_d.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_d.Location = new System.Drawing.Point(82, 362);
            this.txt_d.Multiline = true;
            this.txt_d.Name = "txt_d";
            this.txt_d.ReadOnly = true;
            this.txt_d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_d.Size = new System.Drawing.Size(833, 40);
            this.txt_d.TabIndex = 25;
            // 
            // txt_c
            // 
            this.txt_c.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_c.Location = new System.Drawing.Point(82, 304);
            this.txt_c.Multiline = true;
            this.txt_c.Name = "txt_c";
            this.txt_c.ReadOnly = true;
            this.txt_c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_c.Size = new System.Drawing.Size(833, 40);
            this.txt_c.TabIndex = 24;
            // 
            // txt_b
            // 
            this.txt_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_b.Location = new System.Drawing.Point(82, 246);
            this.txt_b.Multiline = true;
            this.txt_b.Name = "txt_b";
            this.txt_b.ReadOnly = true;
            this.txt_b.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_b.Size = new System.Drawing.Size(833, 40);
            this.txt_b.TabIndex = 23;
            // 
            // txt_a
            // 
            this.txt_a.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_a.Location = new System.Drawing.Point(82, 188);
            this.txt_a.Multiline = true;
            this.txt_a.Name = "txt_a";
            this.txt_a.ReadOnly = true;
            this.txt_a.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_a.Size = new System.Drawing.Size(833, 40);
            this.txt_a.TabIndex = 22;
            // 
            // txt_question
            // 
            this.txt_question.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_question.Location = new System.Drawing.Point(82, 17);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_question.Size = new System.Drawing.Size(833, 153);
            this.txt_question.TabIndex = 21;
            // 
            // btn_del
            // 
            this.btn_del.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_del.Location = new System.Drawing.Point(826, 482);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(152, 32);
            this.btn_del.TabIndex = 19;
            this.btn_del.Text = "Sil";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.Location = new System.Drawing.Point(666, 482);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(152, 32);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Düzenle";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 489);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cevap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(48, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(48, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "D-)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(48, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "C-)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "B-)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "A-)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Soru:";
            // 
            // cb_answer
            // 
            this.cb_answer.Enabled = false;
            this.cb_answer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_answer.FormattingEnabled = true;
            this.cb_answer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cb_answer.Location = new System.Drawing.Point(85, 486);
            this.cb_answer.Margin = new System.Windows.Forms.Padding(4);
            this.cb_answer.Name = "cb_answer";
            this.cb_answer.Size = new System.Drawing.Size(55, 26);
            this.cb_answer.TabIndex = 11;
            this.cb_answer.Text = "Seç";
            // 
            // pnl_add_exam
            // 
            this.pnl_add_exam.Controls.Add(this.btn_create_exam);
            this.pnl_add_exam.Controls.Add(this.dtp_new_exam_date);
            this.pnl_add_exam.Controls.Add(this.txt_new_exam_name);
            this.pnl_add_exam.Controls.Add(this.label9);
            this.pnl_add_exam.Controls.Add(this.label8);
            this.pnl_add_exam.Location = new System.Drawing.Point(0, 69);
            this.pnl_add_exam.Name = "pnl_add_exam";
            this.pnl_add_exam.Size = new System.Drawing.Size(1000, 530);
            this.pnl_add_exam.TabIndex = 6;
            this.pnl_add_exam.Visible = false;
            // 
            // btn_create_exam
            // 
            this.btn_create_exam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_create_exam.Location = new System.Drawing.Point(437, 172);
            this.btn_create_exam.Name = "btn_create_exam";
            this.btn_create_exam.Size = new System.Drawing.Size(226, 35);
            this.btn_create_exam.TabIndex = 3;
            this.btn_create_exam.Text = "Oluştur";
            this.btn_create_exam.UseVisualStyleBackColor = true;
            this.btn_create_exam.Click += new System.EventHandler(this.btn_create_exam_Click);
            // 
            // dtp_new_exam_date
            // 
            this.dtp_new_exam_date.Location = new System.Drawing.Point(437, 121);
            this.dtp_new_exam_date.Name = "dtp_new_exam_date";
            this.dtp_new_exam_date.Size = new System.Drawing.Size(226, 24);
            this.dtp_new_exam_date.TabIndex = 2;
            // 
            // txt_new_exam_name
            // 
            this.txt_new_exam_name.Location = new System.Drawing.Point(437, 70);
            this.txt_new_exam_name.Name = "txt_new_exam_name";
            this.txt_new_exam_name.Size = new System.Drawing.Size(226, 24);
            this.txt_new_exam_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(337, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sınav Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(353, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sınav Adı:";
            // 
            // btn_del_exam
            // 
            this.btn_del_exam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_del_exam.Location = new System.Drawing.Point(512, 13);
            this.btn_del_exam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del_exam.Name = "btn_del_exam";
            this.btn_del_exam.Size = new System.Drawing.Size(153, 32);
            this.btn_del_exam.TabIndex = 4;
            this.btn_del_exam.Text = "Sınavı Sil";
            this.btn_del_exam.UseVisualStyleBackColor = true;
            this.btn_del_exam.Click += new System.EventHandler(this.btn_del_exam_Click);
            // 
            // FrmSinavList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btn_del_exam);
            this.Controls.Add(this.btn_add_exam);
            this.Controls.Add(this.btn_add_question);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_question);
            this.Controls.Add(this.cb_exam);
            this.Controls.Add(this.pnl_question_data);
            this.Controls.Add(this.pnl_add_exam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSinavList";
            this.Text = "FrmSinavList";
            this.Load += new System.EventHandler(this.FrmSinavList_Load);
            this.pnl_question_data.ResumeLayout(false);
            this.pnl_question_data.PerformLayout();
            this.pnl_add_exam.ResumeLayout(false);
            this.pnl_add_exam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_exam;
        private System.Windows.Forms.ComboBox cb_question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_question;
        private System.Windows.Forms.Button btn_add_exam;
        private System.Windows.Forms.Panel pnl_question_data;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_answer;
        private System.Windows.Forms.Panel pnl_add_exam;
        private System.Windows.Forms.Button btn_create_exam;
        private System.Windows.Forms.DateTimePicker dtp_new_exam_date;
        private System.Windows.Forms.TextBox txt_new_exam_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_del_exam;
    }
}