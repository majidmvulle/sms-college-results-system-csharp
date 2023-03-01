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
    public partial class frmDeleteLecturer : Form
    {
        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;

        SMSCollegeResultsSystem._Class.clsLecturer lecturer;
        public frmDeleteLecturer()
        {
            InitializeComponent();
        }

        private void cboStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteLecturer.Enabled = true;

            string selectSQL =
                 "SELECT * FROM Lecturer WHERE lectID ='" + cboStaffID.Text + "'";

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

        private void frmDeleteLecturer_Load(object sender, EventArgs e)
        {
            //Only Show Lecturers who are not Deans or HoDs
            string selectIDSQL =
                "SELECT lectID FROM Lecturer l WHERE l.lectID NOT IN (SELECT deanID FROM School s) AND l.lectID NOT IN (SELECT hodID FROM Dept d)";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            IDDataReader = cmd.ExecuteReader();


            if (IDDataReader.HasRows)
            {
                while (IDDataReader.Read())
                {
                    string id = IDDataReader.GetString("lectID").ToString();

                    cboStaffID.Items.Add(id);
                }
            }

            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();
        }

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they want to
            // delete lecturer information.
            if (MessageBox.Show("Are you sure you want to delete (" + tBoxFName.Text + " " + tBoxLName.Text +
                ") ?", "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {

                try
                {

                    lecturer = new _Class.clsLecturer(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(),
                        cboStaffID.Text.ToString());

                    lecturer.DeletePerson(tBoxICPsp.Text.ToString(), tBoxFName.Text.ToString(),
                        tBoxLName.Text.ToString(), tBoxPhone.Text.ToString(),
                        tBoxGender.Text.ToString(), tBoxEmail.Text.ToString(),
                        cboStaffID.Text.ToString());

                    MessageBox.Show("Lecturer (" + tBoxFName.Text + " " + tBoxLName.Text + ") Delete Success!", "Information",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboStaffID.Items.Remove(cboStaffID.Text);
                    tBoxICPsp.Text = "";
                    tBoxFName.Text = "";
                    tBoxLName.Text = "";
                    tBoxPhone.Text = "";
                    tBoxGender.Text = "";
                    tBoxEmail.Text = "";
                    cboStaffID.Text = "";

                   // cboStaffID.Items.Clear();

                    btnDeleteLecturer.Enabled = false;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lecturer Deleting Failed!\nError: "+ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}