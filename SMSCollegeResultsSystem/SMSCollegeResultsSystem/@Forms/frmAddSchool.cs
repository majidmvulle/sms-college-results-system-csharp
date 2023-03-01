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
    public partial class frmAddSchool : Form
    {
        SMSCollegeResultsSystem._Class.clsSchool school;

        public frmAddSchool()
        {
            InitializeComponent();
        }

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;

        private void tBoxSchName_TextChanged(object sender, EventArgs e)
        {
            cboDeanID.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddSchool_Load(object sender, EventArgs e)
        {
            string selectIDSQL =
               "SELECT lectID FROM Lecturer WHERE lectID NOT IN (SELECT deanID FROM School) AND lectID NOT IN (SELECT hodID FROM Dept)";

            con = new MySqlConnection(conString);
            
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            IDDataReader = cmd.ExecuteReader();


            if (IDDataReader.HasRows)
            {

                while (IDDataReader.Read())
                {
                    string id = IDDataReader.GetString("lectID").ToString();
                    
                    cboDeanID.Items.Add(id);
                }

            }



            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();

        }

        private void cboDeanID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddSchool.Enabled = true;

            string selectSQL =
                "SELECT * FROM Lecturer WHERE lectID ='" + cboDeanID.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                tBoxFName.Text = IDDataReader.GetString("fName").ToString();
                tBoxLName.Text = IDDataReader.GetString("lName").ToString();       

            }

            IDDataReader.Close();
            con.Close();
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            //ensures no TextBoxes are empty
            if (tBoxSchName.Text == "" || cboDeanID.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxSchName.Focus(); //set focus to SchNameTextBox

                return;
            }//end if

            else
            {
                 try
                {
                    school = new _Class.clsSchool(tBoxSchName.Text, cboDeanID.Text);

                    school.AddSchool(tBoxSchName.Text, cboDeanID.Text);

                    MessageBox.Show("School ("+tBoxSchName.Text+ ") Added!", "Infomation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tBoxSchName.Text = "";
                    tBoxFName.Text = "";
                    tBoxLName.Text = "";
                    cboDeanID.Text = "";
                    cboDeanID.Enabled = false;
                    btnAddSchool.Enabled = false;

                    cboDeanID.Items.Clear();

                    frmAddSchool_Load(sender, e);
                }

                catch (Exception exc)
                {
                    MessageBox.Show("Unable to Add School!\nError: " + exc.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

    }
}
