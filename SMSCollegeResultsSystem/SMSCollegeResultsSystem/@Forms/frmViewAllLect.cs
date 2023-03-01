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
    public partial class frmViewAllLect : Form
    {
        SMSCollegeResultsSystem._Class.clsLecturer lecturer;

        public frmViewAllLect()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmViewAllLect_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            lecturer = new _Class.clsLecturer();

            dataGridView1.DataSource = lecturer.GetLecturerTable();

            Cursor.Current = Cursors.Default;
        }
    }
}
