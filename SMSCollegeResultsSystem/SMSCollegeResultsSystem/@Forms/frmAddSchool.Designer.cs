namespace SMSCollegeResultsSystem._Forms
{
    partial class frmAddSchool
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.cboDeanID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxSchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tBoxLName);
            this.panel1.Controls.Add(this.tBoxFName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddSchool);
            this.panel1.Controls.Add(this.cboDeanID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBoxSchName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 213);
            this.panel1.TabIndex = 0;
            // 
            // tBoxLName
            // 
            this.tBoxLName.Enabled = false;
            this.tBoxLName.Location = new System.Drawing.Point(112, 124);
            this.tBoxLName.Name = "tBoxLName";
            this.tBoxLName.Size = new System.Drawing.Size(235, 20);
            this.tBoxLName.TabIndex = 9;
            // 
            // tBoxFName
            // 
            this.tBoxFName.Enabled = false;
            this.tBoxFName.Location = new System.Drawing.Point(112, 98);
            this.tBoxFName.Name = "tBoxFName";
            this.tBoxFName.Size = new System.Drawing.Size(235, 20);
            this.tBoxFName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Enabled = false;
            this.btnAddSchool.Location = new System.Drawing.Point(161, 171);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(75, 23);
            this.btnAddSchool.TabIndex = 4;
            this.btnAddSchool.Text = "Add School";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // cboDeanID
            // 
            this.cboDeanID.Enabled = false;
            this.cboDeanID.FormattingEnabled = true;
            this.cboDeanID.Location = new System.Drawing.Point(112, 71);
            this.cboDeanID.Name = "cboDeanID";
            this.cboDeanID.Size = new System.Drawing.Size(169, 21);
            this.cboDeanID.TabIndex = 3;
            this.cboDeanID.SelectedIndexChanged += new System.EventHandler(this.cboDeanID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assign Dean:";
            // 
            // tBoxSchName
            // 
            this.tBoxSchName.Location = new System.Drawing.Point(112, 45);
            this.tBoxSchName.Name = "tBoxSchName";
            this.tBoxSchName.Size = new System.Drawing.Size(235, 20);
            this.tBoxSchName.TabIndex = 1;
            this.tBoxSchName.TextChanged += new System.EventHandler(this.tBoxSchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name:";
            // 
            // frmAddSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 213);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAddSchool";
            this.Text = "School : Adding";
            this.Load += new System.EventHandler(this.frmAddSchool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.ComboBox cboDeanID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxSchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxLName;
        private System.Windows.Forms.TextBox tBoxFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}