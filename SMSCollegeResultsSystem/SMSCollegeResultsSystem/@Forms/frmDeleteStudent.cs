using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;

namespace SMSCollegeResultsSystem._Forms
{
    public partial class frmDeleteStudent : Form
    {
        SMSCollegeResultsSystem._Class.clsStudent student;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        
        MySqlConnection con;
        MySqlDataReader IDDataReader;

        public frmDeleteStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboStudID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteStudent.Enabled = true;

            string selectSQL =
                 "SELECT * FROM Student WHERE studID ='" + cboStudID.Text + "'";

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

        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {
            string selectIDSQL =
                "SELECT studID FROM Student";

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

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
             // Display a message box asking users if they want to
            // delete student information.
            if (MessageBox.Show("Are you sure you want to delete (" + tBoxFName.Text + " " + tBoxLName.Text +
                ") ?", "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {


                try
                {

                    student = new _Class.clsStudent(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(), 
                        cboStudID.Text.ToString());

                    student.DeletePerson(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(),
                        cboStudID.Text.ToString());

                    MessageBox.Show("Student (" + tBoxFName.Text + " " + tBoxLName.Text + ") Delete Success!", "Information",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    cboStudID.Items.Remove(cboStudID.Text);
                    tBoxICPsp.Text = "";
                    tBoxFName.Text = "";
                    tBoxLName.Text = "";
                    tBoxPhone.Text = "";
                    tBoxGender.Text = "";
                    tBoxEmail.Text = "";
                    cboStudID.Text = "";
                    btnDeleteStudent.Enabled = false;

                   // cboStudID.Items.Clear();

                }
                catch(Exception exc)
                {
                    MessageBox.Show("Student Deleting Failed!\nError: "+exc.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
