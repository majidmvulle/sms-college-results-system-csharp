namespace SMSCollegeResultsSystem._Forms
{
    partial class frmDeleteResults
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
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxMarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxModName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteResults = new System.Windows.Forms.Button();
            this.cboStud = new System.Windows.Forms.ComboBox();
            this.cboMod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboDept);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tBoxMarks);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBoxModName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxGrade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDeleteResults);
            this.panel1.Controls.Add(this.cboStud);
            this.panel1.Controls.Add(this.cboMod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 353);
            this.panel1.TabIndex = 0;
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(140, 48);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(234, 21);
            this.cboDept.TabIndex = 19;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Department:";
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(140, 21);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(234, 21);
            this.cboSchool.TabIndex = 17;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(140, 196);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(234, 20);
            this.tBoxLName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "School:";
            // 
            // tBoxMarks
            // 
            this.tBoxMarks.Enabled = false;
            this.tBoxMarks.Location = new System.Drawing.Point(140, 234);
            this.tBoxMarks.Name = "tBoxMarks";
            this.tBoxMarks.Size = new System.Drawing.Size(29, 20);
            this.tBoxMarks.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marks Scored:";
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(140, 170);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(234, 20);
            this.tBoxFName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name:";
            // 
            // tBoxModName
            // 
            this.tBoxModName.Enabled = false;
            this.tBoxModName.Location = new System.Drawing.Point(140, 105);
            this.tBoxModName.Name = "tBoxModName";
            this.tBoxModName.Size = new System.Drawing.Size(204, 20);
            this.tBoxModName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Module Name:";
            // 
            // tBoxGrade
            // 
            this.tBoxGrade.Enabled = false;
            this.tBoxGrade.Location = new System.Drawing.Point(140, 260);
            this.tBoxGrade.Name = "tBoxGrade";
            this.tBoxGrade.Size = new System.Drawing.Size(29, 20);
            this.tBoxGrade.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grade:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteResults
            // 
            this.btnDeleteResults.Enabled = false;
            this.btnDeleteResults.Location = new System.Drawing.Point(156, 316);
            this.btnDeleteResults.Name = "btnDeleteResults";
            this.btnDeleteResults.Size = new System.Drawing.Size(84, 23);
            this.btnDeleteResults.TabIndex = 4;
            this.btnDeleteResults.Text = "Delete Results";
            this.btnDeleteResults.UseVisualStyleBackColor = true;
            this.btnDeleteResults.Click += new System.EventHandler(this.btnDeleteResults_Click);
            // 
            // cboStud
            // 
            this.cboStud.Enabled = false;
            this.cboStud.FormattingEnabled = true;
            this.cboStud.Location = new System.Drawing.Point(140, 143);
            this.cboStud.Name = "cboStud";
            this.cboStud.Size = new System.Drawing.Size(143, 21);
            this.cboStud.TabIndex = 3;
            this.cboStud.SelectedIndexChanged += new System.EventHandler(this.cboStud_SelectedIndexChanged);
            // 
            // cboMod
            // 
            this.cboMod.Enabled = false;
            this.cboMod.FormattingEnabled = true;
            this.cboMod.Location = new System.Drawing.Point(140, 78);
            this.cboMod.Name = "cboMod";
            this.cboMod.Size = new System.Drawing.Size(143, 21);
            this.cboMod.TabIndex = 2;
            this.cboMod.SelectedIndexChanged += new System.EventHandler(this.cboMod_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Code:";
            // 
            // frmDeleteResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 353);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDeleteResults";
            this.Text = "Results : Deleting";
            this.Load += new System.EventHandler(this.frmDeleteResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBoxGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteResults;
        private System.Windows.Forms.ComboBox cboStud;
        private System.Windows.Forms.ComboBox cboMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxModName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.Label label8;
    }
}