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
    public partial class frmViewStudent : Form
    {
        SMSCollegeResultsSystem._Class.clsStudent student;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
       

        public frmViewStudent()
        {
            InitializeComponent();
        }

    private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //ensures no TextBoxes are empty
            if (tBoxPhone.Text == "" || tBoxFName.Text == "" || 
                tBoxLName.Text == "" || tBoxEmail.Text == "" ||
                tBoxGender.Text == "" || tBoxICPsp.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxFName.Focus(); //set focus to FirstNameTextBox

                return;
            }//end if

            //if first name format invalid, show message
            if (!Regex.Match(tBoxFName.Text,
                "^[A-Z][a-zA-Z]*$").Success)
            {
                //first name was incorrect
                MessageBox.Show("Invalid First name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxFName.Focus();
                return;
            }//end if

            //if last name format invalid, show message
            if (!Regex.Match(tBoxLName.Text,
                "^[A-Z][a-zA-Z]*$").Success)
            {
                //last name was incorrect
                MessageBox.Show("Invalid Last name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxLName.Focus();
                return;
            }//end if

            //if phone number format invalid, show message
            if (!Regex.Match(tBoxPhone.Text, @"^\d{10}$").Success)
            {
                //phone was incorrect
                MessageBox.Show("Invalid Phone Number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxPhone.Focus();

                return;

            }//end 

            else
            {
                try
                {
                    student = new _Class.clsStudent(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(),
                        cboStudID.Text.ToString());

                    student.View_EditPerson(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(),
                        cboStudID.Text.ToString());

                    MessageBox.Show("Student (" +cboStudID.Text+ ") update Success!", "Information",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    cboStudID.Text = "";
                    tBoxFName.Text = "";
                    tBoxLName.Text = "";
                    tBoxGender.Text = "";
                    tBoxICPsp.Text = "";
                    tBoxPhone.Text = "";
                    tBoxEmail.Text = "";

                    tBoxEmail.Enabled = false;
                    tBoxFName.Enabled = false;
                    tBoxLName.Enabled = false;
                    tBoxPhone.Enabled = false;
                    tBoxGender.Enabled = false;
                    tBoxICPsp.Enabled = false;

                    btnSaveChanges.Enabled = false;
                }

                catch(Exception exc)
                {
                    MessageBox.Show("Student information update Failed!\nError: "+exc.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboStudID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxEmail.Enabled = true;
            tBoxFName.Enabled = true;
            tBoxLName.Enabled = true;
            tBoxPhone.Enabled = true;
            tBoxGender.Enabled = true;
            tBoxICPsp.Enabled = true;
        
            string selectSQL =
                 "SELECT * FROM Student WHERE studID ='" +cboStudID.Text + "'";

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
        }

      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void frmViewStudent_Load(object sender, EventArgs e)
        {
            string selectIDSQL =
                "SELECT studID FROM Student ORDER BY studID";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            IDDataReader = cmd.ExecuteReader();

           
            if (IDDataReader.HasRows)
            {

                while (IDDataReader.Read())
                {
                    string id = IDDataReader.GetString("studID").ToString();
                   
                    cboStudID.Items.Add(id);
                }
            }
                
  
               /* Close the DataReader and The Database Connection */
            IDDataReader.Close();   
            con.Close();


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
    }
}
