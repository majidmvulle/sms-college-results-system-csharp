namespace SMSCollegeResultsSystem._Forms
{
    partial class frmViewModule
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cboModPrereq = new System.Windows.Forms.ComboBox();
            this.tBoxModName = new System.Windows.Forms.TextBox();
            this.cboModCode = new System.Windows.Forms.ComboBox();
            this.cboDeptName = new System.Windows.Forms.ComboBox();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.cboModPrereq);
            this.panel1.Controls.Add(this.tBoxModName);
            this.panel1.Controls.Add(this.cboModCode);
            this.panel1.Controls.Add(this.cboDeptName);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 245);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(171, 208);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(86, 23);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cboModPrereq
            // 
            this.cboModPrereq.Enabled = false;
            this.cboModPrereq.FormattingEnabled = true;
            this.cboModPrereq.Location = new System.Drawing.Point(115, 165);
            this.cboModPrereq.Name = "cboModPrereq";
            this.cboModPrereq.Size = new System.Drawing.Size(109, 21);
            this.cboModPrereq.TabIndex = 13;
            this.cboModPrereq.SelectedIndexChanged += new System.EventHandler(this.cboModPrereq_SelectedIndexChanged);
            // 
            // tBoxModName
            // 
            this.tBoxModName.Enabled = false;
            this.tBoxModName.Location = new System.Drawing.Point(115, 139);
            this.tBoxModName.Name = "tBoxModName";
            this.tBoxModName.Size = new System.Drawing.Size(274, 20);
            this.tBoxModName.TabIndex = 12;
            this.tBoxModName.TextChanged += new System.EventHandler(this.tBoxModName_TextChanged);
            // 
            // cboModCode
            // 
            this.cboModCode.Enabled = false;
            this.cboModCode.FormattingEnabled = true;
            this.cboModCode.Location = new System.Drawing.Point(115, 112);
            this.cboModCode.Name = "cboModCode";
            this.cboModCode.Size = new System.Drawing.Size(108, 21);
            this.cboModCode.TabIndex = 11;
            this.cboModCode.SelectedIndexChanged += new System.EventHandler(this.cboModCode_SelectedIndexChanged);
            // 
            // cboDeptName
            // 
            this.cboDeptName.Enabled = false;
            this.cboDeptName.FormattingEnabled = true;
            this.cboDeptName.Location = new System.Drawing.Point(115, 72);
            this.cboDeptName.Name = "cboDeptName";
            this.cboDeptName.Size = new System.Drawing.Size(274, 21);
            this.cboDeptName.TabIndex = 9;
            this.cboDeptName.SelectedIndexChanged += new System.EventHandler(this.cboDeptName_SelectedIndexChanged);
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(115, 45);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(274, 21);
            this.cboSchool.TabIndex = 7;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Module Prereq.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Module Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Module Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dept. Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School:";
            // 
            // frmViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 245);
            this.Controls.Add(this.panel1);
            this.Name = "frmViewModule";
            this.Text = "Module : Viewing/Editing";
            this.Load += new System.EventHandler(this.frmViewModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cboModPrereq;
        private System.Windows.Forms.TextBox tBoxModName;
        private System.Windows.Forms.ComboBox cboModCode;
        private System.Windows.Forms.ComboBox cboDeptName;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}