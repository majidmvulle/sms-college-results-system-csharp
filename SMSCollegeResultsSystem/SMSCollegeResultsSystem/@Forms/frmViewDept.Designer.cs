namespace SMSCollegeResultsSystem._Forms
{
    partial class frmViewDept
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
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.tBoxDept = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cboHodID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboDept);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.tBoxDept);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.cboHodID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 267);
            this.panel1.TabIndex = 0;
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(92, 61);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(175, 21);
            this.cboDept.TabIndex = 16;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Department:";
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(93, 178);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(235, 20);
            this.tBoxLName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name:";
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(92, 152);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(236, 20);
            this.tBoxFName.TabIndex = 11;
            // 
            // tBoxDept
            // 
            this.tBoxDept.Enabled = false;
            this.tBoxDept.Location = new System.Drawing.Point(92, 88);
            this.tBoxDept.Name = "tBoxDept";
            this.tBoxDept.Size = new System.Drawing.Size(236, 20);
            this.tBoxDept.TabIndex = 10;
            this.tBoxDept.TextChanged += new System.EventHandler(this.tBoxDept_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 230);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(93, 230);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(95, 23);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cboHodID
            // 
            this.cboHodID.Enabled = false;
            this.cboHodID.FormattingEnabled = true;
            this.cboHodID.Location = new System.Drawing.Point(92, 125);
            this.cboHodID.Name = "cboHodID";
            this.cboHodID.Size = new System.Drawing.Size(146, 21);
            this.cboHodID.TabIndex = 7;
            this.cboHodID.SelectedIndexChanged += new System.EventHandler(this.cboHOD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dept. HoD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dept. Name:";
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(93, 24);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(236, 21);
            this.cboSchool.TabIndex = 1;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School:";
            // 
            // frmViewDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 267);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmViewDept";
            this.Text = "Department : Viewing/Editing";
            this.Load += new System.EventHandler(this.frmViewDept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cboHodID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxDept;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label6;

    }
}