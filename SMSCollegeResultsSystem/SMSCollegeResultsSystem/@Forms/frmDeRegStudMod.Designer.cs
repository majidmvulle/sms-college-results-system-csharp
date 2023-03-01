namespace SMSCollegeResultsSystem._Forms
{
    partial class frmDeRegStudMod
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
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeRegStudMod = new System.Windows.Forms.Button();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.tBoxModName = new System.Windows.Forms.TextBox();
            this.cboStudID = new System.Windows.Forms.ComboBox();
            this.cboModCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboDept);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDeRegStudMod);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.tBoxModName);
            this.panel1.Controls.Add(this.cboStudID);
            this.panel1.Controls.Add(this.cboModCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 359);
            this.panel1.TabIndex = 0;
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(110, 56);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(237, 21);
            this.cboDept.TabIndex = 16;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(109, 29);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(238, 21);
            this.cboSchool.TabIndex = 15;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(109, 266);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(238, 20);
            this.tBoxLName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "School:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeRegStudMod
            // 
            this.btnDeRegStudMod.Enabled = false;
            this.btnDeRegStudMod.Location = new System.Drawing.Point(117, 322);
            this.btnDeRegStudMod.Name = "btnDeRegStudMod";
            this.btnDeRegStudMod.Size = new System.Drawing.Size(111, 23);
            this.btnDeRegStudMod.TabIndex = 9;
            this.btnDeRegStudMod.Text = "De-Register Student";
            this.btnDeRegStudMod.UseVisualStyleBackColor = true;
            this.btnDeRegStudMod.Click += new System.EventHandler(this.btnDeRegStudMod_Click);
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(109, 240);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(238, 20);
            this.tBoxFName.TabIndex = 8;
            // 
            // tBoxModName
            // 
            this.tBoxModName.Enabled = false;
            this.tBoxModName.Location = new System.Drawing.Point(110, 129);
            this.tBoxModName.Name = "tBoxModName";
            this.tBoxModName.Size = new System.Drawing.Size(237, 20);
            this.tBoxModName.TabIndex = 7;
            // 
            // cboStudID
            // 
            this.cboStudID.Enabled = false;
            this.cboStudID.FormattingEnabled = true;
            this.cboStudID.Location = new System.Drawing.Point(109, 213);
            this.cboStudID.Name = "cboStudID";
            this.cboStudID.Size = new System.Drawing.Size(161, 21);
            this.cboStudID.TabIndex = 6;
            this.cboStudID.SelectedIndexChanged += new System.EventHandler(this.cboStudID_SelectedIndexChanged);
            // 
            // cboModCode
            // 
            this.cboModCode.Enabled = false;
            this.cboModCode.FormattingEnabled = true;
            this.cboModCode.Location = new System.Drawing.Point(110, 102);
            this.cboModCode.Name = "cboModCode";
            this.cboModCode.Size = new System.Drawing.Size(160, 21);
            this.cboModCode.TabIndex = 5;
            this.cboModCode.SelectedIndexChanged += new System.EventHandler(this.cboModCode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "De-Register Student from Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Code:";
            // 
            // frmDeRegStudMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 359);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDeRegStudMod";
            this.Text = "DeRegister Student from Module";
            this.Load += new System.EventHandler(this.frmDeRegStudMod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeRegStudMod;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.TextBox tBoxModName;
        private System.Windows.Forms.ComboBox cboStudID;
        private System.Windows.Forms.ComboBox cboModCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.Label label8;
    }
}