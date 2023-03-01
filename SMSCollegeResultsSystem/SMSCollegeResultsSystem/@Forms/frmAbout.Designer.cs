namespace SMSCollegeResultsSystem._Forms
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblAbout = new System.Windows.Forms.Label();
            this.picBoxAbout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(12, 127);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(408, 153);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // picBoxAbout
            // 
            this.picBoxAbout.Image = global::SMSCollegeResultsSystem.Properties.Resources.projBanner6;
            this.picBoxAbout.Location = new System.Drawing.Point(12, 12);
            this.picBoxAbout.Name = "picBoxAbout";
            this.picBoxAbout.Size = new System.Drawing.Size(411, 95);
            this.picBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAbout.TabIndex = 1;
            this.picBoxAbout.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 289);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.picBoxAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAbout;
        private System.Windows.Forms.Label lblAbout;

    }
}