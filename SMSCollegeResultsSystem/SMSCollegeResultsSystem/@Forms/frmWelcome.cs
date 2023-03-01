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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        int p;              //Progressbar Value
       
        frmMainMenu frmMainmenu = new frmMainMenu();

        private void timer1_Tick(object sender, EventArgs e)
        {
            p += 2;

            if (p > 100)
            {
                this.Hide();

               
                this.timer1.Enabled = false;

                //  this.Close();
                frmMainmenu.Show();
                return;

            }
            this.WelcomeProgressBar.Value = p;



        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
        }
    }
}
