using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;


using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;


namespace SMSCollegeResultsSystem._Forms
{
    public partial class frmViewLecturer : Form
    {
        SMSCollegeResultsSystem._Class.clsLecturer lecturer;

        public frmViewLecturer()
        {
            InitializeComponent();
        }

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            //ensures no TextBoxes are empty
            if (tBoxPhone.Text == "" || tBoxFName.Text == "" ||
                tBoxLName.Text == "" || tBoxEmail.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxFName.Focus(); //set focus to ICPassportTextBox

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
            if (!Regex.Match(tBoxPhone.Text, @"^\d{10}$").Success)
            {
                //phone was incorrect
                MessageBox.Show("Invalid Phone Number", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxPhone.Focus();

                return;

            }//end if


            else
            {
                try
                {
                    lecturer = new _Class.clsLecturer(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(),
                        cboLecturerID.Text.ToString());

                    lecturer.View_EditPerson(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(),
                        cboLecturerID.Text.ToString());

                    MessageBox.Show("Lecturer (" + cboLecturerID.Text + ") update Success!", "Information",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboLecturerID.Text = "";
                    tBoxFName.Text = "";
                    tBoxLName.Text = "";
                    tBoxGender.Text = "";
                    tBoxICPsp.Text = "";
                    tBoxPhone.Text = "";
                    tBoxEmail.Text = "";
                }

                catch(Exception exc)
                {
                    MessageBox.Show("Lecturer information update Failed!\nError: "+exc.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void cboLecturerID_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            string selectSQL =
                 "SELECT * FROM Lecturer WHERE lectID ='" + cboLecturerID.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                tBoxICPsp.Text = IDDataReader.GetString("ICPsp").ToString();
                tBoxFName.Text = IDDataReader.GetString("fName").ToString();
                tBoxLName.Text = IDDataReader.GetString("lName").ToString();
                tBoxPhone.Text = IDDataReader.GetString("phone").ToString();
                tBoxGender.Text = IDDataReader.GetChar("gender").ToString();
                tBoxEmail.Text = IDDataReader.GetString("email").ToString();
            }

            IDDataReader.Close();
            con.Close();

            tBoxEmail.Enabled = true;
            tBoxFName.Enabled = true;
            tBoxLName.Enabled = true;
            tBoxPhone.Enabled = true;
            tBoxGender.Enabled = true;
            tBoxICPsp.Enabled = true;

        }

        private void tBoxICPsp_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void tBoxFName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void tBoxLName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void tBoxGender_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void tBoxPhone_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void tBoxEmail_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void frmViewLecturer_Load(object sender, EventArgs e)
        {
            string selectIDSQL =
                "SELECT lectID FROM Lecturer";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            IDDataReader = cmd.ExecuteReader();

            if (IDDataReader.HasRows)
            {

                while (IDDataReader.Read())
                {
                    string id = IDDataReader.GetString("lectID").ToString();

                    cboLecturerID.Items.Add(id);
                }
            }

            else
            {
                cboLecturerID.Items.Add("No values in database.");
            }

            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();


        }
    }
}
