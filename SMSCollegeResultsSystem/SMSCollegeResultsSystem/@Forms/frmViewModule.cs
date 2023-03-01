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
    public partial class frmViewModule : Form
    {
        SMSCollegeResultsSystem._Class.clsModule module;


        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader ModDataReader;
        MySqlDataReader DeptDataReader;

        public frmViewModule()
        {
            InitializeComponent();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeptName.Items.Clear();
            cboModCode.Items.Clear();
            cboModPrereq.Items.Clear();

            /**********Fill Department Combo Box********************/
         
            string selectDeptSQL =
                "SELECT deanID, deptName FROM Dept d WHERE d.deanID = (SELECT deanID FROM School s WHERE s.schName ='"
                + cboSchool.Text + "')";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectDeptSQL, con);

            con.Open();

            DeptDataReader = command.ExecuteReader();
            DeptDataReader.Read();

            if (DeptDataReader.HasRows)
            {
                string name = DeptDataReader.GetString("deptName").ToString();
                cboDeptName.Items.Add(name);
            }


            /* Close the DataReader and The Database Connection */
            DeptDataReader.Close();
            con.Close();

            /**********End Fill Department Combo Box********************/

            cboDeptName.Enabled = true;

        }

        private void cboModCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModPrereq.Items.Clear();

            string selectSQL =
                 "SELECT modCode, modName, modPre FROM Module WHERE modCode ='" + cboModCode.Text + "' ORDER BY modCode";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                tBoxModName.Text = IDDataReader.GetString("modName").ToString();
                cboModPrereq.Text = IDDataReader.GetString("modPre").ToString();
            }

            IDDataReader.Close();
            con.Close();

            /**********Fill Module Prereq Combo Box********************/

            string selectModPreSQL =
                "SELECT modCode, hodID FROM Module m WHERE m.hodID = (SELECT hodID FROM Dept d WHERE d.deptName ='"
                + cboDeptName.Text + "')";


            con = new MySqlConnection(conString);
            MySqlCommand comm = new MySqlCommand(selectModPreSQL, con);

            con.Open();

            ModDataReader = comm.ExecuteReader();


            if (ModDataReader.HasRows)
            {
                while (ModDataReader.Read())
                {

                    string mod = ModDataReader.GetString("modCode").ToString();
                    cboModPrereq.Items.Add(mod);
                }

                cboModPrereq.Items.Add("NIL");
            }


            /* Close the DataReader and The Database Connection */
            ModDataReader.Close();
            con.Close();

            /**********End Fill Module Prereq Combo Box********************/


            
            tBoxModName.Enabled = true;
            cboModPrereq.Enabled = true;
        }

        private void tBoxModName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void cboModPrereq_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void frmViewModule_Load(object sender, EventArgs e)
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

        private void cboDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModCode.Items.Clear();
            cboModPrereq.Items.Clear();

            /**********Fill Module Combo Box********************/

            string selectModSQL =
                "SELECT modCode, hodID FROM Module m WHERE m.hodID = (SELECT hodID FROM Dept d WHERE d.deptName ='"
                + cboDeptName.Text + "')";


            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectModSQL, con);

            con.Open();

            ModDataReader = command.ExecuteReader();


            if (ModDataReader.HasRows)
            {
                while (ModDataReader.Read())
                {

                    string mod = ModDataReader.GetString("modCode").ToString();
                    cboModCode.Items.Add(mod);
                }

            }


            /* Close the DataReader and The Database Connection */
            ModDataReader.Close();
            con.Close();

            /**********End Fill Module Combo Box********************/
            cboModCode.Enabled = true;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //ensures no TextBoxes are empty
            if (tBoxModName.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxModName.Focus(); //set focus to DeptNameTextBox

                return;
            }//end if

            else
            {
                try
                {
                    string selectIDSQL =
                "SELECT hodID FROM Dept WHERE deptName='" + cboDeptName.Text + "'";

                    con = new MySqlConnection(conString);
                    MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

                    con.Open();

                    IDDataReader = cmd.ExecuteReader();
                    IDDataReader.Read();

                    if (IDDataReader.HasRows)
                    {

                        string hod = IDDataReader.GetString("hodID").ToString();

                        module = new _Class.clsModule(cboModCode.Text, tBoxModName.Text, cboModPrereq.Text, hod);

                        module.View_EditModule(cboModCode.Text, tBoxModName.Text, cboModPrereq.Text, hod);

                        MessageBox.Show("Module (" + cboModCode.Text + " - " +
                            tBoxModName.Text + ") Updated!", "Infomation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cboSchool.Text = "";
                        cboDeptName.Text = "";
                        cboModCode.Text = "";
                        tBoxModName.Text = "";
                        cboModPrereq.Text = "";

                        cboDeptName.Enabled = false;
                        cboModCode.Enabled = false;
                        tBoxModName.Enabled = false;
                        cboModPrereq.Enabled = false;

                        cboDeptName.Items.Clear();
                        cboModCode.Items.Clear();
                        cboModPrereq.Items.Clear();

                        btnSaveChanges.Enabled = false;

                    }


                    /* Close the DataReader and The Database Connection */
                    IDDataReader.Close();
                    con.Close();

                }

                catch (Exception exc)
                {
                    MessageBox.Show("Unable to Update Module!\nError: " + exc.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
