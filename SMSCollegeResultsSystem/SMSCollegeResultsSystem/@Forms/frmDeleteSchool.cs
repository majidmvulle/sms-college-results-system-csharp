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
    public partial class frmDeleteSchool : Form
    {
        SMSCollegeResultsSystem._Class.clsSchool school;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;

        public frmDeleteSchool()
        {
            InitializeComponent();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteSchool.Enabled = true;

            string selectSQL =
               "SELECT deanID, schName, lectID, fName, lName FROM School s, Lecturer l  WHERE s.deanID = l.lectID AND s.schName ='" + cboSchool.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                tBoxFName.Text = IDDataReader.GetString("fName").ToString();
                tBoxLName.Text = IDDataReader.GetString("lName").ToString();
                tBoxDeanID.Text = IDDataReader.GetString("deanID").ToString();
            }

            IDDataReader.Close();
            con.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteSchool_Click(object sender, EventArgs e)
        {
             // Display a message box asking users if they want to
            // delete school information.
            if (MessageBox.Show("Are you sure you want to delete School (" + cboSchool.Text +
                ") ?\n\n All Depts. & Modules under this School will not be available after!", "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {

                try
                {

                    school = new _Class.clsSchool(cboSchool.Text.ToString(), tBoxDeanID.Text.ToString());

                    school.DeleteSchool(cboSchool.Text.ToString(), tBoxDeanID.Text.ToString());

                    MessageBox.Show("School (" + cboSchool.Text + ") Delete Success!", "Information",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tBoxFName.Text = "";
                    cboSchool.Text = "";
                    tBoxDeanID.Text = "";
                    tBoxLName.Text = "";
                    cboSchool.Items.Remove(cboSchool.Text);
                    cboSchool.Items.Clear();

                    frmDeleteSchool_Load(sender, e);


                }

                catch (Exception ex)
                {
                    MessageBox.Show("School information Delete Failed!\nError: " + ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnDeleteSchool.Enabled = false;

            }
        }

        private void frmDeleteSchool_Load(object sender, EventArgs e)
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
    }
}
