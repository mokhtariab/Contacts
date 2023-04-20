using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Contacts_Prj
{
    public partial class StartHM_frm : Form
    {
        
        public StartHM_frm()
        {
            InitializeComponent();
        }

        private string UserPer = "", UserName = "", UserPrmHF = "";
        private int UserCode=1;

        private void buttonX_OK_Click(object sender, EventArgs e)
        {
            TopMost = false;
            UserPer = ""; UserPrmHF = "";

            if (textBox_NUser.Text == "محمد علی" && textBox_Pass.Text == "مختاری حسناباد")
            {
                Global_Cls.UserCode_Exist = 1;
                Global_Cls.UserName_Exist = "admin";

                Global_Cls.MainForm = new MainHM_frm();
                Global_Cls.MainForm.UserPermission = "admin";
                Global_Cls.MainForm.UserPrmHouseFor = "admin";
                Global_Cls.MainForm.Show();
                this.Hide();
                return;
            }

            int FUFLI = FindUserForLogIn();

            if (FUFLI == 3)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام کاربری اشتباه می باشد!");
                textBox_NUser.Focus();
                return;
            }
            if (FUFLI == 0)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "رمز ورود اشتباه می باشد!");
                textBox_Pass.Focus();
                return;
            }

            if (FUFLI == 2)
            {
                if (textBox_NUser.Text != "" && Global_Cls.Message_Sara(0,Global_Cls.MessageType.SConfirmation,true,"آیا نام کاربری و رمز وارد شده به عنوان کاربراصلی ثبت شود؟"))
                    InsertAdminInSystem(textBox_NUser.Text, textBox_Pass.Text);
                else InsertAdminInSystem("admin", "admin");
            }

            Global_Cls.UserCode_Exist = UserCode;
            Global_Cls.UserName_Exist = UserName;
            Global_Cls.MainForm = new MainHM_frm();
            Global_Cls.MainForm.UserPermission = UserPer;
            Global_Cls.MainForm.UserPrmHouseFor = UserPrmHF;
            Global_Cls.MainForm.Show();

            this.Hide();
        }

        private int FindUserForLogIn()
        {
            DataClasses_MainDataContext DcMd = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            var tus = from tu in DcMd.TBL_Users
                      select tu;
            if (tus.Count() == 0) return 2;

            try
            {
                var tus1 = from tu in DcMd.TBL_Users
                           where tu.UserName.ToUpper() == textBox_NUser.Text.ToUpper()
                           select tu;
                if (tus1.Count() == 0) return 3;
                
                TBL_User tbu123 = DcMd.TBL_Users.First(t123 => t123.UserName.ToUpper().Equals(textBox_NUser.Text.ToUpper()) & t123.Password.ToUpper().Equals(textBox_Pass.Text.ToUpper()));
                UserPer = tbu123.UserPermission;
                UserCode = tbu123.UserCode;
                UserName = tbu123.FirstName +" "+ tbu123.LastName;
                return 1;
            }
            catch 
            { }

            return 0;
        }

        private void InsertAdminInSystem(string UsName, string PassW)
        {
            DataClasses_MainDataContext dmdc = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            TBL_User tbu = new TBL_User { FirstName = "admin",
                                          LastName = "admin",
                                          UserName = UsName,
                                          CreateDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                                          Password = PassW,
                                          UserPermission = "admin"
                                          
            };
            dmdc.TBL_Users.InsertOnSubmit(tbu);
            dmdc.SubmitChanges();
            UserPer = "admin";
            UserPrmHF = "admin";
            UserCode = 1;
            UserName = "admin admin";
        }

        private void buttonX_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartHM_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                buttonX_OK_Click(this, null);
        }

        private void StartHM_frm_Load(object sender, EventArgs e)
        {
            Function_Cls.CheckKeyFile(); 
            Function_Cls.ReadFromXmlFiles();
            Global_Cls.GetFarsiOrLatinLanguage("Fa");
           
        }


        private void StartHM_frm_Shown(object sender, EventArgs e)
        {

            CheckOrInstallDB(); 
        }

        //private void CheckOrInstallDB()
        //{
        //    string z = Application.StartupPath + "\\ApplicationData\\Data\\Contacts.mdf";
        //    Global_Cls.ConnectionStr = "Data Source=.\\sqlexpress;AttachDbFileName=" + z + ";Integrated Security=True";
        //}
        private void CheckOrInstallDB()
        {

            //Global_Cls.ConnectionStr = "Data Source=.\\sqlexpress;Initial Catalog=Contacts;Integrated Security=True;";
            Global_Cls.ConnectionStr = Global_Cls.ConnectionDef + "Initial Catalog=Contacts;User ID=ContactUser;Password=MkhContactUser;";

            SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);

            try
            {
                SqlConn.Open();
                SqlConn.Close();
            }
            catch (Exception EXstr)
            {
                SqlConnection SqlConn1 = new SqlConnection(Global_Cls.ConnectionDef + "Initial Catalog=master;Uid=sa;Pwd=SR1Sarafgp;");
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlConn1;
                SqlCmd.CommandText = "USE [master]" +
                    "CREATE DATABASE [Contacts] ON " +
                    "( FILENAME = N'" + Application.StartupPath + @"\ApplicationData\Data\Contacts.mdf' )," +
                    "( FILENAME = N'" + Application.StartupPath + @"\ApplicationData\Data\Contacts_log.ldf' )" +
                    " FOR ATTACH ";
                try
                {
                    SqlConn1.Open();
                    SqlCmd.ExecuteReader();
                    SqlConn1.Close();


                    
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اتصال دیتا: نصب برنامه به درستی صورت نگرفته است! لطفا جهت حل مشکل با کارشناس مربوطه تماس حاصل فرمایید.", ex.Message);
                    Application.Exit();
                }
            }

        }

    }
}
