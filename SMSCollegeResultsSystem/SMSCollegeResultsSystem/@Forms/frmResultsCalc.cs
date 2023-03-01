using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMSCollegeResultsSystem._Forms
{
    public partial class frmResultsCalc : Form
    {
       // SMSCollegeResultsSystem._Class.clsResultsCalc calc;


        public frmResultsCalc()
        {
            InitializeComponent();
        }

        private void cBoxMidTerm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlResultsCalc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmResultsCalc_Load(object sender, EventArgs e)
        {
            ass1Weight.Minimum = 5;
            FExamWeight.Minimum = 5;
            MidTermWeight.Minimum = 5;

            ass1Weight.Maximum = 100;
            FExamWeight.Maximum = 100;
            MidTermWeight.Maximum = 100;

            ass1Weight.Increment = 5;
            FExamWeight.Increment = 5;
            MidTermWeight.Increment = 5;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           /* float midTermMark;
            float assignmentMark;
            float fExamMark;
            int midTermWeight;
            int assignmentWeight;
            int fExamWeight;

            String grade;
            try
            {
                midTermMark = float.Parse(tBoxMidTerm.Text);
                assignmentMark = float.Parse(tBoxAss1.Text);
                fExamMark = float.Parse(tBoxFExam.Text);

                midTermWeight = (int)MidTermWeight.Value;
                assignmentWeight = (int)ass1Weight.Value;
                fExamWeight = (int)FExamWeight.Value;


                calc = new _Class.clsResultsCalc(midTermMark, assignmentMark,
                    fExamMark, midTermWeight, assignmentWeight, fExamWeight);

                grade = calc.calcResults();

                MessageBox.Show("Grade is " + grade, "Results Calc",
                               MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: Some values are missing!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Console.WriteLine(ex);
            }
            */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxMidTerm.Text = "";
            tBoxAss1.Text = "";
            tBoxFExam.Text = "";

            MidTermWeight.Value = 5;
            ass1Weight.Value = 5;
            FExamWeight.Value = 5;

        }
    }
}
