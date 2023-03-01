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
    public partial class frmDeRegStudMod : Form
    {
        SMSCollegeResultsSystem._Class.clsStudMod studMod;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader DeptDataReader;
        MySqlDataReader ModDataReader;

        public frmDeRegStudMod()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDept.Items.Clear();
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

        private void frmDeRegStudMod_Load(object sender, EventArgs e)
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

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModCode.Items.Clear();
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
            cboStudID.Items.Clear();

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
            }

            IDDataReader.Close();
            con.Close();


           
            /**************Load Student IDs Who do this Module***********/
            string selectIDSQL =
                "SELECT studID, modCode FROM StudMod WHERE modCode='" + cboModCode.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            ModDataReader = cmd.ExecuteReader();


            if (ModDataReader.HasRows)
            {
 
               while (ModDataReader.Read())
                {
                    string id = ModDataReader.GetString("studID").ToString();
                    cboStudID.Items.Add(id);
             }
               
            }


            /* Close the DataReader and The Database Connection */
            ModDataReader.Close();
            con.Close();


            cboStudID.Enabled = true;
        }

        private void cboStudID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSQL =
                "SELECT * FROM Student WHERE studID ='" + cboStudID.Text + "'";

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

            btnDeRegStudMod.Enabled = true;
        }

        private void btnDeRegStudMod_Click(object sender, EventArgs e)
        {
            try
            {
                studMod = new _Class.clsStudMod(cboModCode.Text.ToString(), cboStudID.Text.ToString());
                
                studMod.DeRegStudMod(cboModCode.Text.ToString(), cboStudID.Text.ToString());

                MessageBox.Show("Student (" + cboStudID.Text + ") has been De-Registered from Module (" + cboModCode.Text + ")!", "Infomation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboSchool.Text = "";
                cboDept.Text = "";
                cboDept.Enabled = false;
                cboModCode.Text = "";
                cboModCode.Enabled = false;

                cboStudID.Text = "";
                cboStudID.Enabled = false;

                tBoxFName.Text = "";
                tBoxLName.Text = "";
                tBoxModName.Text = "";

                cboStudID.Items.Clear();
                cboDept.Items.Clear();

                btnDeRegStudMod.Enabled = false;

            }
            catch(Exception exc)
            {
                MessageBox.Show("Unable to De-Register Student!\nError: "+exc.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
