namespace SMSCollegeResultsSystem._Forms
{
    partial class frmAddLecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnFMale = new System.Windows.Forms.RadioButton();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxICPsp = new System.Windows.Forms.TextBox();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.tBoxAssignID = new System.Windows.Forms.TextBox();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IC/Passport No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone No.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnFMale);
            this.groupBox1.Controls.Add(this.rBtnMale);
            this.groupBox1.Location = new System.Drawing.Point(120, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rBtnFMale
            // 
            this.rBtnFMale.AutoSize = true;
            this.rBtnFMale.Location = new System.Drawing.Point(6, 43);
            this.rBtnFMale.Name = "rBtnFMale";
            this.rBtnFMale.Size = new System.Drawing.Size(59, 17);
            this.rBtnFMale.TabIndex = 1;
            this.rBtnFMale.TabStop = true;
            this.rBtnFMale.Text = "Female";
            this.rBtnFMale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(6, 19);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(48, 17);
            this.rBtnMale.TabIndex = 0;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assign ID No.:";
            // 
            // tBoxICPsp
            // 
            this.tBoxICPsp.Location = new System.Drawing.Point(120, 15);
            this.tBoxICPsp.Name = "tBoxICPsp";
            this.tBoxICPsp.Size = new System.Drawing.Size(250, 20);
            this.tBoxICPsp.TabIndex = 6;
            this.tBoxICPsp.TextChanged += new System.EventHandler(this.tBoxICPsp_TextChanged);
            // 
            // tBoxFName
            // 
            this.tBoxFName.Location = new System.Drawing.Point(120, 41);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(250, 20);
            this.tBoxFName.TabIndex = 7;
            // 
            // tBoxLName
            // 
            this.tBoxLName.Location = new System.Drawing.Point(120, 67);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(250, 20);
            this.tBoxLName.TabIndex = 8;
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(120, 173);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(202, 20);
            this.tBoxPhone.TabIndex = 9;
            // 
            // tBoxAssignID
            // 
            this.tBoxAssignID.Location = new System.Drawing.Point(120, 237);
            this.tBoxAssignID.Name = "tBoxAssignID";
            this.tBoxAssignID.Size = new System.Drawing.Size(144, 20);
            this.tBoxAssignID.TabIndex = 10;
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.Enabled = false;
            this.btnAddLecturer.Location = new System.Drawing.Point(157, 279);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(84, 23);
            this.btnAddLecturer.TabIndex = 11;
            this.btnAddLecturer.Text = "Add Lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = true;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tBoxEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddLecturer);
            this.panel1.Controls.Add(this.tBoxAssignID);
            this.panel1.Controls.Add(this.tBoxPhone);
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.tBoxICPsp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 316);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone format: 0173412893";
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(120, 211);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(202, 20);
            this.tBoxEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email:";
            // 
            // frmAddLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 316);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAddLecturer";
            this.Text = "Lecturer : Adding";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnFMale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxICPsp;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.TextBox tBoxAssignID;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}