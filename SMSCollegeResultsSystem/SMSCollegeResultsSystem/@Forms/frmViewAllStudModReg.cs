using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMSCollegeResultsSystem._Forms
{
    public partial class frmViewAllStudModReg : Form
    {
        SMSCollegeResultsSystem._Class.clsStudent student;

        public frmViewAllStudModReg()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they want to
            // delete information.
            if (MessageBox.Show("Are you sure you want to delete All Students' Module Registrations?\n\nThis Action is NOT REVERSIBLE!",
                "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {
                try
                {
                    student = new _Class.clsStudent();

                    student.DeleteAllStudMod();

                    dataGridView1.DataSource = null;

                    MessageBox.Show("All Students' Module Registrations Have Been Deleted Successfully!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Deleting of All Registrations Failed!\nError: " + exc.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmViewAllStudModReg_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            student = new _Class.clsStudent();

            dataGridView1.DataSource = student.GetStudModTable();

            Cursor.Current = Cursors.Default;
        }
    }
}
