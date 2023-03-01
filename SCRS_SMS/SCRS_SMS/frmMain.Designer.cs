namespace SCRS_SMS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblConStatus = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tBoxOutput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBattCharge = new System.Windows.Forms.Button();
            this.btnSignalQ = new System.Windows.Forms.Button();
            this.btnPhoneID = new System.Windows.Forms.Button();
            this.btnConStatus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSvcStatus = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNotifyDisable = new System.Windows.Forms.Button();
            this.btnNotifyEnable = new System.Windows.Forms.Button();
            this.btnDeleteAllSMS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxSMSIndex = new System.Windows.Forms.TextBox();
            this.btnDeleteSMSAtIndex = new System.Windows.Forms.Button();
            this.btnReadAllSMS = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBoxEnableBatch = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxSendTimes = new System.Windows.Forms.TextBox();
            this.chkBoxSendSMSTimes = new System.Windows.Forms.CheckBox();
            this.btnSMSSendClear = new System.Windows.Forms.Button();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.tBoxSMSMsg = new System.Windows.Forms.TextBox();
            this.tBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblConStatus);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.tBoxOutput);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 545);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SCRS_SMS.Properties.Resources.projBanner62;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 80);
            this.panel2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(252, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "SMS Manager";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(10, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit System";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConStatus
            // 
            this.lblConStatus.AutoSize = true;
            this.lblConStatus.BackColor = System.Drawing.Color.White;
            this.lblConStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConStatus.Location = new System.Drawing.Point(176, 521);
            this.lblConStatus.Name = "lblConStatus";
            this.lblConStatus.Size = new System.Drawing.Size(134, 13);
            this.lblConStatus.TabIndex = 3;
            this.lblConStatus.Text = "NO PHONE CONNECTED";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(394, 508);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Output";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tBoxOutput
            // 
            this.tBoxOutput.Location = new System.Drawing.Point(3, 321);
            this.tBoxOutput.Multiline = true;
            this.tBoxOutput.Name = "tBoxOutput";
            this.tBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxOutput.Size = new System.Drawing.Size(480, 150);
            this.tBoxOutput.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 222);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnBattCharge);
            this.tabPage1.Controls.Add(this.btnSignalQ);
            this.tabPage1.Controls.Add(this.btnPhoneID);
            this.tabPage1.Controls.Add(this.btnConStatus);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Maintenance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "SMS Hotline:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "+60 17 611 2415";
            // 
            // btnBattCharge
            // 
            this.btnBattCharge.Location = new System.Drawing.Point(27, 157);
            this.btnBattCharge.Name = "btnBattCharge";
            this.btnBattCharge.Size = new System.Drawing.Size(123, 23);
            this.btnBattCharge.TabIndex = 5;
            this.btnBattCharge.Text = "Phone Battery Charge";
            this.btnBattCharge.UseVisualStyleBackColor = true;
            this.btnBattCharge.Click += new System.EventHandler(this.btnBattCharge_Click);
            // 
            // btnSignalQ
            // 
            this.btnSignalQ.Location = new System.Drawing.Point(27, 119);
            this.btnSignalQ.Name = "btnSignalQ";
            this.btnSignalQ.Size = new System.Drawing.Size(123, 23);
            this.btnSignalQ.TabIndex = 4;
            this.btnSignalQ.Text = "Phone Signal Quality";
            this.btnSignalQ.UseVisualStyleBackColor = true;
            this.btnSignalQ.Click += new System.EventHandler(this.btnSignalQ_Click);
            // 
            // btnPhoneID
            // 
            this.btnPhoneID.Location = new System.Drawing.Point(27, 77);
            this.btnPhoneID.Name = "btnPhoneID";
            this.btnPhoneID.Size = new System.Drawing.Size(123, 23);
            this.btnPhoneID.TabIndex = 3;
            this.btnPhoneID.Text = "Phone Identification";
            this.btnPhoneID.UseVisualStyleBackColor = true;
            this.btnPhoneID.Click += new System.EventHandler(this.btnPhoneID_Click);
            // 
            // btnConStatus
            // 
            this.btnConStatus.Location = new System.Drawing.Point(27, 35);
            this.btnConStatus.Name = "btnConStatus";
            this.btnConStatus.Size = new System.Drawing.Size(123, 23);
            this.btnConStatus.TabIndex = 2;
            this.btnConStatus.Text = "Connection Status";
            this.btnConStatus.UseVisualStyleBackColor = true;
            this.btnConStatus.Click += new System.EventHandler(this.btnConStatus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSvcStatus);
            this.groupBox1.Controls.Add(this.btnOff);
            this.groupBox1.Controls.Add(this.btnOn);
            this.groupBox1.Location = new System.Drawing.Point(267, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SCRS - SMS Service";
            // 
            // lblSvcStatus
            // 
            this.lblSvcStatus.AutoSize = true;
            this.lblSvcStatus.Location = new System.Drawing.Point(6, 120);
            this.lblSvcStatus.Name = "lblSvcStatus";
            this.lblSvcStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSvcStatus.TabIndex = 2;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(58, 71);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Turn Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(58, 29);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(75, 23);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "Turn On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnDeleteAllSMS);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tBoxSMSIndex);
            this.tabPage2.Controls.Add(this.btnDeleteSMSAtIndex);
            this.tabPage2.Controls.Add(this.btnReadAllSMS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual SMS Manage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNotifyDisable);
            this.groupBox2.Controls.Add(this.btnNotifyEnable);
            this.groupBox2.Location = new System.Drawing.Point(267, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SMS Notifications";
            // 
            // btnNotifyDisable
            // 
            this.btnNotifyDisable.Location = new System.Drawing.Point(56, 53);
            this.btnNotifyDisable.Name = "btnNotifyDisable";
            this.btnNotifyDisable.Size = new System.Drawing.Size(75, 23);
            this.btnNotifyDisable.TabIndex = 1;
            this.btnNotifyDisable.Text = "Disable";
            this.btnNotifyDisable.UseVisualStyleBackColor = true;
            this.btnNotifyDisable.Click += new System.EventHandler(this.btnNotifyDisable_Click);
            // 
            // btnNotifyEnable
            // 
            this.btnNotifyEnable.Location = new System.Drawing.Point(26, 24);
            this.btnNotifyEnable.Name = "btnNotifyEnable";
            this.btnNotifyEnable.Size = new System.Drawing.Size(138, 23);
            this.btnNotifyEnable.TabIndex = 0;
            this.btnNotifyEnable.Text = "Enable SMS Notifications";
            this.btnNotifyEnable.UseVisualStyleBackColor = true;
            this.btnNotifyEnable.Click += new System.EventHandler(this.btnNotifyEnable_Click);
            // 
            // btnDeleteAllSMS
            // 
            this.btnDeleteAllSMS.Location = new System.Drawing.Point(21, 133);
            this.btnDeleteAllSMS.Name = "btnDeleteAllSMS";
            this.btnDeleteAllSMS.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteAllSMS.TabIndex = 4;
            this.btnDeleteAllSMS.Text = "Delete All SMS";
            this.btnDeleteAllSMS.UseVisualStyleBackColor = true;
            this.btnDeleteAllSMS.Click += new System.EventHandler(this.btnDeleteAllSMS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index:";
            // 
            // tBoxSMSIndex
            // 
            this.tBoxSMSIndex.Location = new System.Drawing.Point(103, 85);
            this.tBoxSMSIndex.Name = "tBoxSMSIndex";
            this.tBoxSMSIndex.Size = new System.Drawing.Size(37, 20);
            this.tBoxSMSIndex.TabIndex = 2;
            this.tBoxSMSIndex.Text = "1";
            // 
            // btnDeleteSMSAtIndex
            // 
            this.btnDeleteSMSAtIndex.Location = new System.Drawing.Point(21, 82);
            this.btnDeleteSMSAtIndex.Name = "btnDeleteSMSAtIndex";
            this.btnDeleteSMSAtIndex.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSMSAtIndex.TabIndex = 1;
            this.btnDeleteSMSAtIndex.Text = "Delete SMS";
            this.btnDeleteSMSAtIndex.UseVisualStyleBackColor = true;
            this.btnDeleteSMSAtIndex.Click += new System.EventHandler(this.btnDeleteSMSAtIndex_Click);
            // 
            // btnReadAllSMS
            // 
            this.btnReadAllSMS.Location = new System.Drawing.Point(21, 30);
            this.btnReadAllSMS.Name = "btnReadAllSMS";
            this.btnReadAllSMS.Size = new System.Drawing.Size(107, 23);
            this.btnReadAllSMS.TabIndex = 0;
            this.btnReadAllSMS.Text = "Read All SMS";
            this.btnReadAllSMS.UseVisualStyleBackColor = true;
            this.btnReadAllSMS.Click += new System.EventHandler(this.btnReadAllSMS_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.btnSMSSendClear);
            this.tabPage3.Controls.Add(this.btnSendSMS);
            this.tabPage3.Controls.Add(this.tBoxSMSMsg);
            this.tabPage3.Controls.Add(this.tBoxPhoneNo);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(472, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manual SMS Send";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBoxEnableBatch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tBoxSendTimes);
            this.groupBox3.Controls.Add(this.chkBoxSendSMSTimes);
            this.groupBox3.Location = new System.Drawing.Point(280, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 113);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // chkBoxEnableBatch
            // 
            this.chkBoxEnableBatch.AutoSize = true;
            this.chkBoxEnableBatch.Location = new System.Drawing.Point(6, 62);
            this.chkBoxEnableBatch.Name = "chkBoxEnableBatch";
            this.chkBoxEnableBatch.Size = new System.Drawing.Size(120, 17);
            this.chkBoxEnableBatch.TabIndex = 3;
            this.chkBoxEnableBatch.Text = "Enable Batch Mode";
            this.chkBoxEnableBatch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "times";
            // 
            // tBoxSendTimes
            // 
            this.tBoxSendTimes.Location = new System.Drawing.Point(108, 25);
            this.tBoxSendTimes.Name = "tBoxSendTimes";
            this.tBoxSendTimes.Size = new System.Drawing.Size(36, 20);
            this.tBoxSendTimes.TabIndex = 1;
            // 
            // chkBoxSendSMSTimes
            // 
            this.chkBoxSendSMSTimes.AutoSize = true;
            this.chkBoxSendSMSTimes.Location = new System.Drawing.Point(6, 28);
            this.chkBoxSendSMSTimes.Name = "chkBoxSendSMSTimes";
            this.chkBoxSendSMSTimes.Size = new System.Drawing.Size(96, 17);
            this.chkBoxSendSMSTimes.TabIndex = 0;
            this.chkBoxSendSMSTimes.Text = "Send this SMS";
            this.chkBoxSendSMSTimes.UseVisualStyleBackColor = true;
            // 
            // btnSMSSendClear
            // 
            this.btnSMSSendClear.Location = new System.Drawing.Point(199, 157);
            this.btnSMSSendClear.Name = "btnSMSSendClear";
            this.btnSMSSendClear.Size = new System.Drawing.Size(75, 23);
            this.btnSMSSendClear.TabIndex = 5;
            this.btnSMSSendClear.Text = "Clear";
            this.btnSMSSendClear.UseVisualStyleBackColor = true;
            this.btnSMSSendClear.Click += new System.EventHandler(this.btnSMSSendClear_Click);
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(107, 158);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(75, 23);
            this.btnSendSMS.TabIndex = 4;
            this.btnSendSMS.Text = "Send SMS";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // tBoxSMSMsg
            // 
            this.tBoxSMSMsg.Location = new System.Drawing.Point(107, 66);
            this.tBoxSMSMsg.Multiline = true;
            this.tBoxSMSMsg.Name = "tBoxSMSMsg";
            this.tBoxSMSMsg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tBoxSMSMsg.Size = new System.Drawing.Size(167, 85);
            this.tBoxSMSMsg.TabIndex = 3;
            // 
            // tBoxPhoneNo
            // 
            this.tBoxPhoneNo.Location = new System.Drawing.Point(107, 38);
            this.tBoxPhoneNo.Name = "tBoxPhoneNo";
            this.tBoxPhoneNo.Size = new System.Drawing.Size(167, 20);
            this.tBoxPhoneNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Message:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "SCRSMinim";
            this.notifyIcon1.BalloonTipTitle = "SCRS";
            this.notifyIcon1.Text = "SCRS";
            this.notifyIcon1.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 545);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SMS College Results System - SMS Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tBoxOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBattCharge;
        private System.Windows.Forms.Button btnSignalQ;
        private System.Windows.Forms.Button btnPhoneID;
        private System.Windows.Forms.Button btnConStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSvcStatus;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNotifyDisable;
        private System.Windows.Forms.Button btnNotifyEnable;
        private System.Windows.Forms.Button btnDeleteAllSMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxSMSIndex;
        private System.Windows.Forms.Button btnDeleteSMSAtIndex;
        private System.Windows.Forms.Button btnReadAllSMS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkBoxEnableBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxSendTimes;
        private System.Windows.Forms.CheckBox chkBoxSendSMSTimes;
        private System.Windows.Forms.Button btnSMSSendClear;
        private System.Windows.Forms.Button btnSendSMS;
        private System.Windows.Forms.TextBox tBoxSMSMsg;
        private System.Windows.Forms.TextBox tBoxPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}