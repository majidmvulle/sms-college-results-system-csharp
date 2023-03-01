using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GsmComm.GsmCommunication;//GSMComm Library
using GsmComm.PduConverter;//Pdu Converter Library
using GsmComm.PduConverter.SmartMessaging;

namespace SCRS_SMS
{
    public partial class frmMain : Form
    {
        clsResultsSMS results;

        GsmCommMain comm;
        frmConValue dlg;

        private delegate void SetTextCallback(string text);

        //Check if a new SMS has been received
        private bool registerMessageReceived;

        public frmMain()
        {
            InitializeComponent();
            comm = null;
 
        }

        private void frmMain_Minimize(object sender, FormClosingEventArgs e)
        {
            
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
          
                
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private delegate void ConnectedHandler(bool connected);

        private void OnPhoneConnectionChange(bool connected)
        {
            lblConStatus.Visible = !connected;

        }

        private void comm_PhoneConnected(object sender, EventArgs e)
        {
            this.Invoke(new ConnectedHandler(OnPhoneConnectionChange), new object[] { true });
        }


        private void comm_PhoneDisconnected(object sender, EventArgs e)
        {
            this.Invoke(new ConnectedHandler(OnPhoneConnectionChange), new object[] { false });
        }


        private void btnConStatus_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (!comm.IsConnected())
                    Output("Phone is NOT Connected!");
                else
                    Output("Phone is Connected!");

                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Prompt user for connection settings
            int port = GsmCommMain.DefaultPortNumber;
            int baud = GsmCommMain.DefaultBaudRate;
            int time = GsmCommMain.DefaultTimeout;

            btnOff.Enabled = false;

            lblSvcStatus.Text = "SMS System Service NOT Running...";
            lblSvcStatus.ForeColor = Color.Red;

            

            //Create Connection Value Form
            dlg = new frmConValue();

            dlg.StartPosition = FormStartPosition.CenterScreen;

            dlg.setValues(port, baud, time); //Set COM-Port, Baud rate and TimeOut values

            if (dlg.ShowDialog(this) == DialogResult.OK)

                dlg.getValues(out port, out baud, out time);

            else
            {
                Close();
                return;
            }

            Cursor.Current = Cursors.WaitCursor;


            comm = new GsmCommMain(port, baud, time);

            Cursor.Current = Cursors.Default;

            comm.PhoneConnected += new EventHandler(comm_PhoneConnected);

            comm.PhoneDisconnected += new EventHandler(comm_PhoneDisconnected);

            bool retry;

            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(this, "Unable to Open the Port.", "Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        retry = true;
                    else
                    {
                        Close();
                        return;
                    }
                }
            }

            while (retry);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   /* 
             * Display a message box asking a user if they really want to 
             * Exit the system.
             */
            if (MessageBox.Show
                ("Are you sure you want to Exit SCRS - SMS Management?"+
                "\nStudents will not be able to use the SMS Service!",
                "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 
                  MessageBoxDefaultButton.Button2) //Set Focus on 'Cancel' button
                  == DialogResult.OK)
            {
                // Clean up comm object
                if (comm != null)
                {

                    // Close connection to phone
                    if (comm != null && comm.IsOpen())
                        comm.Close();

                    comm = null;
                }

               // dlg.Dispose(); //Memory management, just incase

                Application.Exit();//Quit all running processes of application
            }
        }

        private void Output(string text)
        {
            if (this.tBoxOutput.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(Output);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                tBoxOutput.AppendText(text);
                tBoxOutput.AppendText("\r\n");
            }
        }

        private void Output(string text, params object[] args)
        {
            string msg = string.Format(text, args);
            Output(msg);
        }


