namespace _005_example
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            cbGender = new ComboBox();
            txtHomework = new TextBox();
            txtMidterm = new TextBox();
            txtFinal = new TextBox();
            btnRecord = new Button();
            panel2 = new Panel();
            label7 = new Label();
            txtShowList = new TextBox();
            panel3 = new Panel();
            label11 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            lblCountFail = new Label();
            lblCountFemale = new Label();
            lblCountAll = new Label();
            label9 = new Label();
            label8 = new Label();
            txtShowResult = new TextBox();
            btnShowListName = new Button();
            btnHideListName = new Button();
            btnShowResult = new Button();
            btnHideResult = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(25, 11);
            label1.Name = "label1";
            label1.Size = new Size(210, 36);
            label1.TabIndex = 0;
            label1.Text = "Record Student Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(68, 36);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 73);
            label3.Name = "label3";
            label3.Size = new Size(80, 36);
            label3.TabIndex = 0;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 73);
            label4.Name = "label4";
            label4.Size = new Size(109, 36);
            label4.TabIndex = 0;
            label4.Text = "Homework";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 73);
            label5.Name = "label5";
            label5.Size = new Size(94, 36);
            label5.TabIndex = 0;
            label5.Text = "Mid-term";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(696, 73);
            label6.Name = "label6";
            label6.Size = new Size(58, 36);
            label6.TabIndex = 0;
            label6.Text = "Final";
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 44);
            txtName.TabIndex = 1;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(179, 110);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 44);
            cbGender.TabIndex = 2;
            // 
            // txtHomework
            // 
            txtHomework.Location = new Point(364, 110);
            txtHomework.Name = "txtHomework";
            txtHomework.Size = new Size(153, 44);
            txtHomework.TabIndex = 3;
            // 
            // txtMidterm
            // 
            txtMidterm.Location = new Point(530, 110);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(153, 44);
            txtMidterm.TabIndex = 4;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(696, 110);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(153, 44);
            txtFinal.TabIndex = 5;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.SteelBlue;
            btnRecord.Cursor = Cursors.Hand;
            btnRecord.FlatStyle = FlatStyle.Popup;
            btnRecord.ForeColor = Color.Transparent;
            btnRecord.Location = new Point(876, 110);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(94, 44);
            btnRecord.TabIndex = 6;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtShowList);
            panel2.Location = new Point(12, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 324);
            panel2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(4, 1);
            label7.Name = "label7";
            label7.Size = new Size(104, 36);
            label7.TabIndex = 0;
            label7.Text = "List Name";
            // 
            // txtShowList
            // 
            txtShowList.BackColor = Color.WhiteSmoke;
            txtShowList.Location = new Point(3, 40);
            txtShowList.Multiline = true;
            txtShowList.Name = "txtShowList";
            txtShowList.ReadOnly = true;
            txtShowList.Size = new Size(217, 231);
            txtShowList.TabIndex = 1;
            txtShowList.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblCountFail);
            panel3.Controls.Add(lblCountFemale);
            panel3.Controls.Add(lblCountAll);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtShowResult);
            panel3.Location = new Point(254, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(716, 324);
            panel3.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(501, 274);
            label11.Name = "label11";
            label11.Size = new Size(123, 36);
            label11.TabIndex = 0;
            label11.Text = "Count Fail : ";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.WhiteSmoke;
            textBox7.Location = new Point(-242, 40);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(217, 231);
            textBox7.TabIndex = 1;
            textBox7.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(235, 274);
            label10.Name = "label10";
            label10.Size = new Size(158, 36);
            label10.TabIndex = 0;
            label10.Text = "Count Female : ";
            // 
            // lblCountFail
            // 
            lblCountFail.AutoSize = true;
            lblCountFail.ForeColor = Color.Transparent;
            lblCountFail.Location = new Point(622, 274);
            lblCountFail.Name = "lblCountFail";
            lblCountFail.Size = new Size(45, 36);
            lblCountFail.TabIndex = 0;
            lblCountFail.Text = "??";
            // 
            // lblCountFemale
            // 
            lblCountFemale.AutoSize = true;
            lblCountFemale.ForeColor = Color.Transparent;
            lblCountFemale.Location = new Point(386, 274);
            lblCountFemale.Name = "lblCountFemale";
            lblCountFemale.Size = new Size(45, 36);
            lblCountFemale.TabIndex = 0;
            lblCountFemale.Text = "??";
            // 
            // lblCountAll
            // 
            lblCountAll.AutoSize = true;
            lblCountAll.ForeColor = Color.Transparent;
            lblCountAll.Location = new Point(110, 274);
            lblCountAll.Name = "lblCountAll";
            lblCountAll.Size = new Size(45, 36);
            lblCountAll.TabIndex = 0;
            lblCountAll.Text = "??";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(3, 274);
            label9.Name = "label9";
            label9.Size = new Size(112, 36);
            label9.TabIndex = 0;
            label9.Text = "Count All : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(3, 1);
            label8.Name = "label8";
            label8.Size = new Size(215, 36);
            label8.TabIndex = 0;
            label8.Text = "Students' Exam Result";
            // 
            // txtShowResult
            // 
            txtShowResult.BackColor = Color.WhiteSmoke;
            txtShowResult.Location = new Point(3, 40);
            txtShowResult.Multiline = true;
            txtShowResult.Name = "txtShowResult";
            txtShowResult.ReadOnly = true;
            txtShowResult.Size = new Size(710, 231);
            txtShowResult.TabIndex = 1;
            txtShowResult.TabStop = false;
            // 
            // btnShowListName
            // 
            btnShowListName.Location = new Point(12, 170);
            btnShowListName.Name = "btnShowListName";
            btnShowListName.Size = new Size(94, 41);
            btnShowListName.TabIndex = 7;
            btnShowListName.Text = "Show";
            btnShowListName.UseVisualStyleBackColor = true;
            btnShowListName.Click += btnShowListName_Click;
            // 
            // btnHideListName
            // 
            btnHideListName.Location = new Point(141, 170);
            btnHideListName.Name = "btnHideListName";
            btnHideListName.Size = new Size(94, 41);
            btnHideListName.TabIndex = 8;
            btnHideListName.Text = "Hide";
            btnHideListName.UseVisualStyleBackColor = true;
            btnHideListName.Click += btnHideListName_Click;
            // 
            // btnShowResult
            // 
            btnShowResult.Location = new Point(755, 170);
            btnShowResult.Name = "btnShowResult";
            btnShowResult.Size = new Size(94, 41);
            btnShowResult.TabIndex = 9;
            btnShowResult.Text = "Show";
            btnShowResult.UseVisualStyleBackColor = true;
            btnShowResult.Click += btnShowResult_Click;
            // 
            // btnHideResult
            // 
            btnHideResult.Location = new Point(876, 170);
            btnHideResult.Name = "btnHideResult";
            btnHideResult.Size = new Size(94, 41);
            btnHideResult.TabIndex = 10;
            btnHideResult.Text = "Hide";
            btnHideResult.UseVisualStyleBackColor = true;
            btnHideResult.Click += btnHideResult_Click;
            // 
            // MainForm
            // 
            AcceptButton = btnRecord;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(982, 553);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnHideResult);
            Controls.Add(btnShowResult);
            Controls.Add(btnHideListName);
            Controls.Add(btnShowListName);
            Controls.Add(btnRecord);
            Controls.Add(cbGender);
            Controls.Add(txtFinal);
            Controls.Add(txtMidterm);
            Controls.Add(txtHomework);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private ComboBox cbGender;
        private TextBox txtHomework;
        private TextBox txtMidterm;
        private TextBox txtFinal;
        private Button btnRecord;
        private Panel panel2;
        private Label label7;
        private TextBox txtShowList;
        private Panel panel3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtShowResult;
        private Button btnShowListName;
        private Button btnHideListName;
        private Button btnShowResult;
        private Button btnHideResult;
        private TextBox textBox7;
        private Label lblCountFail;
        private Label lblCountFemale;
        private Label lblCountAll;
    }
}