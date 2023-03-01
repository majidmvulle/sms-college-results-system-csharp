namespace SMSCollegeResultsSystem._Forms
{
    partial class frmViewResults
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
            this.btnGetGrade = new System.Windows.Forms.Button();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxMarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxModName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tBoxGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStudID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMod = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGetGrade);
            this.panel1.Controls.Add(this.cboDept);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tBoxMarks);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tBoxModName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.tBoxGrade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboStudID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboMod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 381);
            this.panel1.TabIndex = 0;
            // 
            // btnGetGrade
            // 
            this.btnGetGrade.Enabled = false;
            this.btnGetGrade.Location = new System.Drawing.Point(163, 263);
            this.btnGetGrade.Name = "btnGetGrade";
            this.btnGetGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGetGrade.TabIndex = 22;
            this.btnGetGrade.Text = "Get Grade";
            this.btnGetGrade.UseVisualStyleBackColor = true;
            this.btnGetGrade.Click += new System.EventHandler(this.btnGetGrade_Click);
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(113, 67);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(278, 21);
            this.cboDept.TabIndex = 21;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(113, 40);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(278, 21);
            this.cboSchool.TabIndex = 20;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "School:";
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(113, 232);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(278, 20);
            this.tBoxLName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Last Name:";
            // 
            // tBoxMarks
            // 
            this.tBoxMarks.Enabled = false;
            this.tBoxMarks.Location = new System.Drawing.Point(113, 267);
            this.tBoxMarks.Name = "tBoxMarks";
            this.tBoxMarks.Size = new System.Drawing.Size(33, 20);
            this.tBoxMarks.TabIndex = 15;
            this.tBoxMarks.TextChanged += new System.EventHandler(this.tBoxMarks_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Marks Scored:";
            // 
            // tBoxModName
            // 
            this.tBoxModName.Enabled = false;
            this.tBoxModName.Location = new System.Drawing.Point(113, 131);
            this.tBoxModName.Name = "tBoxModName";
            this.tBoxModName.Size = new System.Drawing.Size(282, 20);
            this.tBoxModName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Module Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "First Name:";
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(113, 206);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(280, 20);
            this.tBoxFName.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(146, 344);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(88, 23);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tBoxGrade
            // 
            this.tBoxGrade.Enabled = false;
            this.tBoxGrade.Location = new System.Drawing.Point(113, 293);
            this.tBoxGrade.Name = "tBoxGrade";
            this.tBoxGrade.Size = new System.Drawing.Size(31, 20);
            this.tBoxGrade.TabIndex = 6;
            this.tBoxGrade.TextChanged += new System.EventHandler(this.tBoxGrade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade:";
            // 
            // cboStudID
            // 
            this.cboStudID.Enabled = false;
            this.cboStudID.FormattingEnabled = true;
            this.cboStudID.Location = new System.Drawing.Point(113, 179);
            this.cboStudID.Name = "cboStudID";
            this.cboStudID.Size = new System.Drawing.Size(121, 21);
            this.cboStudID.TabIndex = 4;
            this.cboStudID.SelectedIndexChanged += new System.EventHandler(this.cboStudID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Module Code:";
            // 
            // cboMod
            // 
            this.cboMod.Enabled = false;
            this.cboMod.FormattingEnabled = true;
            this.cboMod.Location = new System.Drawing.Point(113, 104);
            this.cboMod.Name = "cboMod";
            this.cboMod.Size = new System.Drawing.Size(121, 21);
            this.cboMod.TabIndex = 1;
            this.cboMod.SelectedIndexChanged += new System.EventHandler(this.cboMod_SelectedIndexChanged);
            // 
            // frmViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 381);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmViewResults";
            this.Text = "Results : Viewing/Editing";
            this.Load += new System.EventHandler(this.frmViewResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboStudID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMod;
        private System.Windows.Forms.TextBox tBoxGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox tBoxMarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxModName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetGrade;
    }
}