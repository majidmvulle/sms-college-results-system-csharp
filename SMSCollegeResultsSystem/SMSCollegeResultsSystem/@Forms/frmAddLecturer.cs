using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;


namespace SMSCollegeResultsSystem._Forms
{
    public partial class frmAddLecturer : Form
    {
        //Create a Student Object
        SMSCollegeResultsSystem._Class.clsLecturer lecturer;


        public frmAddLecturer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
        
            //ensures no TextBoxes are empty
            if (tBoxICPsp.Text == "" || tBoxPhone.Text == "" ||
                tBoxFName.Text == "" || tBoxLName.Text == "" ||
                tBoxAssignID.Text == "" || tBoxEmail.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxICPsp.Focus(); //set focus to ICPassportTextBox

                return;
            }//end if

            //if first name format invalid, show message
            if (!Regex.Match(tBoxFName.Text,
                "^[A-Z][a-zA-Z]*$").Success)
            {
                //first name was incorrect
                MessageBox.Show("Invalid First name", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxFName.Focus();
                return;
            }//end if

            //if last name format invalid, show message
            if (!Regex.Match(tBoxLName.Text,
                "^[A-Z][a-zA-Z]*$").Success)
            {
                //last name was incorrect
                MessageBox.Show("Invalid First name", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxLName.Focus();
                return;
            }//end if

            //if phone number format invalid, show message
            if (!Regex.Match(tBoxPhone.Text , @"^\d{10}$").Success)
            {
                //phone was incorrect
                MessageBox.Show("Invalid Phone Number", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxPhone.Focus();

                return;

            }//end if

            else
            {
                string Gender = "";

                if (rBtnMale.Checked)
                {
                    Gender = "M";
                }

                if (rBtnFMale.Checked)
                {
                    Gender = "F";
                }

                try
                {
                    lecturer = new _Class.clsLecturer(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        Gender, tBoxEmail.Text.ToString(),
                        tBoxAssignID.Text.ToString());

                    lecturer.AddPerson(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        Gender, tBoxEmail.Text.ToString(),
                        tBoxAssignID.Text.ToString());

                    MessageBox.Show("Lecturer ("+ tBoxFName.Text +" "+tBoxLName.Text+") Added!", "Infomation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tBoxICPsp.Text = "";
                    tBoxFName.Text = "";
                    tBoxLName.Text = "";
                    tBoxPhone.Text = "";
                    tBoxAssignID.Text = "";
                    tBoxEmail.Text = "";

                    btnAddLecturer.Enabled = false;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Unable to Add Lecturer!\nError: " + exc.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void tBoxICPsp_TextChanged(object sender, EventArgs e)
        {
            btnAddLecturer.Enabled = true;
        }

        

    }
}
