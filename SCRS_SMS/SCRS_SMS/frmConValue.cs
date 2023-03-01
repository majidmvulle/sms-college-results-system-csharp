using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GsmComm.GsmCommunication;

namespace SCRS_SMS
{
    public partial class frmConValue : Form
    {
      
        private int port;
        private int baud;
        private int time;

        public frmConValue()
        {
            InitializeComponent();
        }

        public bool enterSettings()
        {
            int newPort;
            int newBaud;
            int newTime;

            try
            {
                newPort = int.Parse(cboPort.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Invalid COM-Port number.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboPort.Focus();

                return false;
            }

            try
            {
                newBaud = int.Parse(cboBaud.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Invalid Baud Rate.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboBaud.Focus();

                return false;
            }

            try
            {
                newTime = int.Parse(cboTime.Text);
            }

            catch (Exception)
            {
                MessageBox.Show(this, "Invalid timeout value.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                cboTime.Focus();
               
                return false;
            }

            this.port = newPort;
            this.baud = newBaud;
            this.time = newTime;


            return true;
        }

        public void setValues(int port, int baud, int time)
        {
            this.time = time;
            this.baud = baud;
            this.time = time;

        }

        public void getValues(out int port, out int baud, out int time)
        {
            port = this.port;
            baud = this.baud;
            time = this.time;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!enterSettings())
                
                return;

            Cursor.Current = Cursors.WaitCursor;

            GsmCommMain comm = new GsmCommMain(port, baud, time);

            

            try
            {
                comm.Open();

                while (!comm.IsConnected())
                {
                    Cursor.Current = Cursors.Default;

                    if (MessageBox.Show("No Phone Connected!", "SCRS - Connection",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    {
                        comm.Close();
                        return;
                    }

                    Cursor.Current = Cursors.WaitCursor;
                }

                comm.Close();
            }

            catch (Exception exc)
            {
                MessageBox.Show("Connection Error: " + exc, "SCRS - Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            comm.Open();
            
            IdentificationInfo info = comm.IdentifyDevice(); //Identify the device 

            MessageBox.Show("Successfully Connected to Phone: \n\nManufacturer: " + info.Manufacturer + ".\nModel: " 
                + info.Model + ".",
                "SCRS - Connection", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            comm.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!enterSettings())
            {
               
            }

            DialogResult = DialogResult.OK;
            
        }

        private void frmConValue_Load(object sender, EventArgs e)
        {
            cboPort.Items.Add("1");
            cboPort.Items.Add("2");
            cboPort.Items.Add("3");
            cboPort.Items.Add("4");
            cboPort.Text = port.ToString();


            cboBaud.Items.Add("9600");
            cboBaud.Items.Add("19200");
            cboBaud.Items.Add("38400");
            cboBaud.Items.Add("57600");
            cboBaud.Items.Add("115200");
            cboBaud.Text = baud.ToString();


            cboTime.Items.Add("150");
            cboTime.Items.Add("300");
            cboTime.Items.Add("600");
            cboTime.Items.Add("900");
            cboTime.Items.Add("1200"); 
            cboTime.Text = time.ToString();


            btnTest.Focus();
        }
    }
}
