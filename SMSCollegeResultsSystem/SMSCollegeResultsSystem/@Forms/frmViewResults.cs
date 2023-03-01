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
    public partial class frmViewResults : Form
    {
        SMSCollegeResultsSystem._Class.clsResult result;

        SMSCollegeResultsSystem._Class.clsResultsCalc calcResult;
        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader DeptDataReader;
        MySqlDataReader ModDataReader;

        string grade;

        public frmViewResults()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void tBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMod.Items.Clear();

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

        private void frmViewResults_Load(object sender, EventArgs e)
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
            cboDept.Items.Clear();
            cboMod.Items.Clear();
            cboStudID.Items.Clear();


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

        private void cboMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStudID.Items.Clear();

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


            string selectResultsSQL =
                "SELECT * FROM Result WHERE studID ='" + cboStudID.Text + "' AND modCode='"+
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

            tBoxMarks.Enabled = true;
        }

        private void tBoxMarks_TextChanged(object sender, EventArgs e)
        {
            btnGetGrade.Enabled = true;
        }

        private void btnGetGrade_Click(object sender, EventArgs e)
        {
            double totalMark;

            bool isNumber = false;

            try
            {

                Convert.ToDouble(tBoxMarks.Text);

                isNumber = true;
            }
            catch
            {
                isNumber = false;
            }


            if (isNumber && tBoxMarks.Text != "")
            {
                double marks = Convert.ToDouble(tBoxMarks.Text);

                if (marks >= 0 && marks < 101)
                {

                    totalMark = Convert.ToDouble(tBoxMarks.Text);

                    calcResult = new _Class.clsResultsCalc(totalMark);
                    grade = calcResult.calcGrade();

                    tBoxGrade.Text = grade;

                    btnSaveChanges.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Invalid Marks!\n\nMarks should be EITHER 0 or higher OR 100 or lower.",
                        "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSaveChanges.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Marks!\n\nEnter Numbers Only.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveChanges.Enabled = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {
                result = new _Class.clsResult(cboMod.Text.ToString(), cboStudID.Text.ToString(),
                    tBoxMarks.Text.ToString(), grade);

                result.View_EditResults(cboMod.Text.ToString(), cboStudID.Text.ToString(),
                    tBoxMarks.Text.ToString(), grade);
              
                MessageBox.Show
                    ("Student (" + cboStudID.Text + ")'s results for (" + cboMod.Text + ") have been updated!", 
                    "Infomation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboSchool.Text = "";

                cboMod.Text = "";
                cboMod.Enabled = false;



                tBoxFName.Text = "";
                tBoxLName.Text = "";
                tBoxModName.Text = "";


                cboStudID.Items.Clear();
                cboDept.Items.Clear();

                cboDept.Text = "";
                cboDept.Enabled = false;

                cboStudID.Text = "";
                cboStudID.Enabled = false;

                tBoxGrade.Text = "";
                tBoxGrade.Enabled = false;

                tBoxMarks.Text = "";
                tBoxMarks.Enabled = false;
                btnSaveChanges.Enabled = false;
                btnGetGrade.Enabled = false;
                

            }
            catch(Exception exc)
            {
                MessageBox.Show("Unable to Update Student Results!\nError: "+exc.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
    }
}
