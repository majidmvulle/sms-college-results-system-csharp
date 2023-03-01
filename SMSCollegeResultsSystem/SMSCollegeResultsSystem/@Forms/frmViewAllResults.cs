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
    public partial class frmViewAllResults : Form
    {
        SMSCollegeResultsSystem._Class.clsResult results;

        public frmViewAllResults()
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
            if (MessageBox.Show("Are you sure you want to delete All Students' Results?\n\nThis Action is NOT REVERSIBLE!",
                "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {
                try
                {
                    results = new _Class.clsResult();

                    results.DeleteAllResults();

                    dataGridView1.DataSource = null;

                    MessageBox.Show("All Students' Results Have Been Deleted Successfully!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Deleting of All Results Failed!\nError: " + exc.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmViewAllResults_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            results = new _Class.clsResult();

            dataGridView1.DataSource = results.GetResultsTable();

            Cursor.Current = Cursors.Default;
        }
    }
}
