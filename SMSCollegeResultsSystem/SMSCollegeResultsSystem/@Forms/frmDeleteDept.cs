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
    public partial class frmDeleteDept : Form
    { 
        SMSCollegeResultsSystem._Class.clsDepartment dept;

        //Read connection string from application settings file
        string conString = ConfigurationManager.AppSettings["ConnectionString"];
        MySqlConnection con;
        MySqlDataReader IDDataReader;
        MySqlDataReader DeptDataReader;


        public frmDeleteDept()
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
                cboDept.Items.Add(name);
            }



            /* Close the DataReader and The Database Connection */
            DeptDataReader.Close();
            con.Close();

            /**********End Fill Department Combo Box********************/

            cboDept.Enabled = true;   
        }

        private void cboDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                tBoxHodID.Text = IDDataReader.GetString("lectID").ToString();
                tBoxFName.Text = IDDataReader.GetString("fName").ToString();
                tBoxLName.Text = IDDataReader.GetString("lName").ToString();
            }

            IDDataReader.Close();
            con.Close();

            btnDeleteDept.Enabled = true;
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they want to
            // delete department information.
            if (MessageBox.Show("Are you sure you want to delete Department (" + cboDept.Text +
                ") ?\n\n All Modules under this Department will not be available after!", "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
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
                    
                dept = new _Class.clsDepartment(tBoxHodID.Text, cboDept.Text, id);
                dept.DeleteDepartment(tBoxHodID.Text, cboDept.Text, id);


                MessageBox.Show("Department (" + cboDept.Text + ") Deleted!", "Infomation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboDept.Text = "";
                cboSchool.Text = "";
                tBoxFName.Text = "";
                tBoxLName.Text = "";
                tBoxHodID.Text = "";
                
                 cboDept.Items.Remove(cboDept.Text);       
                        cboDept.Text = "";

                cboDept.Enabled = false;
       
                
                btnDeleteDept.Enabled = false;
            }

            
            /* Close the DataReader and The Database Connection */
            IDDataReader.Close();
            con.Close();

                }   catch (Exception ex)
                {
                    MessageBox.Show("Department information Delete Failed!\nError: " + ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        
    }
        private void frmDeleteDept_Load(object sender, EventArgs e)
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
