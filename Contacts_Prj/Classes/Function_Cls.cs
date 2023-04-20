using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Contacts_Prj.Properties;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Threading;
using System.Management;

namespace Contacts_Prj
{
    class Function_Cls
    {

        #region Security

        public static bool ExitForce = false;

        public static void CheckKeyFile()
        {
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt"))
            {
                string SC = "";
                try
                {
                    SC = ExtractCodeOfKey(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt");
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "قفل نرم افزاری معتبر نمی باشد", ex.Message);
                    ExitForce = true;
                    Application.Exit();
                }

                try
                {
                    if (!CheckExtractCodeOfKey(ListExtractOfCode(SC)))
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
                        ExitForce = true;
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد", ex.Message);
                    ExitForce = true;
                    Application.Exit();
                }
            }
            else
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false,
                    "لطفا کدهای ذیل را جهت گرفتن فایل راه انداز ارسال نمایید ",
                    HddAndCpuDef());
                ExitForce = true;
                Application.Exit();
            }

        }

        private static bool CheckExtractCodeOfKey(Dictionary<string, string> LEC)
        {
            string Model = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive ");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                if (LEC["Model"] == moDisk["Model"].ToString())
                {
                    Model = LEC["Model"];
                    break;
                }
            }
            if (Model == "") return false;

            if (LEC["CPU"] != GetCPU()) return false;
            //if (LEC["MacAddress"] != GetMacAddress()) return false;
            if (LEC["TotalCylinders"] != GetTotalCylindersHDD(Model)) return false;
            if (LEC["TotalSectors"] != GetTotalSectorsHDD(Model)) return false;

            Global_Cls.SoftwareCode = LEC["SoftwareCode"] == "" ? "Trial" : LEC["SoftwareCode"];

            return true;
        }

        private static Dictionary<string, string> ListExtractOfCode(string SC)
        {
            Dictionary<string, string> Result = new Dictionary<string, string>(6);

            Result.Add("Model", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);
            Result.Add("TotalCylinders", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);
            Result.Add("TotalSectors", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);
            Result.Add("CPU", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);

            try
            {
                Result.Add("MacAddress", SC.Substring(0, SC.IndexOf("+++")));
                SC = SC.Remove(0, SC.IndexOf("+++") + 3);
                Result.Add("SoftwareCode", SC);
            }
            catch
            {
                Result.Add("MacAddress", SC);
                Result.Add("SoftwareCode", "");
            }

            return Result;
        }

        public static string ExtractCodeOfKey(string PathFile)
        {
            string text = System.IO.File.ReadAllText(PathFile);

            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PrivateDecryption(text);
            }
            catch { }

            return Result;
        }


        //private static string HddAndCpuCheck(string model)
        //{
        //    string S = "", M = "", TC = "", TS = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        //S = moDisk["SerialNumber"].ToString();
        //        M = moDisk["Model"].ToString();
        //        TC = moDisk["TotalCylinders"].ToString();
        //        TS = moDisk["TotalSectors"].ToString();
        //    }
        //    return model + "+++" + GetCPU() + "+++" + GetMacAddress() + "+++" + GetTotalCylindersHDD(model) + "+++" + GetTotalSectorsHDD(model);
        //}

        //private static string HddAndCpuDefFinalCheck(string model)
        //{
        //    string M = "", TC = "", TS = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        M = moDisk["Model"].ToString();
        //        TC = moDisk["TotalCylinders"].ToString();
        //        TS = moDisk["TotalSectors"].ToString();
        //    }
        //    return M + "+++" + GetCPU() + "+++" + TC + "+++" + TS;
        //}

        private static string HddAndCpuDef()
        {
            string Model = "", HddAndCpuDef = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive ");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                Model = moDisk["Model"].ToString();
                HddAndCpuDef += Model + "\\";
                HddAndCpuDef += GetTotalCylindersHDD(Model) + "\\";
                HddAndCpuDef += GetTotalSectorsHDD(Model) + "\\";
                HddAndCpuDef += GetCPU() + "\\";
                HddAndCpuDef += GetMacAddress() + "//////////////";
            }


            return HddAndCpuDef;
        }

        private static string GetTotalCylindersHDD(string model)
        {
            string TotalCylinders = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                try { TotalCylinders = moDisk["TotalCylinders"].ToString(); }
                catch { TotalCylinders = ""; }
            }
            return TotalCylinders;
        }

        private static string GetTotalSectorsHDD(string model)
        {
            string TotalSectors = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                try { TotalSectors = moDisk["TotalSectors"].ToString(); }
                catch { TotalSectors = ""; }
            }
            return TotalSectors;
        }

        private static string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }

        private static string GetCPU()
        {
            string GetCPU = string.Empty;
            System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_Processor");
            System.Management.ManagementObjectCollection theCollectionOfResults = theClass.GetInstances();

            foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
            {
                GetCPU += currentResult["ProcessorID"].ToString();
            }

            return GetCPU;

        }


        public static string DecriptionText(string TextStr)
        {
            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PrivateDecryption(TextStr);
            }
            catch { }

            return Result;
        }

        public static string EncriptionText(string TextStr)
        {
            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PublicEncrypt(TextStr);
            }
            catch { }

            return Result;
        }

        #endregion



        #region Security old

        //public static bool ExitForce = false;

        //public static void CheckKeyFile()
        //{
        //    if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt"))
        //    {
        //        string SC = "";
        //        try
        //        {
        //            SC = ExtractCodeOfKey(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt");
        //        }
        //        catch (Exception ex)
        //        {
        //            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "قفل نرم افزاری معتبر نمی باشد", ex.Message);
        //            ExitForce = true;
        //            Application.Exit();
        //        }

        //        try
        //        {
        //            if (!CheckExtractCodeOfKey(ListExtractOfCode(SC)))
        //            {
        //                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
        //                ExitForce = true;
        //                Application.Exit();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد", ex.Message);
        //            ExitForce = true;
        //            Application.Exit();
        //        }
        //    }
        //    else
        //    {
        //        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false,
        //            "لطفا کدهای ذیل را جهت گرفتن فایل راه انداز ارسال نمایید ",
        //            HddAndCpuDef());
        //        ExitForce = true;
        //        Application.Exit();
        //    }

        //}

        //private static bool CheckExtractCodeOfKey(Dictionary<string, string> LEC)
        //{
        //    string Model = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive ");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        if (LEC["Model"] == moDisk["Model"].ToString())
        //        {
        //            Model = LEC["Model"];
        //            break;
        //        }
        //    }
        //    if (Model == "") return false;

        //    if (LEC["CPU"] != GetCPU()) return false;
        //    if (LEC["MacAddress"] != GetMacAddress()) return false;
        //    if (LEC["TotalCylinders"] != GetTotalCylindersHDD(Model)) return false;
        //    if (LEC["TotalSectors"] != GetTotalSectorsHDD(Model)) return false;

        //    Global_Cls.SoftwareCode = LEC["SoftwareCode"] == "" ? "Trial" : LEC["SoftwareCode"];

        //    return true;
        //}

        //private static Dictionary<string, string> ListExtractOfCode(string SC)
        //{
        //    Dictionary<string, string> Result = new Dictionary<string, string>(6);

        //    Result.Add("Model", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //    Result.Add("TotalCylinders", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //    Result.Add("TotalSectors", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //    Result.Add("CPU", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);

        //    try
        //    {
        //        Result.Add("MacAddress", SC.Substring(0, SC.IndexOf("+++")));
        //        SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //        Result.Add("SoftwareCode", SC);
        //    }
        //    catch
        //    {
        //        Result.Add("MacAddress", SC);
        //        Result.Add("SoftwareCode", "");
        //    }

        //    return Result;
        //}

        //public static string ExtractCodeOfKey(string PathFile)
        //{
        //    string text = System.IO.File.ReadAllText(PathFile);

        //    RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
        //    BS.LoadPublicKey();
        //    BS.LoadPrivateKey();


        //    string Result = "";
        //    try
        //    {
        //        Result = BS.PrivateDecryption(text);
        //    }
        //    catch { }

        //    return Result;
        //}


        ////private static string HddAndCpuCheck(string model)
        ////{
        ////    string S = "", M = "", TC = "", TS = "";
        ////    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        ////        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        ////    foreach (ManagementObject moDisk in mosDisks.Get())
        ////    {
        ////        //S = moDisk["SerialNumber"].ToString();
        ////        M = moDisk["Model"].ToString();
        ////        TC = moDisk["TotalCylinders"].ToString();
        ////        TS = moDisk["TotalSectors"].ToString();
        ////    }
        ////    return model + "+++" + GetCPU() + "+++" + GetMacAddress() + "+++" + GetTotalCylindersHDD(model) + "+++" + GetTotalSectorsHDD(model);
        ////}

        ////private static string HddAndCpuDefFinalCheck(string model)
        ////{
        ////    string M = "", TC = "", TS = "";
        ////    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        ////        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        ////    foreach (ManagementObject moDisk in mosDisks.Get())
        ////    {
        ////        M = moDisk["Model"].ToString();
        ////        TC = moDisk["TotalCylinders"].ToString();
        ////        TS = moDisk["TotalSectors"].ToString();
        ////    }
        ////    return M + "+++" + GetCPU() + "+++" + TC + "+++" + TS;
        ////}

        //private static string HddAndCpuDef()
        //{
        //    string Model = "", HddAndCpuDef = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive ");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        Model = moDisk["Model"].ToString();
        //        HddAndCpuDef += Model + "\\";
        //        HddAndCpuDef += GetTotalCylindersHDD(Model) + "\\";
        //        HddAndCpuDef += GetTotalSectorsHDD(Model) + "//////";
        //    }

        //    HddAndCpuDef += GetCPU() + "\\" + GetMacAddress() + "//////////////";

        //    return HddAndCpuDef;
        //}

        //private static string GetTotalCylindersHDD(string model)
        //{
        //    string TotalCylinders = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        try { TotalCylinders = moDisk["TotalCylinders"].ToString(); }
        //        catch { TotalCylinders = ""; }
        //    }
        //    return TotalCylinders;
        //}

        //private static string GetTotalSectorsHDD(string model)
        //{
        //    string TotalSectors = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        try { TotalSectors = moDisk["TotalSectors"].ToString(); }
        //        catch { TotalSectors = ""; }
        //    }
        //    return TotalSectors;
        //}

        //private static string GetMacAddress()
        //{
        //    string macAddresses = string.Empty;

        //    foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
        //    {
        //        if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
        //        {
        //            macAddresses += nic.GetPhysicalAddress().ToString();
        //            break;
        //        }
        //    }

        //    return macAddresses;
        //}

        //private static string GetCPU()
        //{
        //    string GetCPU = string.Empty;
        //    System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_Processor");
        //    System.Management.ManagementObjectCollection theCollectionOfResults = theClass.GetInstances();

        //    foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
        //    {
        //        GetCPU += currentResult["ProcessorID"].ToString();
        //    }

        //    return GetCPU;

        //}


        //public static string DecriptionText(string TextStr)
        //{
        //    RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
        //    BS.LoadPublicKey();
        //    BS.LoadPrivateKey();


        //    string Result = "";
        //    try
        //    {
        //        Result = BS.PrivateDecryption(TextStr);
        //    }
        //    catch { }

        //    return Result;
        //}

        //public static string EncriptionText(string TextStr)
        //{
        //    RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
        //    BS.LoadPublicKey();
        //    BS.LoadPrivateKey();


        //    string Result = "";
        //    try
        //    {
        //        Result = BS.PublicEncrypt(TextStr);
        //    }
        //    catch { }

        //    return Result;
        //}

        #endregion


        #region BackUp & Restore DB

        static public void SetBackUpDBAll(string PathSaveBackup)
        {
            SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandText = " BACKUP DATABASE [Contacts] TO DISK = N'" + PathSaveBackup + "' " +
                                 " WITH FORMAT, INIT, NAME = N'Contacts-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.Connection = SqlConn;

            SqlConn.Open();

            try
            {
                SqlCmd.ExecuteReader();
                
                //SetBackUpPicFilm_DesignRep(Path.GetDirectoryName(PathSaveBackup), Path.GetFileName(PathSaveBackup).Replace(Path.GetExtension(PathSaveBackup), ""));
                
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "عمل پشتیبانی با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                string ex_str = Convert.ToString(ex);
                if (ex_str.IndexOf("Cannot open backup device") > 0)
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مسیر پشتیبانی را عوض کنید!");
                else
                    MessageBox.Show(Convert.ToString(ex));
            }
            SqlConn.Close();
        }

        //static public void SetBackUpPicFilm_DesignRep(string PathSaveBackup, string FileName)
        //{
        //    if (Global_Cls.BkpRstPicsFilms)
        //        CopyFolder(Global_Cls.RootSaveLoad() + "\\PicsFilms", PathSaveBackup + "\\" + FileName + "_BkpPicsFilms");
        //    if (Global_Cls.BkpRstDesignReport) 
        //        CopyFolder(Global_Cls.RootSaveLoad() + "\\Report", PathSaveBackup + "\\" + FileName + "_BkpReport");
        //}

        static public void CopyFolder( string sourceFolder, string destFolder ) 
        { 
            if (!Directory.Exists( destFolder )) 
            Directory.CreateDirectory( destFolder ); 
            string[] files = Directory.GetFiles( sourceFolder ); 
            foreach (string file in files) 
            { 
                string name = Path.GetFileName( file ); 
                string dest = Path.Combine( destFolder, name );
                try { File.Copy(file, dest); }
                catch { }
            } 
            string[] folders = Directory.GetDirectories( sourceFolder ); 
            foreach (string folder in folders) 
            { 
                string name = Path.GetFileName( folder ); 
                string dest = Path.Combine( destFolder, name );
                try { CopyFolder(folder, dest); }
                catch { }
            } 
        } 

        static public void SetRestoreDBAll(string PathSaveRestore)
        {
            SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);
            SqlCommand SqlCmd = new SqlCommand();

            SqlCmd.CommandText =
                "use master " +
                "ALTER DATABASE [Contacts] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                "RESTORE DATABASE [Contacts] FROM  DISK = N'" + PathSaveRestore +
                "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10";
            //@"' WITH FILE = 1,  NOUNLOAD,  REPLACE, MOVE 'APPSERVER' TO 'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\APPSERVER_Data.MDF', " +
            //@"MOVE 'APPSERVER_Log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\APPSERVER_Log.LDF' ";
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.Connection = SqlConn;

            SqlDataAdapter SDA = new SqlDataAdapter(SqlCmd.CommandText, SqlConn);
            SDA.UpdateCommand = new SqlCommand(SqlCmd.CommandText, SqlConn);

            SqlConn.Open();

            try
            {
                SDA.UpdateCommand.ExecuteReader();

                //RestorePicFilm_DesignRep(Path.GetDirectoryName(PathSaveRestore), Path.GetFileName(PathSaveRestore).Replace(Path.GetExtension(PathSaveRestore), ""));

                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "عمل بازیابی با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                string ex_str = Convert.ToString(ex);
                if (ex_str.IndexOf("Cannot open backup device") > 0)
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مسیر بازیابی را عوض کنید!");
                else
                    MessageBox.Show(Convert.ToString(ex));
            }

            SqlConn.Close();
        }

        //static public void RestorePicFilm_DesignRep(string PathSaveRst, string FileName)
        //{
        //    if (Global_Cls.BkpRstPicsFilms)
        //        CopyFolder(PathSaveRst + "\\" + FileName + "_BkpPicsFilms", Global_Cls.RootSaveLoad() + "\\PicsFilms");
        //    if (Global_Cls.BkpRstDesignReport)
        //        CopyFolder(PathSaveRst + "\\" + FileName + "_BkpReport", Global_Cls.RootSaveLoad() + "\\Report");
        //}

        static public void Restore_Func(bool EditPass_EnterPass)
        {
            RstPass_frm RPF = new RstPass_frm();

            RPF.Edit_Enter = EditPass_EnterPass;
            if (EditPass_EnterPass)
            {
                RPF.groupPanel_NewPass.Visible = true;
                RPF.Height = 212; 
            }
            else
            {
                RPF.groupPanel_EnterPass.Visible = true;
                RPF.Height = 140;
            }

            RPF.ShowDialog();
        }

        #endregion



        #region SearchInternet
        public static void SearchInternet(int SearchType)
        {
            //1: Search  2: Map Search
            SearchInternet_frm SIf = new SearchInternet_frm();
            SIf.SearchTypeEnter = SearchType;
            SIf.ShowDialog();
        }

        #endregion       


        #region Read&Write ConfigFile & Settings
        public static void ReadFromXmlFiles()
        {

            if (File.Exists("LocalConfig.xml"))
            {
                try
                {
                    XDocument loaded = XDocument.Load("LocalConfig.xml");

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();

                    Global_Cls.NonActiveOn_Off = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "NonActiveOn_Off").Value);
                    Global_Cls.NonActive_Day = Convert.ToInt16(q.Find(j => j.FirstAttribute.Value == "NonActive_Day").Value);
                    Global_Cls.IsDefaultValue = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "IsDefaultValue").Value);
                    Global_Cls.ServerName = q.Find(j => j.FirstAttribute.Value == "ServerName").Value;
                    Global_Cls.ConnectionDef = q.Find(j => j.FirstAttribute.Value == "ConnectionDef").Value;
                    Global_Cls.ServerNameForLock = q.Find(j => j.FirstAttribute.Value == "ServerNameForLock").Value;
                    Global_Cls.ColorDisplay = Convert.ToByte(q.Find(j => j.FirstAttribute.Value == "ColorDisplay").Value);

                }
                catch { }

            }

            string RootStr = Global_Cls.RootSaveLoad() + "\\MainConfig.xml";

            if (File.Exists(RootStr))
            {
                try
                {
                    XDocument loaded = XDocument.Load(RootStr);

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();

                    Global_Cls.SMSPort = q.Find(j => j.FirstAttribute.Value == "SMSPort").Value;
                    Global_Cls.SMSBaudRate = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSBaudRate").Value);
                    Global_Cls.SMSDataBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSDataBits").Value);
                    Global_Cls.SMSParity = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSParity").Value);
                    Global_Cls.SMSStopBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSStopBits").Value);
                    Global_Cls.SMSFlowControl = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSFlowControl").Value);
                    Global_Cls.SMSTimeOut = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSTimeOut").Value);

                    Global_Cls.SMSEncoding = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSEncoding").Value);
                    Global_Cls.SMSLongMsg = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSLongMsg").Value);
                    Global_Cls.SMSDeliveryReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "SMSDeliveryReport").Value);

                    //new 930925
                    Global_Cls.SMSSet = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "SMSSet").Value);
                    Global_Cls.IntUserName = q.Find(j => j.FirstAttribute.Value == "IntUserName").Value;
                    Global_Cls.IntPassword = DecriptionText(q.Find(j => j.FirstAttribute.Value == "IntPassword").Value);
                    Global_Cls.IntTelNumber = q.Find(j => j.FirstAttribute.Value == "IntTelNumber").Value;
                    Global_Cls.InitSMSMessage = q.Find(j => j.FirstAttribute.Value == "InitSMSMessage").Value;
                    
                    Global_Cls.IDSoftwareCode = q.Find(j => j.FirstAttribute.Value == "IDSoftwareCode").Value;

                    //new 930925

                    //Main Start 931222

                    Global_Cls.CustomerName = q.Find(j => j.FirstAttribute.Value == "CustomerName").Value;
                    Global_Cls.CoName = q.Find(j => j.FirstAttribute.Value == "CoName").Value;
                    Global_Cls.CoNationalCode = q.Find(j => j.FirstAttribute.Value == "CoNationalCode").Value;
                    Global_Cls.CoAddress = q.Find(j => j.FirstAttribute.Value == "CoAddress").Value;
                    Global_Cls.CoTel = q.Find(j => j.FirstAttribute.Value == "CoTel").Value;
                    Global_Cls.CoMobile = q.Find(j => j.FirstAttribute.Value == "CoMobile").Value;
                    Global_Cls.CoEmail = q.Find(j => j.FirstAttribute.Value == "CoEmail").Value;

                    //Main End



                    //Global_Cls.Comm_Port = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_Port").Value);
                    //Global_Cls.Comm_BaudRate = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_BaudRate").Value);
                    //Global_Cls.Comm_TimeOut = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_TimeOut").Value);
                    //Global_Cls.Send_Unicode = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "Send_Unicode").Value);

                    Global_Cls.BkpExitType = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "BkpExitType").Value);
                    Global_Cls.BkpAutoRoot = q.Find(j => j.FirstAttribute.Value == "BkpAutoRoot").Value;
                    Global_Cls.PssRstrr = q.Find(j => j.FirstAttribute.Value == "PssRstrr").Value;
                    Global_Cls.BkpRstPicsFilms = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstPicsFilms").Value);
                    Global_Cls.BkpRstDesignReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstDesignReport").Value);
                }
                catch { }
            }
            

        }


        public static void WriteToXmlFiles()
        {
            XElement xmlLoacl = new XElement("userSettings",
                        new XElement("setting",
                            new XAttribute("Name", "NonActiveOn_Off"),
                            new XElement("Value", Global_Cls.NonActiveOn_Off.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "NonActive_Day"),
                            new XElement("Value", Global_Cls.NonActive_Day.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "IsDefaultValue"),
                            new XElement("Value", Global_Cls.IsDefaultValue.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ServerName"),
                            new XElement("Value", Global_Cls.ServerName)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ConnectionDef"),
                            new XElement("Value", Global_Cls.ConnectionDef)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ServerNameForLock"),
                            new XElement("Value", Global_Cls.ServerNameForLock)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ColorDisplay"),
                            new XElement("Value", Global_Cls.ColorDisplay)
                       )
                    );
            xmlLoacl.Save(@"LocalConfig.xml");



            if (!Global_Cls.ClientSoftOK) 
            {
                XElement XmlMain = new XElement("userSettings",
                        
                        new XElement("setting",
                            new XAttribute("Name", "SMSPort"),
                            new XElement("Value", Global_Cls.SMSPort.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSBaudRate"),
                            new XElement("Value", Global_Cls.SMSBaudRate.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSDataBits"),
                            new XElement("Value", Global_Cls.SMSDataBits.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSParity"),
                            new XElement("Value", Global_Cls.SMSParity.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSStopBits"),
                            new XElement("Value", Global_Cls.SMSStopBits.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSFlowControl"),
                            new XElement("Value", Global_Cls.SMSFlowControl.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSTimeOut"),
                            new XElement("Value", Global_Cls.SMSTimeOut.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSEncoding"),
                            new XElement("Value", Global_Cls.SMSEncoding.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSLongMsg"),
                            new XElement("Value", Global_Cls.SMSLongMsg.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSDeliveryReport"),
                            new XElement("Value", Global_Cls.SMSDeliveryReport.ToString())
                        ),

                        new XElement("setting",
                            new XAttribute("Name", "BkpExitType"),
                            new XElement("Value", Global_Cls.BkpExitType.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "BkpAutoRoot"),
                            new XElement("Value", Global_Cls.BkpAutoRoot)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "PssRstrr"),
                            new XElement("Value", Global_Cls.PssRstrr)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "BkpRstPicsFilms"),
                            new XElement("Value", Global_Cls.BkpRstPicsFilms.ToString())
                        ),

                          //new 930925
                        new XElement("setting",
                            new XAttribute("Name", "SMSSet"),
                            new XElement("Value", Global_Cls.SMSSet.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "IntUserName"),
                            new XElement("Value", Global_Cls.IntUserName.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "IntPassword"),
                            new XElement("Value", EncriptionText(Global_Cls.IntPassword))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "IntTelNumber"),
                            new XElement("Value", Global_Cls.IntTelNumber.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "InitSMSMessage"),
                            new XElement("Value", Global_Cls.InitSMSMessage.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "IDSoftwareCode"),
                            new XElement("Value", Global_Cls.IDSoftwareCode.ToString())
                        ),

                    //new 930925


                    //Main Start 931222

                        new XElement("setting",
                            new XAttribute("Name", "CustomerName"),
                            new XElement("Value", Global_Cls.CustomerName.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "CoName"),
                            new XElement("Value", Global_Cls.CoName.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "CoNationalCode"),
                            new XElement("Value", Global_Cls.CoNationalCode.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "CoAddress"),
                            new XElement("Value", Global_Cls.CoAddress.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "CoTel"),
                            new XElement("Value", Global_Cls.CoTel.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "CoMobile"),
                            new XElement("Value", Global_Cls.CoMobile.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "CoEmail"),
                            new XElement("Value", Global_Cls.CoEmail.ToString())
                        )
                    //Main End 931222

                    );

                XmlMain.Save(@"MainConfig.xml");
            }

        }


        public static void WriteToParameter(string StrEnter, StringCollection StrColect)
        {
            int i = 0;
            StrColect.Clear();
            while (StrEnter.Length > 0)
            {
                StrColect.Insert(i, StrEnter.Substring(0, StrEnter.IndexOf(";")));
                StrEnter = StrEnter.Remove(0, StrEnter.IndexOf(";") + 1);
                i++;
            }
        }

        public static string ReadFromParameter(StringCollection StrColect)
        {
            string Result = "";
            for (int i = 0; i < StrColect.Count; i++)
                Result += StrColect[i].ToString() + ";";
            return Result;
        }
        

        #endregion



    }
}

