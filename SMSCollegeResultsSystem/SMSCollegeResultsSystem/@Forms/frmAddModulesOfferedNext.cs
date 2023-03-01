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
    public partial class frmAddModulesOfferedNext : Form
    {
        SMSCollegeResultsSystem._Class.clsModule moduleOffered;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader DeptDataReader;
        MySqlDataReader ModDataReader;

        public frmAddModulesOfferedNext()
        {
            InitializeComponent();
        }

        private void frmAddModulesOfferedNext_Load(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDept.Items.Clear();
            cboModule.Items.Clear();

            // **********Fill Department Combo Box********************/

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
                cboDept.Items.Add(name);
            }


            /* Close the DataReader and The Database Connection */
            DeptDataReader.Close();
            con.Close();

            /**********End Fill Department Combo Box********************/

            cboDept.Enabled = true;
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModule.Items.Clear();
            /**********Fill Module Combo Box********************/

            string selectModSQL =
                "SELECT modCode, hodID FROM Module m WHERE m.hodID = (SELECT hodID FROM Dept d WHERE d.deptName ='"
                + cboDept.Text + "')";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectModSQL, con);

            con.Open();

            ModDataReader = command.ExecuteReader();


            if (ModDataReader.HasRows)
            {
                while (ModDataReader.Read())
                {

                    string mod = ModDataReader.GetString("modCode").ToString();
                    cboModule.Items.Add(mod);
                }

            }


            /* Close the DataReader and The Database Connection */
            ModDataReader.Close();
            con.Close();

            /**********End Fill Module Combo Box********************/

            cboModule.Enabled = true;
        }

        private void cboModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSQL =
                 "SELECT modCode, modName, modPre FROM Module WHERE modCode ='" + cboModule.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                tBoxModName.Text = IDDataReader.GetString("modName").ToString();
            }

            IDDataReader.Close();
            con.Close();

            btnAddModule.Enabled = true;
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            string hodID;

            string selectSQL =
                "SELECT hodID FROM Dept d WHERE d.deptName ='" + cboDept.Text + "'";

            //ensures no TextBoxes are empty
            if (cboDept.Text == "" || cboDept.Text == "No values in database.")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

               cboDept.Focus(); //set focus to Dept. Combo Box

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

            try
            {

                moduleOffered = new _Class.clsModule(cboModule.Text, hodID);

                moduleOffered.AddModulesOfferedNext(cboModule.Text, hodID);

                MessageBox.Show("Module (" + cboModule.Text + " - " + tBoxModName.Text+
                    ") will be offered next semester!", "Infomation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                
               
                cboDept.Items.Clear();
                cboModule.Items.Clear();
                
                cboSchool.Text = "";
                
                cboModule.Text = "";
                cboDept.Text = "";

                tBoxModName.Text = "";
                tBoxModName.Enabled = false;

                cboDept.Enabled = false;

                cboModule.Enabled = false;
                btnAddModule.Enabled = false;

            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to Add Module to be Offered!\n\nError: "+exc.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                }
            
            }
       
    
        }
    
    }
}
