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
    public partial class frmRemoveAllModulesOffered : Form
    {
        SMSCollegeResultsSystem._Class.clsModule moduleOffered;

        public frmRemoveAllModulesOffered()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRemoveAllModulesOffered_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            moduleOffered = new _Class.clsModule();

            dataGridView1.DataSource = moduleOffered.GetModulesOfferedNextTable();

            Cursor.Current = Cursors.Default;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they want to
            // delete lecturer information.
            if (MessageBox.Show("Are you sure you want to remove All Modules being offered Next Semester?\n"+
                "Students may not be able to preregister via SMS!\nThis Action is NOT REVERSIBLE!",
                "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {
                try
                {
                    moduleOffered = new _Class.clsModule();

                    moduleOffered.RemoveAllModulesOffered();

                    dataGridView1.DataSource = null;

                    MessageBox.Show("All Modules to be offered Next Semester Have Been Removed Successfully!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Deleting of All Modules Offered Next Semester Failed!\nError: " + exc.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