        private void btnPhoneID_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                IdentificationInfo info = comm.IdentifyDevice();
                Output("Manufacturer: " + info.Manufacturer);
                Output("Model: " + info.Model);
                Output("Revision: " + info.Revision);
                Output("Serial number: " + info.SerialNumber);
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxOutput.Clear();
        }

        private void btnSignalQ_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Get signal quality
                SignalQualityInfo info = comm.GetSignalQuality();
                Output("Signal Strength: " + info.SignalStrength.ToString());
                Output("Bit Error Rate: " + info.BitErrorRate.ToString());
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }


        private void btnBattCharge_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Get battery charge
                BatteryChargeInfo info = comm.GetBatteryCharge();

                Output("Battery Charging Status: " + info.BatteryChargingStatus.ToString());
                Output("Battery Charge Level: " + info.BatteryChargeLevel.ToString());
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private string GetMessageStorage()
        {
            //Always store SMS in SIM Card
            return PhoneStorageType.Sim;
        }

        private string StatusToString(PhoneMessageStatus status)
        {
            // Map a message status to a string
            string ret;
            switch (status)
            {
                case PhoneMessageStatus.All:
                    ret = "All";
                    break;
                case PhoneMessageStatus.ReceivedRead:
                    ret = "Read";
                    break;
                case PhoneMessageStatus.ReceivedUnread:
                    ret = "Unread";
                    break;
                case PhoneMessageStatus.StoredSent:
                    ret = "Sent";
                    break;
                case PhoneMessageStatus.StoredUnsent:
                    ret = "Unsent";
                    break;
                default:
                    ret = "Unknown (" + status.ToString() + ")";
                    break;
            }
            return ret;
        }


        private void ShowMessage(SmsPdu pdu)
        {
            if (pdu is SmsSubmitPdu)
            {
                // Stored (sent/unsent) message
                SmsSubmitPdu data = (SmsSubmitPdu)pdu;
                Output("SENT/UNSENT SMS");
                Output("To: " + data.DestinationAddress);
                Output("Subject: " + data.UserDataText);
                Output("-------------------------------------------------------------------");
                return;
            }
            if (pdu is SmsDeliverPdu)
            {

                // Received message
                SmsDeliverPdu data = (SmsDeliverPdu)pdu;
                Output("RECEIVED SMS");
                Output("From: " + data.OriginatingAddress);
                Output("Date/Time: " + data.SCTimestamp.ToString());
                Output("Subject: " + data.UserDataText);
                Output("-------------------------------------------------------------------");
                return;
            }
            if (pdu is SmsStatusReportPdu)
            {
                // Status report
                SmsStatusReportPdu data = (SmsStatusReportPdu)pdu;
                Output("STATUS REPORT");
                Output("Recipient: " + data.RecipientAddress);
                Output("Status: " + data.Status.ToString());
                Output("Timestamp: " + data.DischargeTime.ToString());
                Output("Message ref: " + data.MessageReference.ToString());
                Output("-------------------------------------------------------------------");
                return;
            }
            Output("Unknown message type: " + pdu.GetType().ToString());
        }


        private void btnReadAllSMS_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string storage = GetMessageStorage();

            try
            {
                // Read all SMS messages from the storage
                DecodedShortMessage[] messages = comm.ReadMessages(PhoneMessageStatus.All, storage);
                foreach (DecodedShortMessage message in messages)
                {
                    Output(string.Format("Message status = {0}, Location = {1}/{2}",
                        StatusToString(message.Status), message.Storage, message.Index));
                    ShowMessage(message.Data);
                    Output("");
                }
                Output(string.Format("{0,9} messages read.", messages.Length.ToString()));
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private bool Confirmed()
        {
            return (MessageBox.Show("Are you sure you want to delete the SMS(s)?", "SCRS - SMS Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK);
        }

        private void btnDeleteSMSAtIndex_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = int.Parse(tBoxSMSIndex.Text);
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);

                return;
            }

            if (!Confirmed()) return;

            Cursor.Current = Cursors.WaitCursor;

            string storage = GetMessageStorage();
            try
            {
                // Delete the message with the specified index from storage
                comm.DeleteMessage(index, storage);

                Output("SMS Deleted!");
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnDeleteAllSMS_Click(object sender, EventArgs e)
        {
            if (!Confirmed()) return;
            Cursor.Current = Cursors.WaitCursor;

            string storage = GetMessageStorage();
            try
            {
                // Delete all messages from SIM memory
                comm.DeleteMessages(DeleteScope.All, storage);

                Output("All SMS's Deleted!");
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnNotifyEnable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Enable notifications about new received messages
                if (!registerMessageReceived)
                {
                    comm.MessageReceived += new MessageReceivedEventHandler(comm_MessageReceived);
                    registerMessageReceived = true;
                }
                comm.EnableMessageNotifications();
                Output("SMS Notifications Activated.");
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private void comm_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            try
            {
                IMessageIndicationObject obj = e.IndicationObject;
                if (obj is MemoryLocation)
                {
                    MemoryLocation loc = (MemoryLocation)obj;
                    Output(string.Format("New SMS received in storage \"{0}\", index {1}.",
                        loc.Storage, loc.Index));
                    Output("");

                    return;
                }
                if (obj is ShortMessage)
                {
                    ShortMessage msg = (ShortMessage)obj;
                    SmsPdu pdu = comm.DecodeReceivedMessage(msg);
                    Output("New SMS received:");
                    ShowMessage(pdu);
                    Output("");


                    return;
                }
                Output("Error: Unknown notification object!");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }
        }

        //Processes incoming messages if SMS System is turned ON
        private void process_Message(object sender, MessageReceivedEventArgs e)
        {
            string storage = GetMessageStorage();

            IMessageIndicationObject obj = e.IndicationObject;

            MemoryLocation loc = (MemoryLocation)obj;

            DecodedShortMessage[] messages;

            try
            {

                messages = comm.ReadMessages(PhoneMessageStatus.ReceivedUnread, loc.Storage);


            foreach (DecodedShortMessage message in messages)
            {
                SmsPdu smsrec = message.Data;

                SmsDeliverPdu data = (SmsDeliverPdu)smsrec;

                //Get SMS origin phone number
                string originNumber = data.OriginatingAddress;

                string sms_data = null;

                string[] sms_dataArr = null;

                //SMS string splitter
                char[] splitter = { ' ' };

                try
                {
                    /********Automatic Replies******************/

                    string replyWrongFormat = "Wrong SMS Format!\nReply this SMS in this format with your details. \n" +
                        "<RESULTS> <ID> <IC/Passport>. Without <>.";

                    string replyWrongKeyword = "Wrong SMS keyword!\nReply this SMS start with keywords:\nRESULTS or SUBJECTS or PREREG";

                    string replySysInfo = "Get Results, get next sem Subjects, PreRegister." +
                       " Keywords: RESULTS or SUBJECTS or PREREG inc. ID and IC/Passport No.";

                    string signature = "\n-SCRS SMS System-";

                    /*************************************/

                    //Get SMS content
                    sms_data = data.UserDataText;

                    //Split SMS content using string splitter
                    sms_dataArr = sms_data.Split(splitter);
                 
                    //Get first index of string as keyword
                    string keyword = sms_dataArr[0];


                   if(sms_dataArr.Length != 3)
                    {
                        if(keyword != "SCRS" && keyword != "scrs" && keyword != "Scrs")
                        {
                            SmsSubmitPdu ReplyError = new SmsSubmitPdu(replyWrongFormat + signature, originNumber, "");

                            comm.SendMessage(ReplyError);
                        }
                        
                        else
                        {

                            SmsSubmitPdu ReplyInfo = new SmsSubmitPdu(replySysInfo + signature, originNumber, "");

                            comm.SendMessage(ReplyInfo);
                       }
                     }


                    else if(keyword == "RESULTS" || keyword == "results" || keyword == "Results")
                        {
                            results = new clsResultsSMS(sms_dataArr[1], sms_dataArr[2]);

                            string reply = results.giveStudentResults(sms_dataArr[1], sms_dataArr[2]);

                            SmsSubmitPdu replyResults = new SmsSubmitPdu(sms_dataArr[1] + ":\n" + reply + signature, originNumber, "");

                            comm.SendMessage(replyResults);
                        }


                   else if(keyword == "SUBJECTS" || keyword == "Subjects" || keyword == "subjects")
                        {
                           results = new clsResultsSMS(sms_dataArr[1], sms_dataArr[2]);

                           string reply = results.giveSubjectsOfferedNext(sms_dataArr[1], sms_dataArr[2]);

                           SmsSubmitPdu replyResults = new SmsSubmitPdu(sms_dataArr[1] + ":\n" + reply + signature, originNumber, "");

                            comm.SendMessage(replyResults);
                        }

                   else if(keyword == "PREREG" || keyword == "prereg" || keyword == "Prereg")
                        {
                            results = new clsResultsSMS(sms_dataArr[1], sms_dataArr[2]);
                            string reply = results.preRegister(sms_dataArr[1], sms_dataArr[2]);

                            SmsSubmitPdu replySuccess = new SmsSubmitPdu(sms_dataArr[1] + ":\n" + reply + signature, originNumber, "");

                            comm.SendMessage(replySuccess);
                        }

                   else if (keyword == "SCRS" || keyword == "scrs" || keyword == "Scrs")
                        {
                            SmsSubmitPdu ReplyInfo = new SmsSubmitPdu(replySysInfo + signature, originNumber, "");

                            comm.SendMessage(ReplyInfo);
                        }

                        else
                        {
                            SmsSubmitPdu ReplyError = new SmsSubmitPdu(replyWrongKeyword + signature, originNumber, "");

                            comm.SendMessage(ReplyError);
                        }


                   // Delete processed messages from SIM memory
                   comm.DeleteMessages(DeleteScope.ReadAndSent, storage);

                }
                catch (Exception ex)
                {
                    Output(ex.Message);
                }

            }//End of for each

            }
            catch (Exception ex)
            {
                Output(ex.Message);
            }

        }


        private void btnNotifyDisable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Disable message notifications
                comm.DisableMessageNotifications();
                if (registerMessageReceived)
                {
                    comm.MessageReceived -= new MessageReceivedEventHandler(comm_MessageReceived);
                    registerMessageReceived = false;
                }
                Output("SMS Notifications Deactivated!");
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Send an SMS message
                SmsSubmitPdu pdu;

                // The straightforward version
                pdu = new SmsSubmitPdu(tBoxSMSMsg.Text, tBoxPhoneNo.Text);

                // Send the same SMS multiple times if this is set
                int times = chkBoxSendSMSTimes.Checked ? int.Parse(tBoxSendTimes.Text) : 1;


                // If SMS batch mode should be activated, do it before sending the first message

                if (chkBoxEnableBatch.Checked)
                    comm.EnableTemporarySmsBatchMode();

                // Send the message the specified number of times
                for (int i = 0; i < times; i++)
                {
                    comm.SendMessage(pdu);
                    Output("SMS {0} of {1} sent.", i + 1, times);
                    Output("");
                }
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnSMSSendClear_Click(object sender, EventArgs e)
        {
            tBoxPhoneNo.Clear();
            tBoxSMSMsg.Clear();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Enable new received message processing
                if (!registerMessageReceived)
                {
                    comm.MessageReceived += new MessageReceivedEventHandler(process_Message);
                    registerMessageReceived = true;
                }

                comm.EnableMessageNotifications();

                Output("SMS System Service Activated.");
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;

            btnOff.Enabled = true;
            lblSvcStatus.Text = "SMS System Service Running...";
            lblSvcStatus.ForeColor = Color.Blue;
            btnOn.Enabled = true;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Disable message processing
                comm.DisableMessageNotifications();
                if (registerMessageReceived)
                {
                    comm.MessageReceived -= new MessageReceivedEventHandler(comm_MessageReceived);
                    registerMessageReceived = false;
                }
                Output("SMS System Service Deactivated!");
                Output("");
            }
            catch (Exception ex)
            {
                Output("Exception: " + ex);
            }

            Cursor.Current = Cursors.Default;

            btnOn.Enabled = true;
            lblSvcStatus.Text = "SMS System Service NOT Running...";
            lblSvcStatus.ForeColor = Color.Red;
        }
       

    }
}
