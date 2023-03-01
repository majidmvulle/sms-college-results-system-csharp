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
    public partial class frmDeleteModule : Form
    {
        SMSCollegeResultsSystem._Class.clsModule module;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader ModDataReader;
        MySqlDataReader DeptDataReader;

        public frmDeleteModule()
        {
            InitializeComponent();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeptName.Items.Clear();
            cboModCode.Items.Clear();

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

        private void cboDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModCode.Items.Clear();

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

        private void cboModCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSQL =
                 "SELECT modCode, modName, modPre FROM Module WHERE modCode ='" + cboModCode.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                tBoxModName.Text = IDDataReader.GetString("modName").ToString();
                tBoxModPrereq.Text = IDDataReader.GetString("modPre").ToString();
            }

            IDDataReader.Close();
            con.Close();


            btnDeleteModule.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they want to
            // delete module information.
            if (MessageBox.Show("Are you sure you want to delete Module (" + cboModCode.Text +
                " - " + tBoxModName.Text + ") ?\n\n All Students' results under this Module will not be available after!", "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {

                try
                {
                    string selectIDSQL =
               "SELECT deanID FROM Dept WHERE deptName='" + cboDeptName.Text + "'";

                    con = new MySqlConnection(conString);
                    MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

                    con.Open();

                    IDDataReader = cmd.ExecuteReader();
                    IDDataReader.Read();

                    if (IDDataReader.HasRows)
                    {

                        string id = IDDataReader.GetString("deanID").ToString();

                        module = new _Class.clsModule(cboModCode.Text, tBoxModName.Text, tBoxModPrereq.Text, id);

                        module.DeleteModule(cboModCode.Text, tBoxModName.Text, tBoxModPrereq.Text, id);

                        MessageBox.Show("Module (" + cboModCode.Text +
                " - " + tBoxModName.Text + ") Deleted!", "Infomation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        cboDeptName.Text = "";
                        cboSchool.Text = "";
                        tBoxModName.Text = "";
                        cboModCode.Text = "";
                        tBoxModPrereq.Text = "";


                        cboDeptName.Enabled = false;
                        tBoxModName.Enabled = false;
                        cboModCode.Enabled = false;
                        tBoxModPrereq.Enabled = false;

                        cboDeptName.Items.Clear();
                        cboModCode.Items.Clear();

                        cboModCode.Items.Remove(cboModCode.Text);

                        btnDeleteModule.Enabled = false;


                    }


                    /* Close the DataReader and The Database Connection */
                    IDDataReader.Close();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Department information Delete Failed!\nError: " + ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmDeleteModule_Load(object sender, EventArgs e)
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
