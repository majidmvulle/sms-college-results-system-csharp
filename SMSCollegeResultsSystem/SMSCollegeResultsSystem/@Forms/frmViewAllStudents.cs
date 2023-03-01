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
    public partial class frmViewAllStudents : Form
    {
        SMSCollegeResultsSystem._Class.clsStudent student;

        public frmViewAllStudents()
        {
            InitializeComponent();
        }


        private void frmViewAllStudents_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            student = new _Class.clsStudent();

            dataGridView1.DataSource = student.GetStudentsTable();

            Cursor.Current = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
