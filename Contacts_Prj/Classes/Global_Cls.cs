using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Contacts_Prj.Properties;
using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace Contacts_Prj
{
    public class Global_Cls
    {
        public enum MessageType { SError, SWarning, SConfirmation, SInformation };

        static public int UserCode_Exist = 1;
        static public string UserName_Exist = "";

        static public MainHM_frm MainForm = null;
        static public StartHM_frm StartForm = null;


        static public string SoftwareCode = "";//"N2+S";

        static public bool ClientSoftOK = false;


        #region All Message Forms
        static public bool Message_Sara(int Code_Msg, MessageType TypeMsg, bool OK_Cancel, string Str_Msg)
        {
            return Message_Sara(Code_Msg, TypeMsg, OK_Cancel, Str_Msg, "");
        }

        static public bool Message_Sara(int Code_Msg, MessageType TypeMsg, bool OK_Cancel, string Str_Msg, string Str_Error)
        {
            MessageSara_Frm MSF = new MessageSara_Frm();

            MSF.label_MsgS.Text = Str_Msg;
            MSF.pictureBox_Error.Visible = (TypeMsg == MessageType.SError); MSF.pictureBox_Error.Top = 20;
            MSF.pictureBox_Warning.Visible = (TypeMsg == MessageType.SWarning); MSF.pictureBox_Warning.Top = 20;
            MSF.pictureBox_Configuration.Visible = (TypeMsg == MessageType.SConfirmation); MSF.pictureBox_Configuration.Top = 20;
            MSF.pictureBox_Information.Visible = (TypeMsg == MessageType.SInformation); MSF.pictureBox_Information.Top = 20;
            MSF.button_Cancel.Visible = OK_Cancel;

            if (Str_Error != "")
            {
                MSF.button_Details.Visible = true;
                MSF.label_Detail.Text = Str_Error;
            }

            if (!OK_Cancel) MSF.button_OK.Left = 125;

            MPG_WinShutDowm.ShowShutForm sf = new MPG_WinShutDowm.ShowShutForm(MSF);

            if (MSF.DialogResult == System.Windows.Forms.DialogResult.OK) return true;
            return false;
        }
        #endregion


        #region Send Advertisement&SMS Forms
        static public void SendSMS_Advertisment(bool SMS_Advertisment, string SendingStr, string MobTel)
        {
            SendAdverSMS_frm SA_SMS = new SendAdverSMS_frm();

            SA_SMS.buttonItem_AdverPrint.Visible = !SMS_Advertisment;
            SA_SMS.textBox_SMSText.Text = SendingStr;
            SA_SMS.MobileStr = MobTel;
            if (SMS_Advertisment) SA_SMS.Text = "SMS";
            else SA_SMS.Text = "آگهی";

            SA_SMS.buttonItem_Log.Visible = (SoftwareCode.Contains("N"));
            SA_SMS.ShowDialog();
            return;
        }
        #endregion


        #region Date Convertor & Control
        static public string MiladiDateToShamsi(DateTime MiladiDate)
        {
            if (MiladiDate == null) return "0000/00/00";
            System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
            int dd, mm, yy;
            string Ret;

            yy = farsi.GetYear(MiladiDate);
            Ret = yy.ToString() + "/";
            mm = farsi.GetMonth(MiladiDate);
            if (mm < 10) Ret = Ret + "0" + mm.ToString() + "/";
            else Ret = Ret + mm.ToString() + "/";
            dd = farsi.GetDayOfMonth(MiladiDate);
            if (dd < 10) Ret = Ret + "0" + dd.ToString();
            else Ret = Ret + dd.ToString();

            return Ret;

            /*
            if (MiladiDate == null) return "0000/00/00";
            string Ret;
            int Year, Month, Day, F_Year, F_Month, F_Day, LastDay, Plus = 0, Minus, Intercalary;

            Year = MiladiDate.Year;
            Month = MiladiDate.Month;
            Day = MiladiDate.Day;

            if (Month == 1 || Month == 5 || Month == 6)
                Plus = 10;

            if (Month == 2 || Month == 4)
                Plus = 11;

            if (Month == 3 || Month == 7 || Month == 8 ||
                Month == 9 || Month == 11 || Month == 12)
                Plus = 9;

            if (Month == 10)
                Plus = 8;

            Year = Year % 100;

            Intercalary = Year;

            if (Intercalary % 4 == 0)
                if (Month >= 2)
                    Plus = Plus + 1;

            if ((Intercalary - 1) % 4 == 0)
            {
                LastDay = 30;
                if (Month <= 3)
                    Plus = Plus + 1;
            }
            else
                LastDay = 29;
            F_Year = Year - 22;

            if (F_Year <= 0)
                F_Year = F_Year + 100;

            F_Month = Month + 9;

            if (F_Month >= 12)
            {
                F_Month = F_Month - 12;
                F_Year = F_Year + 1;
            }

            F_Day = Day + Plus;

            if (F_Month <= 6)
                Minus = 31;
            else
                if (F_Month > 6 && F_Month < 12)
                    Minus = 30;
                else
                    Minus = LastDay;

            if (F_Day > Minus)
            {
                F_Day = F_Day - Minus;
                F_Month = F_Month + 1;
            }

            if (F_Month > 12)
            {
                F_Month = F_Month - 12;
                F_Year = F_Year + 1;
            }

            if (F_Year >= 10)
                Ret = "13" + F_Year.ToString() + "/";
            else
                Ret = "130" + F_Year.ToString() + "/";


            if (F_Month >= 10)
                Ret = Ret + F_Month.ToString() + "/";
            else
                Ret = Ret + "0" + F_Month.ToString() + "/";

            if (F_Day >= 10)
                Ret = Ret + F_Day.ToString();
            else
                Ret = Ret + "0" + F_Day.ToString();

            return Ret;*/
        }


        static public DateTime ShamsiDateToMiladi(string DateString, string year, string month, string dy)
        {

            if (DateString == "" && year == "" && month == "" && dy == "")
                return DateTime.MinValue;

            short yy, mm, dd;

            if (DateString != "")
            {
                yy = Convert.ToInt16(DateString.Substring(0, 4));
                mm = Convert.ToInt16(DateString.Substring(5, 2));
                dd = Convert.ToInt16(DateString.Substring(8, 2));
            }
            else
            {
                yy = Convert.ToInt16(year);
                mm = Convert.ToInt16(month);
                dd = Convert.ToInt16(dy);
            }

            DateTime MiladiDate;
            System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
            MiladiDate = farsi.ToDateTime(yy, mm, dd, 12, 0, 0, 0);

            return MiladiDate;


            /*DateTime MiladiDate;
            int day, x, z, i;

            if (yy < 1278)
                MiladiDate = DateTime.MinValue;
            else
            {
                i = 0;
                if (yy == 0 || mm == 0 || dd == 0)
                    return DateTime.MinValue;
                else
                {
                    x = (yy - 1276) / 33;
                    z = (yy - (x * 33 + 1276)) / 4;
                    if ((yy - (x * 33 + 1276)) % 4 != 0) z = z + 1;
                    day = (yy - 1276) * 365 + x * 8 + z;
                    while (i <= mm - 2)
                    {
                        if (i <= 5)
                            day = day + 31;
                        else
                            if (i <= 10)
                                day = day + 30;
                            else
                                day = day + 29;
                        i = i + 1;
                    }
                    day = day + dd - 1;
                    MiladiDate = DateTime.SpecifyKind(Convert.ToDateTime("3/20/1897"), DateTimeKind.Local).AddDays(day);
                }
            }
            return MiladiDate;*/
        }
        static public DateTime ShamsiDateToMiladi(string DateString) { return ShamsiDateToMiladi(DateString, "", "", ""); }

        static public DateTime ShamsiDateToMiladi(string year, string mnth, string dy) { return ShamsiDateToMiladi("", year, mnth, dy); }

        static public bool CheckShamsiDate(string DateString)
        {
            int y, m, d;
            try
            {
                y = Convert.ToInt32(DateString.Substring(0, 4));
                m = Convert.ToInt32(DateString.Substring(5, 2));
                d = Convert.ToInt32(DateString.Substring(8, 2));
            }
            catch
            { return false; }

            if ((y < 1300 | y > 1420) | ((y % 4 != 3) & (m == 12) & (d == 30))
                | ((m >= 7) & (d == 31)) | (m > 12) | (d > 31) | (m == 0) | (d == 0))
                return false;
            return true;
        }
        #endregion


        #region Other
        static public string DigitSeparator(string txt)
        {
            if (txt == null) return "";
            txt = txt.Replace(",", "");
            string stx = "";
            int i = 1;
            while (txt.Length - 3 * i > 0)
            {
                stx = "," + txt.Substring(txt.Length - i * 3, 3) + stx;
                i++;
            }
            txt = txt.Substring(0, txt.Length - (i - 1) * 3) + stx;
            return txt;
        }


        static public string DigitSeparator(string txt1, string txt2)
        {
            return DigitSeparator(txt1) + "-" + DigitSeparator(txt2);
        }


        //static public void AddTab_ListFileStatus(string Comments, int FileSts, bool ReminderAlarm)
        //{
        //    ListFileAllTrans_UC Uc = new ListFileAllTrans_UC();
        //    Uc.FileStatus = FileSts;
        //    Uc.ReminderAlrm = ReminderAlarm;
        //    MainForm.AddTabToTabControl("ListFileAllTrans" + FileSts.ToString(), Comments, Uc);
        //}
        #endregion


        #region Set language


        static public void GetFarsiOrLatinLanguage(string FaOrEn)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (FaOrEn == "Fa")
                {
                    if ((lang.LayoutName.ToLower() == "farsi") | (lang.LayoutName == "Persian"))
                        InputLanguage.CurrentInputLanguage = lang;
                }
                else
                {
                    if ((lang.LayoutName.ToLower() == "us"))
                        InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }


        #endregion


        #region Email And Telephone

        static public void SendEmail(string Text)
        {
            RegisterEmail_frm reg = new RegisterEmail_frm(Text);
            reg.ShowDialog();
        }

        static public int InsertPerTelMob(string Name, string Family, string Tel, string Mob, string EML,
            string Adrs, string Desc)
        {
            if ((Tel == "" && Mob == "") || Family == "") return 4;

            try
            {
                DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                var prd = from p in DCDC.TBL_PersonTelMobs
                          where (p.FirstName == Name) && (p.LastName == Family)
                          select p;
                if (prd.Count() != 0)
                    return 1;

                if (Mob != "")
                {
                    var pm = from p in DCDC.TBL_PersonTelMobs
                             where (p.Mobile == Mob)
                             select p;
                    if (pm.Count() != 0)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره موبایل در دفتر تلفن موجود می باشد!");
                        return 2;
                    }
                }

                TBL_PersonTelMob tptm = new TBL_PersonTelMob
                {
                    FirstName = Name,
                    LastName = Family,
                    Telephone = Tel,
                    Mobile = Mob,
                    Email = EML,
                    Address = Adrs,
                    Description = Desc,
                };
                DCDC.TBL_PersonTelMobs.InsertOnSubmit(tptm);
                DCDC.SubmitChanges();

            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());
                return 3;
            }

            return 0;
        }

        #endregion


        #region Test Internet Connection
        [DllImport("wininet.dll", CharSet = CharSet.Auto)]

        static extern bool InternetGetConnectedState(ref ConnectionState lpdwFlags, int dwReserved);

        [Flags]
        enum ConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }

        static public bool SetConnection()
        {
            ConnectionState Description = 0;
            if (!InternetGetConnectedState(ref Description, 0))
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "اتصال به اینترنت برقرار نمی باشد!");
                return false;
            }
            return true;
        }
        #endregion

        static public string Key_Name = "912-4573723";
        static public string RootSaveLoad()
        {
            if (Global_Cls.ClientSoftOK)
            {
                if (System.IO.Directory.Exists("\\\\" + Global_Cls.ServerName + "\\Contacts"))
                    return "\\\\" + Global_Cls.ServerName + "\\Contacts";
                else
                    return "\\\\" + Global_Cls.ServerName + "\\PhoneBook";
            }
            else
                return Application.StartupPath;
        }




        #region All Parameter Settings

        //LocalConfig
        static public bool NonActiveOn_Off = false;

        static public short NonActive_Day = 30;

        static public bool IsDefaultValue = false;

        static public string ServerName = "LocalHost";//"127.0.0.1";

        static public string ConnectionDef = @"Data Source=" + Global_Cls.ServerName + @"\sqlexpress;";

        static public string ServerNameForLock = "127.0.0.1";

        static public byte ColorDisplay = 0;



        //MainConfig
        static public string SMSPort = "COM4";

        static public int SMSBaudRate = 115200;

        static public int SMSDataBits = 8;

        static public int SMSParity = 0;

        static public int SMSStopBits = 0;

        static public int SMSFlowControl = 0;

        static public int SMSTimeOut = 400;

        static public int SMSEncoding = 2;

        static public int SMSLongMsg = 3;
        
        static public bool SMSDeliveryReport = false;

        //new 930925
        public static bool SMSSet = true;

        public static string IntUserName = "";

        public static string IntPassword = "";

        public static string IntTelNumber = "";

        public static string InitSMSMessage = "";
        
        public static string IDSoftwareCode = "";

        //new 930925


        static public int BkpExitType = 0;

        static public string BkpAutoRoot = "D:\\BackUpData";

        static public string PssRstrr = "uvwxy";

        static public bool BkpRstPicsFilms = false;

        static public bool BkpRstDesignReport = false;


        //Main Start 931222

        static public string CustomerName = "";
        static public string CoName = "";
        static public string CoNationalCode = "";
        static public string CoAddress = "";
        static public string CoTel = "";
        static public string CoMobile = "";
        static public string CoEmail = "";

        //Main End


        static public string ConnectionStr = "";


        #endregion

    }

}
