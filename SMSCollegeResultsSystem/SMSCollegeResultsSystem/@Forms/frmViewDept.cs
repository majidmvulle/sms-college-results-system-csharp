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
    public partial class frmViewDept : Form
    {
        SMSCollegeResultsSystem._Class.clsDepartment dept;


        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader LectDataReader;
        MySqlDataReader DeptDataReader;

        public frmViewDept()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDept.Enabled = true;
            cboHodID.Items.Clear();
            cboDept.Items.Clear();

            /**********Fill Department Combo Box********************/
 
            string selectDeptSQL =
                "SELECT deanID, deptName FROM Dept d WHERE d.deanID = (SELECT deanID FROM School s WHERE s.schName ='"
                +cboSchool.Text+"')";


            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectDeptSQL, con);

            con.Open();

            DeptDataReader = command.ExecuteReader();
   

            if (DeptDataReader.HasRows)
            {

                while (DeptDataReader.Read())
                {
                    string name = DeptDataReader.GetString("deptName").ToString();
                    cboDept.Items.Add(name);
                }

            }


            /* Close the DataReader and The Database Connection */
            DeptDataReader.Close();
            con.Close();

            /**********End Fill Department Combo Box********************/

           

        }

       

        private void cboHOD_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxFName.Enabled = true;
            tBoxLName.Enabled = true;

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
            
            btnSaveChanges.Enabled = true;
        }

        private void frmViewDept_Load(object sender, EventArgs e)
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


            
            /**********Fill HoD Combo Box********************/
           
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
                    cboHodID.Items.Add(id);
                }

            }


            /* Close the DataReader and The Database Connection */
            LectDataReader.Close();
            con.Close();

            /**********End Fill HoD Combo Box********************/
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxDept.Enabled = true;
            cboHodID.Enabled = true;

            tBoxDept.Text = cboDept.Text;
            

            string selectSQL =
              "SELECT lectID, fName, lName FROM Lecturer l WHERE l.lectID = (SELECT hodID FROM Dept d WHERE d.deptName ='"
                + cboDept.Text + "')";

            con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(selectSQL, con);

            con.Open();

            IDDataReader = command.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
                cboHodID.Text = IDDataReader.GetString("lectID").ToString();
                tBoxFName.Text = IDDataReader.GetString("fName").ToString();
                tBoxLName.Text = IDDataReader.GetString("lName").ToString();
            }
            
            IDDataReader.Close();
            con.Close();

            cboHodID.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
             //ensures no TextBoxes are empty
            if (tBoxDept.Text == "")
            {
                //display popup box
                MessageBox.Show("Please fill in all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tBoxDept.Focus(); //set focus to DeptNameTextBox

                return;
            }//end if

            else
            {
                try
                {
                    string selectIDSQL =
                "SELECT deanID FROM Dept WHERE deptName='"+ cboDept.Text +"'";

            con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(selectIDSQL, con);

            con.Open();

            IDDataReader = cmd.ExecuteReader();
            IDDataReader.Read();

            if (IDDataReader.HasRows)
            {
      
                string id = IDDataReader.GetString("deanID").ToString();
                    
                dept = new _Class.clsDepartment(cboHodID.Text, tBoxDept.Text, id);
                dept.View_EditDepartment(cboHodID.Text, tBoxDept.Text, id);


                MessageBox.Show("Department (" + tBoxDept.Text + ") Updated!", "Infomation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                tBoxDept.Text = "";
                cboSchool.Text = "";
                tBoxFName.Text = "";
                tBoxLName.Text = "";
                cboHodID.Text = "";
                cboDept.Text = "";

                cboDept.Items.Clear();
                cboHodID.Items.Clear();

                cboDept.Enabled = false;
                cboHodID.Enabled = false;
                tBoxDept.Enabled = false;

                btnSaveChanges.Enabled = false;       
                
            }

            
            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();

                }

                catch (Exception exc)
                {
                    MessageBox.Show("Unable to Update Department!\nError: " + exc.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void tBoxDept_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }
    }
}
