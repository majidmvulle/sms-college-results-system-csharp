namespace SMSCollegeResultsSystem._Forms
{
    partial class frmAddDept
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
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.cboHodID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxDeptName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddDept);
            this.panel1.Controls.Add(this.cboHodID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxDeptName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 231);
            this.panel1.TabIndex = 0;
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(100, 150);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(257, 20);
            this.tBoxLName.TabIndex = 14;
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(100, 124);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(257, 20);
            this.tBoxFName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Enabled = false;
            this.btnAddDept.Location = new System.Drawing.Point(130, 191);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(95, 23);
            this.btnAddDept.TabIndex = 8;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // cboHodID
            // 
            this.cboHodID.Enabled = false;
            this.cboHodID.FormattingEnabled = true;
            this.cboHodID.Location = new System.Drawing.Point(101, 97);
            this.cboHodID.Name = "cboHodID";
            this.cboHodID.Size = new System.Drawing.Size(168, 21);
            this.cboHodID.TabIndex = 7;
            this.cboHodID.SelectedIndexChanged += new System.EventHandler(this.cboHodID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assign HoD:";
            // 
            // tBoxDeptName
            // 
            this.tBoxDeptName.Enabled = false;
            this.tBoxDeptName.Location = new System.Drawing.Point(100, 71);
            this.tBoxDeptName.Name = "tBoxDeptName";
            this.tBoxDeptName.Size = new System.Drawing.Size(257, 20);
            this.tBoxDeptName.TabIndex = 5;
            this.tBoxDeptName.TextChanged += new System.EventHandler(this.tBoxDeptName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dept. Name:";
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(100, 32);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(257, 21);
            this.cboSchool.TabIndex = 2;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School:";
            // 
            // frmAddDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 231);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAddDept";
            this.Text = "Department: Adding";
            this.Load += new System.EventHandler(this.frmAddDept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.ComboBox cboHodID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxDeptName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}