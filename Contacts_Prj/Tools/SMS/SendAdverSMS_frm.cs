using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using GsmComm.PduConverter;
using Contacts_Prj.Properties;
using System.Data.SqlClient;

namespace Contacts_Prj
{
    public partial class SendAdverSMS_frm : Form
    {
        public SendAdverSMS_frm()
        {
            InitializeComponent();
        }

        #region Button&UI
        public string MobileStr;
        private void SendAdverSMS_frm_Load(object sender, EventArgs e)
        {
            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItem_AdverPrint.Enabled = false;
                buttonItem_SendSMS.Enabled = false;
            }
            //codeing

            //DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            //var hh = from prd in DCMD.TBL_PersonTelMobs
            //         select new
            //         {
            //             Name_Mobile = prd.LastName + "," + prd.FirstName + "   " + prd.Mobile,
            //             prd.PersonID,
            //             prd.Mobile
            //         };
            //comboBox_PerMobile.DataSource = hh;
         
            //try
            //{
            //    comboBox_PerMobile.SelectedIndex = Convert.ToInt16(MobileStr);
            //}
            //catch
            //{
            //    comboBox_PerMobile.Text = MobileStr;
            //    label_Mobile.Text = MobileStr;
            //}
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem_Print_Click(object sender, EventArgs e)
        {
            //ReportClass_Cls.ReportForAdvertisment(true, textBox_SMSText.Text, Global_Cls.ReportDesignAddress[15]);
        }

        private void SendAdverSMS_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_SMSText.Text == "" && e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        #endregion



        #region SendSMS
        //public static int Comm_Port = 0;
        //public static int Comm_BaudRate = 0;
        //public static int Comm_TimeOut = 0;
        //public static GsmCommMain comm;

