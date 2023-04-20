using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contacts_Prj
{
    public partial class NEUser_frm : Form
    {
        public NEUser_frm()
        {
            InitializeComponent();
        }

        public int InsOrEdt;
        public int UserID;
        private string User_Name;
        
        public void UseFormInInsertOrEditMode(int InsertOrEdit)
        {
            if (InsertOrEdit == 1)
            {
                InsOrEdt = 1;
                labelX_PrePass.Visible = false;
                textBox_PrePass.Visible = false;
                this.ShowDialog();
            }

            if (InsertOrEdit == 2)
            {
                InsOrEdt = 2;
                User_Name = textBox_UserName.Text;
                this.ShowDialog();
            }
        }

        private bool InsertUser()
        {
            try
            {
                DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

                var prd = from p in DCDC.TBL_Users
                          where p.UserName == textBox_UserName.Text
                          select p;
                if (prd.Count() != 0)
                    return false;

                TBL_User thf = new TBL_User
                {
                    UserName = textBox_UserName.Text,
                    FirstName = textBox_Name.Text,
                    LastName = textBox_Family.Text,
                    Password = textBox_ReNewPass.Text,
                    CreateDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    UserPermission = "buttonItem_Users,buttonItem_HFRecive,buttonItem_CFRecive,buttonItem_DesignRep,buttonItem_AgencySet,buttonItem_SetSystem,buttonItem_Rst,",
                    //UserPrmHouseFor = Function_Cls.ReadFromParameter(Global_Cls.HouseFor)
                };
                DCDC.TBL_Users.InsertOnSubmit(thf);
                DCDC.SubmitChanges();
            }
            catch
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!");
                return false;
            }
            return true;
        }


        private int EditUser()
        {
            try
            {
                DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

                //Check PrePassword Entry
                var PrePass = from pp in DCDC.TBL_Users
                              where (pp.UserCode == UserID) && (pp.Password != textBox_PrePass.Text)
                              select pp;
                if (PrePass.Count() != 0)
                    return 0;

                //Search For Username's Duplex
                if (textBox_UserName.Text != User_Name)
                {
                    var UName = from UN in DCDC.TBL_Users
                                where UN.UserName == textBox_UserName.Text
                                select UN;
                    if (UName.Count() != 0)
                        return 1;
                }


                //Update In Users Table
                TBL_User tbu = DCDC.TBL_Users.First(hu => hu.UserCode.Equals(UserID));
                tbu.FirstName = textBox_Name.Text;
                tbu.LastName = textBox_Family.Text;
                tbu.UserName = textBox_UserName.Text;
                tbu.Password = textBox_ReNewPass.Text;
                DCDC.SubmitChanges();
            }
            catch
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!");
                return 0;
            }

            return 2;
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام را وارد نمایید");
                textBox_Name.Focus();
                return;
            }
            if (textBox_Family.Text == "")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام خانوادگی را وارد نمایید");
                textBox_Family.Focus();
                return;
            }
            if (textBox_UserName.Text == "")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام کاربری را وارد نمایید");
                textBox_UserName.Focus();
                return;
            }
            if (textBox_ReNewPass.Text != textBox_NewPass.Text)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "رمزی که دوباره وارد شده اشتباه می باشد. دوباره آنرا وارد نمایید");
                textBox_ReNewPass.Focus();
                return;
            }

            if (InsOrEdt == 1)
            {
                if (!InsertUser())
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام کاربری تکراری است. دوباره آنرا وارد نمایید");
                    textBox_UserName.Focus();
                    return;
                }
            }
            if (InsOrEdt == 2)
            {
                int EU = EditUser();
                if (EU == 0)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "رمز قبلی اشتباه می باشد. دوباره آنرا وارد نمایید");
                    textBox_PrePass.Focus();
                    return;
                }
                else
                    if (EU == 1)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام کاربری تکراری است. دوباره آنرا وارد نمایید");
                        textBox_UserName.Focus();
                        return;
                    }
            }
            Close();

        }

        private void SearchHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }
    }
}
