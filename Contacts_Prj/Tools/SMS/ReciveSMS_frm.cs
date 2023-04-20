using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Contacts_Prj.Properties;


namespace Contacts_Prj
{
    public partial class ReciveSMS_frm : Form
    {
        public ReciveSMS_frm()
        {
            InitializeComponent();
        }


        public static int Comm_Port = 0;
        public static int Comm_BaudRate = 0;
        public static int Comm_TimeOut = 0;
        //public static GsmCommMain comm;

        DataTable dt = new DataTable();
        private delegate void SetTextCallback(string text);
        private void buttonItem_ListView_Click(object sender, EventArgs e)
        {
            ShowListRcvSMS();
        }

        private void ShowListRcvSMS()
        {
            int i = 0;
            if (radiobtn_rbmsgsim.Checked) i = 0;
            if (radiobtn_rbmsgsim.Checked) i = 1;
            if (radiobtn_rbmsgsim.Checked && radiobtn_rbmsgsim.Checked) i = 2;

            SMSClass.ReciveSMS(lstInbox, i);
            //if (dataGridView_ReciveSMS.RowCount > 0)
            //    dt.Clear();

            //Cursor.Current = Cursors.WaitCursor;
            //string storage = GetMessageStorage();
            //try
            //{
            //    Comm_Port = Global_Cls.Comm_Port;
            //    Comm_BaudRate = Global_Cls.Comm_BaudRate;
            //    Comm_TimeOut = Global_Cls.Comm_TimeOut;

            //    comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);
            //    comm.Open();
            //    DecodedShortMessage[] messages = comm.ReadMessages(PhoneMessageStatus.All, GetMessageStorage());
            //    foreach (DecodedShortMessage message in messages)
            //    {
            //        Output(string.Format("Message status = {0}, Location = {1}/{2}",
            //            StatusToString(message.Status), message.Storage, message.Index));
            //        ShowMessage(message.Data);
            //        Output("");

            //    }
            //    Output(string.Format("{0,9} messages read.", messages.Length.ToString()));
            //    Output("");
            //    comm.Close();
            //}
            //catch (Exception ex)
            //{
            //    comm.Close();
            //    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "پورت شناسایی نشد", ex.ToString());
            //}
        }

        //private string StatusToString(PhoneMessageStatus status)
        //{
            //string ret;
            //switch (status)
            //{
            //    case PhoneMessageStatus.All:
            //        ret = "All";
            //        break;
            //    case PhoneMessageStatus.ReceivedRead:
            //        ret = "Read";
            //        break;
            //    case PhoneMessageStatus.ReceivedUnread:
            //        ret = "Unread";
            //        break;
            //    case PhoneMessageStatus.StoredUnsent:
            //        ret = "Unsent";
            //        break;
            //    case PhoneMessageStatus.StoredSent:
            //        ret = "Sent";
            //        break;
            //    default:
            //        ret = "Unknown (" + status.ToString() + ")";
            //        break;
            //}
            //return ret;
        //}

        //private void ShowMessage(SmsPdu pdu)
        //{
        //    if (pdu is SmsSubmitPdu)
        //    {
        //        // Stored (sent/unsent) message
        //        SmsSubmitPdu data = (SmsSubmitPdu)pdu;
        //        Output("SENT/UNSENT MESSAGE");
        //        Output("Recipient: " + data.DestinationAddress);
        //        Output("Message text: " + data.UserDataText);
        //        Output("-------------------------------------------------------------------");
        //        return;
        //    }
        //    if (pdu is SmsDeliverPdu)
        //    {
        //        // Received message
        //        SmsDeliverPdu data = (SmsDeliverPdu)pdu;
        //        Output("RECEIVED MESSAGE");
        //        Output("Sender: " + data.OriginatingAddress);
        //        Output("Sent: " + data.SCTimestamp.ToString());
        //        Output("Message text: " + data.UserDataText);
        //        Output("-------------------------------------------------------------------");