        private void buttonItem_SendSMS_Click(object sender, EventArgs e)
        {
            if (listBox_mobile.Items.Count == 0)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "لطفا موبایل (ها) را وارد نمایید");
                return;
            }
            try
            {
                panel_Text.Text = " ... در حال ارسال";
                panel_Text.Font = new Font("Tahoma", 10, FontStyle.Bold);

                for (int i = 0; i < listBox_mobile.Items.Count; i++)
                {
                    SMSClass.InsertToSMSList(listBox_mobile.Items[i].ToString(), textBox_SMSText.Text);
                }

                if (SMSClass.ConnectToPort())
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "متن به شماره(ها) ارسال شد");
                    SMSClass.SendList(0);
                    panel_Text.Text = "متن ارسالی";
                    panel_Text.Font = new Font("Tahoma", 9, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "عملیات ارسال با مشکل مواجه شد", ex.Message);
            }

            //label_Mobile.Text = label_Mobile.Text.Replace(" ", "");
            //if (label_Mobile.Text == "")
            //{
            //    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "لطفا شماره موبایل را وارد نمایید!");
            //    comboBox_PerMobile.Focus();
            //}
            //else
            //if (textBox_SMSText.Text == "")
            //{
            //    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "لطفا متن مورد نظر را وارد نمایید!");
            //    textBox_SMSText.Focus();
            //}
            //else
            //{
            //    if (Global_Cls.SoftwareCode.Contains("N"))
            //    {
            //        try
            //        {
            //            string StrConn = Global_Cls.ConnectionStr;

            //            SqlConnection SqConn = new SqlConnection(StrConn);
            //            SqConn.Open();

            //            SqlCommand SqCmd = new SqlCommand();
            //            SqCmd.Connection = SqConn;

            //            SqCmd.CommandText = " INSERT INTO [House_Management].[dbo].[TBL_SendSMS] "
            //                + " ([Mobile_No],[MessageText],[Status],[SMS_Few],[UserCode],[UseName],[Description])"
            //                + " VALUES " 
            //                +" ( '" + label_Mobile.Text + "' ,N'" + textBox_SMSText.Text + "', 0, 1," + Global_Cls.UserCode_Exist
            //                + ", '" + Global_Cls.UserName_Exist + "','')";

            //            SqlDataAdapter SDA = new SqlDataAdapter(SqCmd.CommandText, SqConn);
            //            SDA.UpdateCommand = new SqlCommand(SqCmd.CommandText, SqConn);
            //            try
            //            {
            //                SDA.UpdateCommand.ExecuteReader();
            //                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "متن جهت ارسال فرستاده شد");
            //                SqConn.Close();
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(Convert.ToString(ex));
            //            }
            //            SqConn.Close();

            //        }
            //        catch { }
            //    }
            //    else
            //    {


            //        try
            //        {
            //            Comm_Port = Global_Cls.Comm_Port;
            //            Comm_BaudRate = Global_Cls.Comm_BaudRate;
            //            Comm_TimeOut = Global_Cls.Comm_TimeOut;

            //            comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);
            //            comm.Open();
            //            //code for sending message from mobile
            //            SmsSubmitPdu pdu;

            //            bool unicode = Global_Cls.Send_Unicode;

            //            byte dcs;

            //            string SmsString = "";
            //            int smscount = textBox_SMSText.Text.Length / 70 + 1;
            //            int smsi = 0;
            //            while (smsi < smscount)
            //            {
            //                if (smsi == smscount - 1) SmsString = textBox_SMSText.Text.Substring(70 * smsi, textBox_SMSText.Text.Length - 70 * smsi);
            //                else SmsString = textBox_SMSText.Text.Substring(70 * smsi, 70);
            //                smsi++;

            //                if (unicode)
            //                {
            //                    dcs = DataCodingScheme.NoClass_16Bit;
            //                    pdu = new SmsSubmitPdu(SmsString, label_Mobile.Text, "", dcs);
            //                }
            //                else
            //                    pdu = new SmsSubmitPdu(SmsString, label_Mobile.Text, "");


            //                int times = 1;
            //                int count = 0;
            //                int i = 0;
            //                for (i = 0; i < times; i++)
            //                {
            //                    comm.SendMessage(pdu);
            //                    count++;
            //                }
            //            }

            //            label_Mobile.Text = smscount.ToString() + " SMS فرستاده شد. ";
            //        }
            //        catch (Exception ex)
            //        {
            //            string str = "اشکال در ارسال "+ex.ToString();
            //            if (ex.Message.Contains("COM")) str = "پورت شناسایی نشد";
            //            if (ex.Message.Contains("Message service error 144")) str = "شماره موبایل درست وارد نشده است!";
            //            if (ex.Message.Contains("Message service error 322")) str = "حافظه پر است! لطفا حافظه را تعدیل بفرمایید";

            //            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, str);
            //            //MessageBox.Show(this, "Send error:" + ex.Message, "Sms sender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        Cursor.Current = Cursors.Default;
            //        try
            //        {
            //            comm.Close();
            //        }
            //        catch { }
            //    }
            //}
        }

        
        #endregion

        private void buttonItem_Log_Click(object sender, EventArgs e)
        {
            SMSLogView_frm SLV = new SMSLogView_frm();
            SLV.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SMSMobSelect_frm df = new SMSMobSelect_frm();
            df.ShowDialog();
            try
            {
                System.Collections.Specialized.StringCollection fg = new System.Collections.Specialized.StringCollection();
                Function_Cls.WriteToParameter(df.MobileReturn, fg);
                //listBox_mobile.Items.Clear();
                
                for (int i = 0; i < fg.Count; i++)
                    if (fg[i] != "" && fg[i][0] == '0' && fg[i].Length == 11)
                        if (!listBox_mobile.Items.Contains(fg[i]))
                            listBox_mobile.Items.Add(fg[i]);
            }
            catch { }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try { listBox_mobile.Items.Remove(listBox_mobile.SelectedItems[0]); }
            catch { }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا کل لیست حذف شود؟"))
                listBox_mobile.Items.Clear();
        }

        
    }
}
