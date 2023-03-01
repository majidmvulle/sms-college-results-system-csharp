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
    public partial class frmViewSchool : Form
    {
        SMSCollegeResultsSystem._Class.clsSchool school;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
       
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader LectDataReader;
        

        public frmViewSchool()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboDeanID.Enabled = true;

            cboDeanID.Items.Clear();


            string selectSQL =
                "SELECT deanID, schName, lectID, fName, lName FROM School s, Lecturer l  WHERE s.deanID = l.lectID AND s.schName ='" + cboSchName.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                tBoxFName.Text = IDDataReader.GetString("fName").ToString();
                tBoxLName.Text = IDDataReader.GetString("lName").ToString();
                cboDeanID.Text = IDDataReader.GetString("deanID").ToString();
            }

            IDDataReader.Close();
            con.Close();          
        }

        private void tBoxSchoolName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void cboDean_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;

            string selectSQL =
               "SELECT lectID, fName, lName FROM Lecturer WHERE lectID ='" + cboDeanID.Text + "'";

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

        private void frmViewSchool_Load(object sender, EventArgs e)
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
                    cboSchName.Items.Add(schName);
                }

            }

 
            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();
            /**********End Fill School Combo Box********************/



            /**********Fill Lecturer Combo Box*******************/

            //Only Show Lecturers who are not Deans or HoDs
            string selectLectSQL =
                "SELECT lectID FROM Lecturer WHERE lectID NOT IN (SELECT deanID FROM School) AND lectID NOT IN (SELECT hodID FROM Dept)";

            con = new MySqlConnection(conString);
            MySqlCommand comm = new MySqlCommand(selectLectSQL, con);

            con.Open();

            LectDataReader = comm.ExecuteReader();


            if (LectDataReader.HasRows)
            {
                while (LectDataReader.Read())
                {
                    string id = LectDataReader.GetString("lectID").ToString();
                    cboDeanID.Items.Add(id);
                }
            }


            /* Close the DataReader and The Database Connection */
            LectDataReader.Close();
            con.Close();

            /**********End Fill Lecturer Combo Box********************/


            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {               
                school = new _Class.clsSchool(cboSchName.Text.ToString(), cboDeanID.Text.ToString());

                school.View_EditSchool(cboSchName.Text.ToString(), cboDeanID.Text.ToString());

                MessageBox.Show("School (" + cboSchName.Text + ") update Success!", "Information",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                tBoxFName.Text = "";
                cboSchName.Text = "";
                cboDeanID.Text = "";
                tBoxLName.Text = "";

                cboDeanID.Items.Clear();
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("School information update Failed!\nError: " +ex.Message, "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