        //        BindGrid(pdu);

        //        return;
        //    }
        //    if (pdu is SmsStatusReportPdu)
        //    {
        //        // Status report
        //        SmsStatusReportPdu data = (SmsStatusReportPdu)pdu;
        //        Output("STATUS REPORT");
        //        Output("Recipient: " + data.RecipientAddress);
        //        Output("Status: " + data.Status.ToString());
        //        Output("Timestamp: " + data.DischargeTime.ToString());
        //        Output("Message ref: " + data.MessageReference.ToString());
        //        Output("-------------------------------------------------------------------");
        //        return;
        //    }
        //    Output("Unknown message type: " + pdu.GetType().ToString());

        //}

        //private void BindGrid(SmsPdu pdu)
        //{
        //    DataRow dr = dt.NewRow();
        //    SmsDeliverPdu data = (SmsDeliverPdu)pdu;
        //    dr[0] = data.OriginatingAddress.ToString();
        //    dr[1] = data.SCTimestamp.ToString();
        //    dr[2] = data.UserDataText;
        //    dt.Rows.Add(dr);
        //    dataGridView_ReciveSMS.DataSource = dt;

        //}

        //private string GetMessageStorage()
        //{
        //    string storage = string.Empty;
        //    if (radiobtn_rbmsgsim.Checked)
        //        storage = PhoneStorageType.Phone;
        //    if (radiobtn_rbmsgphone.Checked)
        //        storage = PhoneStorageType.Sim;
        //    if (storage.Length == 0)
        //        throw new ApplicationException("Unknown message storage.");
        //    else
        //        return storage;
        //}

        private void Output(string text)
        {
        //    if (this.txoutput.InvokeRequired)
        //    {
        //        SetTextCallback stc = new SetTextCallback(Output);
        //        this.Invoke(stc, new object[] { text });
        //    }
        //    else
        //    {
        //        txoutput.AppendText(text);
        //        txoutput.AppendText("\r\n");
        //    }
        }

        private void ReciveSMS_frm_Load(object sender, EventArgs e)
        {
            SMSClass.ConnectToPort();
            ShowListRcvSMS();

            //    dt.Columns.Add("Sender", typeof(string));//, "فرستنده");
        //    dt.Columns.Add("Time", typeof(string));//"تاریخ و زمان");
        //    dt.Columns.Add("Message", typeof(string));//"متن پیام");
        //    dt.Columns["Sender"].Caption = "فرستنده";
        //    dt.Columns["Time"].Caption = "تاریخ و زمان";
        //    dt.Columns["Message"].Caption = "متن پیام";

        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem_DelRcSMS_Click(object sender, EventArgs e)
        {
            SMSClass.MessageDelete(lstInbox);
            ShowListRcvSMS();


        //    Comm_Port = Global_Cls.Comm_Port;
        //    Comm_BaudRate = Global_Cls.Comm_BaudRate;
        //    Comm_TimeOut = Global_Cls.Comm_TimeOut;

        //    comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);

        //    try { comm.Open(); }
        //    catch (Exception ex)
        //    {
        //        comm.Close();
        //        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "پورت شناسایی نشد", ex.ToString());
        //        return;
        //    }
            
        //    try
        //    {
        //        comm.DeleteMessage(dataGridView_ReciveSMS.CurrentRow.Index+1, GetMessageStorage());
        //        comm.Close();
        //        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "پیامک مورد نظر حذف شد");
        //        ShowListRcvSMS();
        //    }
        //    catch (Exception ex)
        //    {
        //        comm.Close();
        //        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "پیامک حذف نشد", ex.ToString());
        //    }

        }

        private void lstInbox_DoubleClick(object sender, EventArgs e)
        {
            SMSClass.listInboxDoubleClick(lstInbox);
        }

        private void ReciveSMS_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SMSClass.DisconnectPort();
        }
      
    }
}
