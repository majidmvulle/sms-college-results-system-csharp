namespace SMSCollegeResultsSystem._Forms
{
    partial class frmResultsCalc
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
            this.pnlResultsCalc = new System.Windows.Forms.Panel();
            this.gBoxModule = new System.Windows.Forms.GroupBox();
            this.rBtnCWExam = new System.Windows.Forms.RadioButton();
            this.rBtnCW = new System.Windows.Forms.RadioButton();
            this.cBoxMidTerm = new System.Windows.Forms.CheckBox();
            this.lblAss1 = new System.Windows.Forms.Label();
            this.tBoxAss1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ass1Weight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFExam = new System.Windows.Forms.Label();
            this.tBoxFExam = new System.Windows.Forms.TextBox();
            this.FExamWeight = new System.Windows.Forms.NumericUpDown();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.tBoxMidTerm = new System.Windows.Forms.TextBox();
            this.MidTermWeight = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalcGrade = new System.Windows.Forms.Label();
            this.lblCalcPoints = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlResultsCalc.SuspendLayout();
            this.gBoxModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ass1Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FExamWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidTermWeight)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResultsCalc
            // 
            this.pnlResultsCalc.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlResultsCalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResultsCalc.Controls.Add(this.panel1);
            this.pnlResultsCalc.Controls.Add(this.btnCancel);
            this.pnlResultsCalc.Controls.Add(this.btnClear);
            this.pnlResultsCalc.Controls.Add(this.btnCalculate);
            this.pnlResultsCalc.Controls.Add(this.MidTermWeight);
            this.pnlResultsCalc.Controls.Add(this.tBoxMidTerm);
            this.pnlResultsCalc.Controls.Add(this.lblMidTerm);
            this.pnlResultsCalc.Controls.Add(this.FExamWeight);
            this.pnlResultsCalc.Controls.Add(this.tBoxFExam);
            this.pnlResultsCalc.Controls.Add(this.lblFExam);
            this.pnlResultsCalc.Controls.Add(this.label2);
            this.pnlResultsCalc.Controls.Add(this.ass1Weight);
            this.pnlResultsCalc.Controls.Add(this.cBoxMidTerm);
            this.pnlResultsCalc.Controls.Add(this.label1);
            this.pnlResultsCalc.Controls.Add(this.tBoxAss1);
            this.pnlResultsCalc.Controls.Add(this.lblAss1);
            this.pnlResultsCalc.Controls.Add(this.gBoxModule);
            this.pnlResultsCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultsCalc.Location = new System.Drawing.Point(0, 0);
            this.pnlResultsCalc.Name = "pnlResultsCalc";
            this.pnlResultsCalc.Size = new System.Drawing.Size(434, 502);
            this.pnlResultsCalc.TabIndex = 0;
            this.pnlResultsCalc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResultsCalc_Paint);
            // 
            // gBoxModule
            // 
            this.gBoxModule.Controls.Add(this.rBtnCWExam);
            this.gBoxModule.Controls.Add(this.rBtnCW);
            this.gBoxModule.Location = new System.Drawing.Point(10, 10);
            this.gBoxModule.Name = "gBoxModule";
            this.gBoxModule.Size = new System.Drawing.Size(171, 83);
            this.gBoxModule.TabIndex = 3;
            this.gBoxModule.TabStop = false;
            this.gBoxModule.Text = "Module Assessment";
            // 
            // rBtnCWExam
            // 
            this.rBtnCWExam.AutoSize = true;
            this.rBtnCWExam.Location = new System.Drawing.Point(6, 52);
            this.rBtnCWExam.Name = "rBtnCWExam";
            this.rBtnCWExam.Size = new System.Drawing.Size(162, 17);
            this.rBtnCWExam.TabIndex = 1;
            this.rBtnCWExam.TabStop = true;
            this.rBtnCWExam.Text = "Course Work and Final Exam";
            this.rBtnCWExam.UseVisualStyleBackColor = true;
            // 
            // rBtnCW
            // 
            this.rBtnCW.AutoSize = true;
            this.rBtnCW.Location = new System.Drawing.Point(6, 29);
            this.rBtnCW.Name = "rBtnCW";
            this.rBtnCW.Size = new System.Drawing.Size(109, 17);
            this.rBtnCW.TabIndex = 0;
            this.rBtnCW.TabStop = true;
            this.rBtnCW.Text = "Course Work only";
            this.rBtnCW.UseVisualStyleBackColor = true;
            // 
            // cBoxMidTerm
            // 
            this.cBoxMidTerm.AutoSize = true;
            this.cBoxMidTerm.Location = new System.Drawing.Point(10, 109);
            this.cBoxMidTerm.Name = "cBoxMidTerm";
            this.cBoxMidTerm.Size = new System.Drawing.Size(94, 17);
            this.cBoxMidTerm.TabIndex = 4;
            this.cBoxMidTerm.Text = "Mid-Term Test";
            this.cBoxMidTerm.UseVisualStyleBackColor = true;
            this.cBoxMidTerm.CheckedChanged += new System.EventHandler(this.cBoxMidTerm_CheckedChanged);
            // 
            // lblAss1
            // 
            this.lblAss1.AutoSize = true;
            this.lblAss1.Location = new System.Drawing.Point(63, 235);
            this.lblAss1.Name = "lblAss1";
            this.lblAss1.Size = new System.Drawing.Size(73, 13);
            this.lblAss1.TabIndex = 5;
            this.lblAss1.Text = "Assignment 1:";
            // 
            // tBoxAss1
            // 
            this.tBoxAss1.BackColor = System.Drawing.SystemColors.Window;
            this.tBoxAss1.Location = new System.Drawing.Point(163, 228);
            this.tBoxAss1.Name = "tBoxAss1";
            this.tBoxAss1.Size = new System.Drawing.Size(31, 20);
            this.tBoxAss1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mark (%)";
            // 
            // ass1Weight
            // 
            this.ass1Weight.Location = new System.Drawing.Point(241, 228);
            this.ass1Weight.Name = "ass1Weight";
            this.ass1Weight.Size = new System.Drawing.Size(45, 20);
            this.ass1Weight.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Weightage (%)";
            // 
            // lblFExam
            // 
            this.lblFExam.AutoSize = true;
            this.lblFExam.Location = new System.Drawing.Point(75, 208);
            this.lblFExam.Name = "lblFExam";
            this.lblFExam.Size = new System.Drawing.Size(61, 13);
            this.lblFExam.TabIndex = 10;
            this.lblFExam.Text = "Final Exam:";
            // 
            // tBoxFExam
            // 
            this.tBoxFExam.Location = new System.Drawing.Point(163, 201);
            this.tBoxFExam.Name = "tBoxFExam";
            this.tBoxFExam.Size = new System.Drawing.Size(31, 20);
            this.tBoxFExam.TabIndex = 11;
            // 
            // FExamWeight
            // 
            this.FExamWeight.Location = new System.Drawing.Point(241, 201);
            this.FExamWeight.Name = "FExamWeight";
            this.FExamWeight.Size = new System.Drawing.Size(45, 20);
            this.FExamWeight.TabIndex = 12;
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(58, 181);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(78, 13);
            this.lblMidTerm.TabIndex = 13;
            this.lblMidTerm.Text = "Mid-Term Test:";
            // 
            // tBoxMidTerm
            // 
            this.tBoxMidTerm.Location = new System.Drawing.Point(163, 174);
            this.tBoxMidTerm.Name = "tBoxMidTerm";
            this.tBoxMidTerm.Size = new System.Drawing.Size(31, 20);
            this.tBoxMidTerm.TabIndex = 14;
            // 
            // MidTermWeight
            // 
            this.MidTermWeight.Location = new System.Drawing.Point(241, 174);
            this.MidTermWeight.Name = "MidTermWeight";
            this.MidTermWeight.Size = new System.Drawing.Size(45, 20);
            this.MidTermWeight.TabIndex = 15;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(78, 322);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(159, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblCalcPoints);
            this.panel1.Controls.Add(this.lblCalcGrade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPoints);
            this.panel1.Controls.Add(this.lblGrade);
            this.panel1.Location = new System.Drawing.Point(78, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 106);
            this.panel1.TabIndex = 19;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(36, 20);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(36, 50);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(39, 13);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Points:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // lblCalcGrade
            // 
            this.lblCalcGrade.AutoSize = true;
            this.lblCalcGrade.Location = new System.Drawing.Point(95, 20);
            this.lblCalcGrade.Name = "lblCalcGrade";
            this.lblCalcGrade.Size = new System.Drawing.Size(35, 13);
            this.lblCalcGrade.TabIndex = 3;
            this.lblCalcGrade.Text = "label4";
            // 
            // lblCalcPoints
            // 
            this.lblCalcPoints.AutoSize = true;
            this.lblCalcPoints.Location = new System.Drawing.Point(95, 50);
            this.lblCalcPoints.Name = "lblCalcPoints";
            this.lblCalcPoints.Size = new System.Drawing.Size(35, 13);
            this.lblCalcPoints.TabIndex = 4;
            this.lblCalcPoints.Text = "label5";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(95, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "label6";
            // 
            // frmResultsCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 502);
            this.Controls.Add(this.pnlResultsCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResultsCalc";
            this.Text = "Results Calculator";
            this.Load += new System.EventHandler(this.frmResultsCalc_Load);
            this.pnlResultsCalc.ResumeLayout(false);
            this.pnlResultsCalc.PerformLayout();
            this.gBoxModule.ResumeLayout(false);
            this.gBoxModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ass1Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FExamWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidTermWeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResultsCalc;
        private System.Windows.Forms.GroupBox gBoxModule;
        private System.Windows.Forms.RadioButton rBtnCWExam;
        private System.Windows.Forms.RadioButton rBtnCW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ass1Weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxAss1;
        private System.Windows.Forms.Label lblAss1;
        private System.Windows.Forms.CheckBox cBoxMidTerm;
        private System.Windows.Forms.TextBox tBoxFExam;
        private System.Windows.Forms.Label lblFExam;
        private System.Windows.Forms.NumericUpDown MidTermWeight;
        private System.Windows.Forms.TextBox tBoxMidTerm;
        private System.Windows.Forms.Label lblMidTerm;
        private System.Windows.Forms.NumericUpDown FExamWeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCalcPoints;
        private System.Windows.Forms.Label lblCalcGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
    }
}