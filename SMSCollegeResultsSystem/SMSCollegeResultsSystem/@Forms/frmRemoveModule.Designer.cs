namespace SMSCollegeResultsSystem._Forms
{
    partial class frmRemoveModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.tBoxModName = new System.Windows.Forms.TextBox();
            this.btnRemoveModule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRemoveModule);
            this.panel1.Controls.Add(this.tBoxModName);
            this.panel1.Controls.Add(this.cboModule);
            this.panel1.Controls.Add(this.cboDept);
            this.panel1.Controls.Add(this.cboSchool);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 215);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "School:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module Name:";
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(114, 30);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(221, 21);
            this.cboSchool.TabIndex = 4;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(113, 57);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(222, 21);
            this.cboDept.TabIndex = 5;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // cboModule
            // 
            this.cboModule.Enabled = false;
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Location = new System.Drawing.Point(113, 97);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(121, 21);
            this.cboModule.TabIndex = 6;
            this.cboModule.SelectedIndexChanged += new System.EventHandler(this.cboModule_SelectedIndexChanged);
            // 
            // tBoxModName
            // 
            this.tBoxModName.Enabled = false;
            this.tBoxModName.Location = new System.Drawing.Point(113, 124);
            this.tBoxModName.Name = "tBoxModName";
            this.tBoxModName.Size = new System.Drawing.Size(221, 20);
            this.tBoxModName.TabIndex = 7;
            // 
            // btnRemoveModule
            // 
            this.btnRemoveModule.Enabled = false;
            this.btnRemoveModule.Location = new System.Drawing.Point(10, 178);
            this.btnRemoveModule.Name = "btnRemoveModule";
            this.btnRemoveModule.Size = new System.Drawing.Size(177, 23);
            this.btnRemoveModule.TabIndex = 8;
            this.btnRemoveModule.Text = "Remove Module from Offered List";
            this.btnRemoveModule.UseVisualStyleBackColor = true;
            this.btnRemoveModule.Click += new System.EventHandler(this.btnRemoveModule_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRemoveModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 215);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmRemoveModule";
            this.Text = "Modules Offered Next : Removing";
            this.Load += new System.EventHandler(this.frmRemoveModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemoveModule;
        private System.Windows.Forms.TextBox tBoxModName;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}