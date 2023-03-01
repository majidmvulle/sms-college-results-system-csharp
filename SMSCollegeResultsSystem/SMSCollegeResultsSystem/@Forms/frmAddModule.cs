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
    public partial class frmAddModule : Form
    {
        SMSCollegeResultsSystem._Class.clsModule module;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader DeptDataReader;
        MySqlDataReader ModDataReader;

        public frmAddModule()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddModule_Load(object sender, EventArgs e)
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

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeptName.Items.Clear();
            cboModPrereq.Items.Clear();
            /**********Fill Department Combo Box********************/


            string selectDeptSQL =
                "SELECT hodID, deanID, deptName FROM Dept d WHERE d.deanID = (SELECT deanID FROM School s WHERE s.schName ='"
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

        private void cboDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModPrereq.Items.Clear();

            tBoxModCode.Enabled = true;

            /**********Fill Module Prereq Combo Box********************/
        
            string selectModPreSQL =
                "SELECT modCode, hodID FROM Module m WHERE m.hodID = (SELECT hodID FROM Dept d WHERE d.deptName ='"
                + cboDeptName.Text + "')";


            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectModPreSQL, con);

            con.Open();

            ModDataReader = command.ExecuteReader();


            if (ModDataReader.HasRows)
            {
                while (ModDataReader.Read())
                {

                    string mod = ModDataReader.GetString("modCode").ToString();
                    cboModPrereq.Items.Add(mod);
                }
                cboModPrereq.Items.Add("NIL");
            }

            else
            {
                cboModPrereq.Items.Add("NIL");
            }

            /* Close the DataReader and The Database Connection */
            ModDataReader.Close();
            con.Close();

            /**********End Fill Module Prereq Combo Box********************/

        }

        private void tBoxModCode_TextChanged(object sender, EventArgs e)
        {
            tBoxModName.Enabled = true;
        }

        private void tBoxModName_TextChanged(object sender, EventArgs e)
        {
            cboModPrereq.Enabled = true;
        }

        private void cboModPrereq_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddModule.Enabled = true;
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            string hodID;

            string selectSQL =
                "SELECT hodID FROM Dept d WHERE d.deptName ='" + cboDeptName.Text + "'";

            //ensures no TextBoxes are empty
            if (cboDeptName.Text == "" || cboSchool.Text == "" || 
                tBoxModCode.Text == "" || tBoxModName.Text == "" || 
                cboModPrereq.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxModCode.Focus(); //set focus to modCodeTextBox

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
                    hodID = IDDataReader.GetString("hodID").ToString();

                    module = new _Class.clsModule(tBoxModCode.Text, tBoxModName.Text, cboModPrereq.Text, hodID);

                    try
                    {
                        module.AddModule(tBoxModCode.Text, tBoxModName.Text, cboModPrereq.Text, hodID);

                        MessageBox.Show("Module (" + tBoxModCode.Text + " - " +
                            tBoxModName.Text + ") Added!", "Infomation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboSchool.Text = "";
                        cboDeptName.Text = "";
                        tBoxModName.Text = "";
                        tBoxModCode.Text = "";
                        cboModPrereq.Text = "";

                        cboDeptName.Enabled = false;
                        tBoxModCode.Enabled = false;
                        tBoxModName.Enabled = false;
                        cboModPrereq.Enabled = false;

                        cboDeptName.Items.Clear();
                        cboModPrereq.Items.Clear();

                        btnAddModule.Enabled = false;
                        
                    }

                    catch (Exception exc)
                    {
                        MessageBox.Show("Unable to Add Module!\nError" + exc.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                IDDataReader.Close();
                con.Close();


            }
        }
    }
}
