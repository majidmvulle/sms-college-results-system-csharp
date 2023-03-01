namespace SMSCollegeResultsSystem._Forms
{
    partial class frmViewStudent
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
            this.tBoxGender = new System.Windows.Forms.TextBox();
            this.tBoxICPsp = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStudID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tBoxGender);
            this.panel1.Controls.Add(this.tBoxICPsp);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.tBoxPhone);
            this.panel1.Controls.Add(this.tBoxEmail);
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboStudID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 279);
            this.panel1.TabIndex = 0;
            // 
            // tBoxGender
            // 
            this.tBoxGender.Enabled = false;
            this.tBoxGender.Location = new System.Drawing.Point(102, 136);
            this.tBoxGender.Name = "tBoxGender";
            this.tBoxGender.Size = new System.Drawing.Size(80, 20);
            this.tBoxGender.TabIndex = 18;
            this.tBoxGender.TextChanged += new System.EventHandler(this.tBoxGender_TextChanged);
            // 
            // tBoxICPsp
            // 
            this.tBoxICPsp.Enabled = false;
            this.tBoxICPsp.Location = new System.Drawing.Point(103, 56);
            this.tBoxICPsp.Name = "tBoxICPsp";
            this.tBoxICPsp.Size = new System.Drawing.Size(250, 20);
            this.tBoxICPsp.TabIndex = 17;
            this.tBoxICPsp.TextChanged += new System.EventHandler(this.tBoxICPsp_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(146, 242);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(89, 23);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Enabled = false;
            this.tBoxPhone.Location = new System.Drawing.Point(101, 162);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(206, 20);
            this.tBoxPhone.TabIndex = 13;
            this.tBoxPhone.TextChanged += new System.EventHandler(this.tBoxPhone_TextChanged);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Enabled = false;
            this.tBoxEmail.Location = new System.Drawing.Point(101, 188);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(206, 20);
            this.tBoxEmail.TabIndex = 12;
            this.tBoxEmail.TextChanged += new System.EventHandler(this.tBoxEmail_TextChanged);
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(103, 109);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(250, 20);
            this.tBoxLName.TabIndex = 11;
            this.tBoxLName.TextChanged += new System.EventHandler(this.tBoxLName_TextChanged);
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(102, 83);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(251, 20);
            this.tBoxFName.TabIndex = 10;
            this.tBoxFName.TextChanged += new System.EventHandler(this.tBoxFName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "IC/Passport No.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // cboStudID
            // 
            this.cboStudID.FormattingEnabled = true;
            this.cboStudID.Location = new System.Drawing.Point(102, 29);
            this.cboStudID.Name = "cboStudID";
            this.cboStudID.Size = new System.Drawing.Size(251, 21);
            this.cboStudID.TabIndex = 1;
            this.cboStudID.SelectedIndexChanged += new System.EventHandler(this.cboStudID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // frmViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 279);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmViewStudent";
            this.Text = "Student : Viewing/Editing";
            this.Load += new System.EventHandler(this.frmViewStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStudID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxICPsp;
        private System.Windows.Forms.TextBox tBoxGender;
    }
}