using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts_Prj
{
    public class SMSClass
    {
        private static mCore.SMS objSMS = new mCore.SMS();

        public static bool ConnectToPort()
        {

            //new 930925
            if (Global_Cls.SMSSet)
            {
                if (Global_Cls.SetConnection())
                    return true;
            }
            else
            {
                //new 930925

                try
                {

                    if (!objSMS.IsConnected && Global_Cls.SMSPort != "")
                    {
                        objSMS.Port = Global_Cls.SMSPort.ToString();
                        objSMS.BaudRate = (mCore.BaudRate)(Global_Cls.SMSBaudRate);
                        objSMS.DataBits = (mCore.DataBits)(Global_Cls.SMSDataBits);
                        objSMS.Parity = (mCore.Parity)(Global_Cls.SMSParity);
                        objSMS.StopBits = (mCore.StopBits)(Global_Cls.SMSStopBits);
                        objSMS.FlowControl = (mCore.FlowControl)Global_Cls.SMSFlowControl;

                        objSMS.ReadIntervalTimeout = Global_Cls.SMSTimeOut;
                        objSMS.DelayAfterPIN = 10000;
                        objSMS.LongMessage = (mCore.LongMessage)Global_Cls.SMSLongMsg;
                        objSMS.Encoding = (mCore.Encoding)Global_Cls.SMSEncoding;
                        objSMS.DeliveryReport = Global_Cls.SMSDeliveryReport;

                        objSMS.NewUSSDIndication = true;
                        objSMS.DisableCheckPIN = true;
                        //objSMS.Queue().Enabled = true;
                        objSMS.NewMessageConcatenate = true;


                        objSMS.SendDelay = (int)(1000);

                        objSMS.SendRetry = 1;

                        objSMS.Timeout = (long)(30 * 1000);

                        objSMS.Connect();
                        return true;
                    }
                    else
                        if (objSMS.Connect())
                            return true;
                }
                catch (mCore.GeneralException ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ارتباط با پورت امکان پذیر نمی باشد", ex.Message);
                }
            }
            return false;
        }

        public static bool DisconnectPort()
        {
            //new 930925
            if (Global_Cls.SMSSet)
            {
                return true;
            }
            else
            {
                //new 930925
                try
                {
                    if (objSMS.IsConnected)
                        objSMS.Disconnect();
                    return true;
                }
                catch (mCore.GeneralException ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال عمومی", ex.Message);
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
            return false;
        }

        public static string SendSMS(string PhoneNumber, string MessageStr)
        {
            if (PhoneNumber.Trim().Length <= 0)
            {
                return "شماره موبایل صحیح نمی باشد";
            }

            System.Windows.Forms.Application.DoEvents();


            //new 930925
            if (Global_Cls.SMSSet)
            {
                try
                {
                    long smsId = SMS_Cls.SendSMS(Global_Cls.IntUserName, Global_Cls.IntPassword,
                         Global_Cls.IntTelNumber, PhoneNumber, MessageStr);
                    return "ارسال شد!\r\n\r\n[Message Ref.: " + smsId + "]";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                //new 930925


                try
                {
                    //Set message validity period
                    //objSMS.Validity = "24H";

                    //Send the message
                    string strSendResult = objSMS.SendSMS(PhoneNumber, MessageStr);

                    return "ارسال شد!\r\n\r\n[Message Ref.: " + strSendResult + "]";
                }
                catch (mCore.SMSSendException ex)
                {
                    return ex.Message;
                }
                catch (mCore.GeneralException ex)
                {
                    return ex.Message;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static int InsertToSMSList(string MobileNo, string SMSText)
        {
            DataClassesSecondDataContext DCDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

            TBL_SendSMS th = new TBL_SendSMS();
            th.Mobile_No = MobileNo;
            th.MessageText = SMSText;// +" 'R.C.M' ";
            th.Status = 0;
            th.SMS_Few = 1;
            th.Archive = false;
            th.SendDate = Global_Cls.MiladiDateToShamsi(DateTime.Now);
            th.SendTime = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString("00") + ":" + DateTime.Now.TimeOfDay.Seconds.ToString("00");
            th.UserCode = Global_Cls.UserCode_Exist;
            th.UseName = Global_Cls.UserName_Exist;
            th.Description = "";
            DCDC.TBL_SendSMS.InsertOnSubmit(th);
            DCDC.SubmitChanges();

            int jj = int.Parse((from fg in DCDC.TBL_SendSMS select fg.SMSCode).Max().ToString());
            return jj;
        }

        public static void SendList(int SMSCode)
        {
            ConnectToPort();
            DataClassesSecondDataContext df = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            string ResultStrSMS = "";
           
            var ggg = from gh in df.TBL_SendSMS
                      where gh.Status == 0
                      select gh;
            if (SMSCode != 0)
                ggg = ggg.Where(jh => jh.SMSCode == SMSCode);

            foreach (var ft in ggg)
            {
                try
                {
                    ResultStrSMS = SendSMS(ft.Mobile_No, ft.MessageText);

                    TBL_SendSMS hy = df.TBL_SendSMS.First(kk => kk.SMSCode == ft.SMSCode);
                    hy.Description = "ارسال شد";
                    hy.SendDate = Global_Cls.MiladiDateToShamsi(DateTime.Now);
                    hy.SendTime = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
                    hy.Status = 1;
                    df.SubmitChanges();
                }
                catch (Exception ex)
                {
                    string str = "";
                    if (ex.Message.Contains("COM")) str = "پورت شناسایی نشد";
                    if (ex.Message.Contains("Message service error 144")) str = "شماره موبایل اشتباه است!";
                    if (ex.Message.Contains("Message service error 322")) str = "حافظه پر است!";

                    TBL_SendSMS hy = df.TBL_SendSMS.First(kk => kk.SMSCode == ft.SMSCode);
                    hy.Description = str;
                    hy.Status = 2;
                    df.SubmitChanges();
                }
            }
            DisconnectPort();
        }


        public static double GetCreditSMS(string UserName, string Password)
        {
            double resCredit = 0;
            resCredit = SMS_Cls.GetCreditSMS(UserName, Password);
            return resCredit;
        }

        public static string ReciveSMS(System.Windows.Forms.ListView lstInbox, int RSType)
        {
            string Result = "";
            ConnectToPort();
             //new 930925
            if (Global_Cls.SMSSet)
            {
                lstInbox.Items.Clear();
                int CountMsg = 0;
                Result = FillInboxList(lstInbox,ref CountMsg);
                if (Result == "")
                {
                    Result = "مجموع پیامک ها: " + CountMsg;
                    if (CountMsg > 0)
                        Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";
                }
            }
            else
            {
                mCore.Inbox objInbox = objSMS.Inbox();



                switch (RSType)
                {
                    case 0:
                        {
                            objSMS.MessageMemory = mCore.MessageMemory.SM;
                            break;
                        }
                    case 1:
                        {
                            objSMS.MessageMemory = mCore.MessageMemory.ME;
                            break;
                        }
                    case 2:
                        {
                            objSMS.MessageMemory = mCore.MessageMemory.MT;
                            break;
                        }
                }

                System.Windows.Forms.Application.DoEvents();

                try
                {
                    objInbox.Refresh();
                }
                catch (mCore.SMSReadException ex)
                {
                    return ex.Message;
                }
                catch (mCore.GeneralException ex)
                {
                    return ex.Message;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

                lstInbox.Items.Clear();
                Result = FillInboxList(lstInbox);
                if (Result == "")
                {
                    Result = "مجموع پیامک ها: " + objInbox.Count;
                    if (objInbox.Count > 0)
                        Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";
                }
            }
            return Result;
        }

        private static string FillInboxList(System.Windows.Forms.ListView lstInbox)
        {
            DataClasses_MainDataContext df = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            int i;
            mCore.Inbox objInbox = objSMS.Inbox();

            try
            {
                //Read properties of each message read from modem
                //and fill the listview collumns
                i = 0;
                string PhoneName = "";
                foreach (mCore.Message Msg in objInbox)
                {
                    PhoneName = Msg.Phone;
                    try { PhoneName = df.TBL_PersonTelMobs.First(kk => kk.Mobile == Msg.Phone).FirstName + " " + df.TBL_PersonTelMobs.First(h => h.Mobile == Msg.Phone).LastName; }
                    catch { PhoneName = Msg.Phone; }
                    lstInbox.Items.Add(PhoneName);
                    lstInbox.Items[i].SubItems.Add(Msg.Text);
                    lstInbox.Items[i].SubItems.Add(Msg.TimeStamp.ToString());
                    i++;
                }
                return "";

            }
            catch (mCore.SMSReadException ex)
            {
                return ex.Message;
            }
            catch (mCore.GeneralException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static string FillInboxList(System.Windows.Forms.ListView lstInbox, ref int MsgCount )
        {
            DataClasses_MainDataContext df = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            
            List<SMS_Cls.ListReciveSMS> LLRS = SMS_Cls.RecivedSMS(Global_Cls.IntUserName, Global_Cls.IntPassword, Global_Cls.IntTelNumber, true);
            try
            {
                int i = 0;
                string PhoneName = "";
                MsgCount = LLRS.Count();
                foreach (SMS_Cls.ListReciveSMS Msg in LLRS)
                {
                    PhoneName = Msg.SenderNumber;
                    try { PhoneName = df.TBL_PersonTelMobs.First(kk => kk.Mobile == Msg.SenderNumber).FirstName + " " + df.TBL_PersonTelMobs.First(h => h.Mobile == Msg.SenderNumber).LastName; }
                    catch { PhoneName = Msg.SenderNumber; }
                    lstInbox.Items.Add(PhoneName);
                    lstInbox.Items[i].SubItems.Add(Msg.Body);
                    lstInbox.Items[i].SubItems.Add(Msg.ReceiveDate);
                    i++;
                }
                return "";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static string MessageDelete(System.Windows.Forms.ListView lstInbox)
        {
            int i;
            try
            {
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید پیامک های انتخابی حذف شوند؟"))
                {
                    for (i = lstInbox.Items.Count; i >= 1; i--)
                    {
                        if (lstInbox.Items[i - 1].Checked)
                        {
                            objSMS.Inbox().Message(i).Delete();
                        }
                    }
                    string Result = "";
                    lstInbox.Items.Clear();
                    Result = FillInboxList(lstInbox);
                    if (Result == "")
                    {
                        Result = "مجموع پیامک ها: " + objSMS.Inbox().Count;
                        if (objSMS.Inbox().Count > 0)
                            Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";
                    }
                    return Result;
                }
                return "NO";
            }
            catch (mCore.SMSDeleteException ex)
            {
                return ex.Message;
            }
            catch (mCore.GeneralException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static void listInboxDoubleClick(System.Windows.Forms.ListView lstInbox)
        {
            int i;
            mCore.Inbox objInbox = objSMS.Inbox();
            mCore.Message Msg;

            try
            {
                //Read properties of selected message index from Inbox
                for (i = 1; i <= lstInbox.Items.Count; i++)
                {
                    Msg = objInbox.Message(i);
                    if (lstInbox.Items[i - 1].Checked)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, " از: " + Msg.Phone, Msg.TimeStampRFC + "\r\n\r\n" + Msg.Text);
                        break;
                    }
                }
                if (lstInbox.Items[i - 1].Checked)
                {
                    lstInbox.Items[i - 1].Checked = false;
                }
            }
            catch (mCore.SMSReadException ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " اشکال ", ex.Message);
            }
            catch (mCore.GeneralException ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " اشکال ", ex.Message);
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " اشکال ", ex.Message);
            }
        }
    }

       
}
