namespace SMSCollegeResultsSystem._Forms
{
    partial class frmDeleteDept
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
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxHodID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteDept = new System.Windows.Forms.Button();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBoxHodID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDeleteDept);
            this.panel1.Controls.Add(this.cboDept);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 238);
            this.panel1.TabIndex = 0;
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(111, 151);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(249, 20);
            this.tBoxLName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(19, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "HoD Last Name:";
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(113, 125);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(247, 20);
            this.tBoxFName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "HoD First Name:";
            // 
            // tBoxHodID
            // 
            this.tBoxHodID.Enabled = false;
            this.tBoxHodID.Location = new System.Drawing.Point(113, 98);
            this.tBoxHodID.Name = "tBoxHodID";
            this.tBoxHodID.Size = new System.Drawing.Size(178, 20);
            this.tBoxHodID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "HoD ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.Enabled = false;
            this.btnDeleteDept.Location = new System.Drawing.Point(136, 201);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDept.TabIndex = 8;
            this.btnDeleteDept.Text = "Delete Dept.";
            this.btnDeleteDept.UseVisualStyleBackColor = true;
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(113, 71);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(179, 21);
            this.cboDept.TabIndex = 6;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDeptName_SelectedIndexChanged);
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(113, 35);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(247, 21);
            this.cboSchool.TabIndex = 4;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dept. Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School:";
            // 
            // frmDeleteDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 238);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDeleteDept";
            this.Text = "Department : Deleting";
            this.Load += new System.EventHandler(this.frmDeleteDept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteDept;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxHodID;
        private System.Windows.Forms.Label label2;
    }
}