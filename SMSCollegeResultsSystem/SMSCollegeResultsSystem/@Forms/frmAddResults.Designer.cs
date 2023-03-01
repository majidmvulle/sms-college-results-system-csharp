namespace SMSCollegeResultsSystem._Forms
{
    partial class frmAddResults
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
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxModName = new System.Windows.Forms.TextBox();
            this.tBoxMarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddResults = new System.Windows.Forms.Button();
            this.tBoxGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStudID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.btnGetGrade = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGetGrade);
            this.panel1.Controls.Add(this.cboDept);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tBoxModName);
            this.panel1.Controls.Add(this.tBoxMarks);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddResults);
            this.panel1.Controls.Add(this.tBoxGrade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboStudID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblModule);
            this.panel1.Controls.Add(this.cboModule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 364);
            this.panel1.TabIndex = 0;
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(139, 53);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(218, 21);
            this.cboDept.TabIndex = 20;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(139, 26);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(218, 21);
            this.cboSchool.TabIndex = 19;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Department:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "School:";
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(139, 214);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(218, 20);
            this.tBoxLName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last Name:";
            // 
            // tBoxModName
            // 
            this.tBoxModName.Enabled = false;
            this.tBoxModName.Location = new System.Drawing.Point(139, 117);
            this.tBoxModName.Name = "tBoxModName";
            this.tBoxModName.Size = new System.Drawing.Size(218, 20);
            this.tBoxModName.TabIndex = 14;
            // 
            // tBoxMarks
            // 
            this.tBoxMarks.Enabled = false;
            this.tBoxMarks.Location = new System.Drawing.Point(139, 255);
            this.tBoxMarks.Name = "tBoxMarks";
            this.tBoxMarks.Size = new System.Drawing.Size(28, 20);
            this.tBoxMarks.TabIndex = 13;
            this.tBoxMarks.TextChanged += new System.EventHandler(this.tBoxMarks_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Marks Scored:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Module Name:";
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(139, 188);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(218, 20);
            this.tBoxFName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddResults
            // 
            this.btnAddResults.Enabled = false;
            this.btnAddResults.Location = new System.Drawing.Point(151, 327);
            this.btnAddResults.Name = "btnAddResults";
            this.btnAddResults.Size = new System.Drawing.Size(75, 23);
            this.btnAddResults.TabIndex = 6;
            this.btnAddResults.Text = "Add Results";
            this.btnAddResults.UseVisualStyleBackColor = true;
            this.btnAddResults.Click += new System.EventHandler(this.btnAddResults_Click);
            // 
            // tBoxGrade
            // 
            this.tBoxGrade.Enabled = false;
            this.tBoxGrade.Location = new System.Drawing.Point(139, 281);
            this.tBoxGrade.Name = "tBoxGrade";
            this.tBoxGrade.Size = new System.Drawing.Size(28, 20);
            this.tBoxGrade.TabIndex = 5;
            this.tBoxGrade.TextChanged += new System.EventHandler(this.tBoxGrade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grade:";
            // 
            // cboStudID
            // 
            this.cboStudID.Enabled = false;
            this.cboStudID.FormattingEnabled = true;
            this.cboStudID.Location = new System.Drawing.Point(139, 161);
            this.cboStudID.Name = "cboStudID";
            this.cboStudID.Size = new System.Drawing.Size(136, 21);
            this.cboStudID.TabIndex = 3;
            this.cboStudID.SelectedIndexChanged += new System.EventHandler(this.cboStudID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID:";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(60, 98);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(73, 13);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "Module Code:";
            // 
            // cboModule
            // 
            this.cboModule.Enabled = false;
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Location = new System.Drawing.Point(139, 90);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(136, 21);
            this.cboModule.TabIndex = 0;
            this.cboModule.SelectedIndexChanged += new System.EventHandler(this.cboModule_SelectedIndexChanged);
            // 
            // btnGetGrade
            // 
            this.btnGetGrade.Enabled = false;
            this.btnGetGrade.Location = new System.Drawing.Point(173, 253);
            this.btnGetGrade.Name = "btnGetGrade";
            this.btnGetGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGetGrade.TabIndex = 21;
            this.btnGetGrade.Text = "Get Grade";
            this.btnGetGrade.UseVisualStyleBackColor = true;
            this.btnGetGrade.Click += new System.EventHandler(this.btnGetGrade_Click);
            // 
            // frmAddResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 364);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAddResults";
            this.Text = "Results : Adding";
            this.Load += new System.EventHandler(this.frmAddResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddResults;
        private System.Windows.Forms.TextBox tBoxGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStudID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.TextBox tBoxModName;
        private System.Windows.Forms.TextBox tBoxMarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetGrade;
    }
}