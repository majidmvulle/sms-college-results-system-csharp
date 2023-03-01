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
    public partial class frmViewAllModules : Form
    {
        SMSCollegeResultsSystem._Class.clsModule module;

        public frmViewAllModules()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmViewAllModules_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            module = new _Class.clsModule();

            dataGridView1.DataSource = module.GetModulesTable();

            Cursor.Current = Cursors.Default;
        }

    }
}
