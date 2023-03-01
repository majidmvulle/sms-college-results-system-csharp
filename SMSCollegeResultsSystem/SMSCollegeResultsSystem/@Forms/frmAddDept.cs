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
    public partial class frmAddDept : Form
    {
        SMSCollegeResultsSystem._Class.clsDepartment dept;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;

        public frmAddDept()
        {
            InitializeComponent();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHodID.Items.Clear();

            /**********Fill HOD ID Combo Box********************/

            string selectLectIDSQL =
                "SELECT lectID FROM Lecturer WHERE lectID NOT IN (SELECT deanID FROM School) AND lectID NOT IN (SELECT hodID FROM Dept)";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectLectIDSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();


            if (IDDataReader.HasRows)
            {

                while (IDDataReader.Read())
                {
                    string id = IDDataReader.GetString("lectID").ToString();

                    cboHodID.Items.Add(id);
                }
            }



            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();

            /**********End Fill HOD ID Combo Box********************/

            tBoxDeptName.Enabled = true;
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBoxDeptName_TextChanged(object sender, EventArgs e)
        {
            cboHodID.Enabled = true;
        }

        private void frmAddDept_Load(object sender, EventArgs e)
        {
            /**********Fill School Combo Box********************/

            string selectIDSQL =
                "SELECT schName FROM School";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            IDDataReader = cmd.ExecuteReader();


            if (IDDataReader.HasRows)
            {

                while (IDDataReader.Read())
                {
                    string schName = IDDataReader.GetString("schName").ToString();

                    cboSchool.Items.Add(schName);
                }

            }


            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();
            /**********End Fill School Combo Box********************/


            
        }

        private void cboHodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddDept.Enabled = true;
            tBoxFName.Text = "";
            tBoxLName.Text = "";

            string selectSQL =
                 "SELECT * FROM Lecturer WHERE lectID ='" + cboHodID.Text + "'";

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

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            string deanID;

            string selectSQL =
                "SELECT deanID FROM School s WHERE s.schName ='" + cboSchool.Text + "'";

            //ensures no TextBoxes are empty
            if (tBoxDeptName.Text == "" || cboHodID.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxDeptName.Focus(); //set focus to DeptNameTextBox

                return;
            }//end if

            else
            {

                con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(selectSQL, con);

                con.Open();

                IDDataReader = command.ExecuteReader();
                IDDataReader.Read();

                if (IDDataReader.HasRows)
                {
                    deanID = IDDataReader.GetString("deanID").ToString();

                    dept = new _Class.clsDepartment(cboHodID.Text, tBoxDeptName.Text, deanID);

                    try
                    {
                        dept.AddDepartment(cboHodID.Text, tBoxDeptName.Text, deanID);

                        MessageBox.Show("Department (" + tBoxDeptName.Text + ") Added!", "Infomation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tBoxDeptName.Text = "";
                        cboSchool.Text = "";
                        tBoxFName.Text = "";
                        tBoxLName.Text = "";
                        cboHodID.Text = "";
                        tBoxDeptName.Enabled = false;
                        cboHodID.Enabled = false;
                        btnAddDept.Enabled = false;
                        cboHodID.Items.Clear();
                    }

                    catch (Exception exc)
                    {
                        MessageBox.Show("Unable to Add Department!\nError: " + exc.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                IDDataReader.Close();
                con.Close();


            }
           
        }
    }
}
