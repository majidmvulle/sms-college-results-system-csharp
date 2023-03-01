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
    public partial class frmDeleteResults : Form
    {
        SMSCollegeResultsSystem._Class.clsResult result;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader DeptDataReader;
        MySqlDataReader ModDataReader;

       
        public frmDeleteResults()
        {
            InitializeComponent();
        }

        private void cboMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStud.Items.Clear();

            string selectSQL =
                 "SELECT modCode, modName, modPre FROM Module WHERE modCode ='" + cboMod.Text + "'";

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
                "SELECT studID, modCode FROM StudMod WHERE modCode='" + cboMod.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            ModDataReader = cmd.ExecuteReader();


            if (ModDataReader.HasRows)
            {

                while (ModDataReader.Read())
                {
                    string id = ModDataReader.GetString("studID").ToString();
                    cboStud.Items.Add(id);
                }

            }

 
            /* Close the DataReader and The Database Connection */
            ModDataReader.Close();
            con.Close();


            cboStud.Enabled = true;
        }

        private void cboStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSQL =
                "SELECT * FROM Student WHERE studID ='" + cboStud.Text + "'";

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


            string selectResultsSQL =
                "SELECT * FROM Result WHERE studID ='" + cboStud.Text + "' AND modCode='" +
                cboMod.Text + "'";

            con = new MySqlConnection(conString);
            MySqlCommand comm = new MySqlCommand(selectResultsSQL, con);

            con.Open();

            ModDataReader = comm.ExecuteReader();
            ModDataReader.Read();

            if (ModDataReader.HasRows)
            {
                tBoxMarks.Text = ModDataReader.GetString("marks").ToString();
                tBoxGrade.Text = ModDataReader.GetString("grade").ToString();
            }

            ModDataReader.Close();
            con.Close();

            btnDeleteResults.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDeleteResults_Load(object sender, EventArgs e)
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
            cboMod.Items.Clear();
            cboStud.Items.Clear();

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
                    cboMod.Items.Add(mod);
                }

            }

            /* Close the DataReader and The Database Connection */
            ModDataReader.Close();
            con.Close();

            /**********End Fill Module Combo Box********************/

            cboMod.Enabled = true;
        }

        private void btnDeleteResults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete (" + tBoxFName.Text + " " + tBoxLName.Text +
               ")'s Results?\nThey will not be available via SMS afterwards!", "SMS College Results System",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                 == DialogResult.OK)
            {

                try
                {
                    result = new _Class.clsResult(cboMod.Text.ToString(), cboStud.Text.ToString(),
                        tBoxMarks.Text.ToString(), tBoxGrade.Text.ToString());
                   
                    result.DeleteResults(cboMod.Text.ToString(), cboStud.Text.ToString(),
                        tBoxMarks.Text.ToString(), tBoxGrade.Text.ToString());
                    
                    MessageBox.Show("Student (" + cboStud.Text + ")'s results for (" + cboMod.Text + ") have been deleted!", "Infomation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboSchool.Text = "";

                    cboMod.Text = "";
                    cboMod.Enabled = false;



                    tBoxFName.Text = "";
                    tBoxLName.Text = "";
                    tBoxModName.Text = "";

                    cboStud.Items.Clear();
                    cboDept.Items.Clear();
                    cboMod.Items.Clear();

                    cboDept.Text = "";
                    cboDept.Enabled = false;

                    cboStud.Text = "";
                    cboStud.Enabled = false;

                    tBoxGrade.Text = "";
                    tBoxGrade.Enabled = false;

                    tBoxMarks.Text = "";
                    tBoxMarks.Enabled = false;
                    
                    btnDeleteResults.Enabled = false;
                    cboSchool.Items.Clear();

                    frmDeleteResults_Load(sender, e);

                }
                catch(Exception exc)
                {
                    MessageBox.Show("Unable to Delete Student Results!\nError: "+exc.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDept.Items.Clear();
            cboMod.Items.Clear();

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
    }
}
