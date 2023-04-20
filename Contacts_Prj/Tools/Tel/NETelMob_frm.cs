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
    public partial class NETelMob_frm : Form
    {
        public NETelMob_frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        public int InsOrEdt, PersonID;
        public string FName, LName;


        public void UseFormInInsertOrEditMode(int InsertOrEdit)
        {
            if (InsertOrEdit == 1)
            {
                InsOrEdt = 1;
                this.ShowDialog();
            }

            if (InsertOrEdit == 2)
            {
                InsOrEdt = 2;
                FName = textBox_Name.Text;
                LName = textBox_Family.Text;
                this.ShowDialog();
            }
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

            if (textBox_Tel.Text == "" && textBox_Mobile.Text == "")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "تلفن ثابت و یا موبایل را وارد نمایید");
                textBox_Tel.Focus();
                return;
            }

            //int j;
            //for (j = 0; j < itemPanel_HouseFor.Items.Count; j++)
            //{
            //    if (!(itemPanel_HouseFor.Items[j] as DevComponents.DotNetBar.CheckBoxItem).Checked) continue;
            //    else break;
            //}
            //if (j == itemPanel_HouseFor.Items.Count)
            //{
            //    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "حداقل یک گروه را مشخص نمایید");
            //    itemPanel_HouseFor.Focus();
            //    return;
            //}

            if (InsOrEdt == 1)
            {
                int Rtn = Global_Cls.InsertPerTelMob(textBox_Name.Text, textBox_Family.Text, textBox_Tel.Text, textBox_Mobile.Text, textBox_Email.Text,
                    textBox_Address.Text, textBox_Desc.Text);
                if (Rtn == 1)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام و نام خانوادگی شخص تکراری است. دوباره آنرا وارد نمایید");
                    textBox_Name.Focus();
                    return;
                }
                else if (Rtn == 2)
                {
                    textBox_Mobile.Focus();
                    return;
                }
            }
            if (InsOrEdt == 2)
            {
                int EU = EditPerTelMob();
                if (EU == 1)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام و نام خانوادگی شخص تکراری است. دوباره آنرا وارد نمایید");
                    textBox_Name.Focus();
                    return;
                }
            }


            if (this.PersonID == 0)
                this.PersonID = DCDC.TBL_PersonTelMobs.Max(h=>h.PersonID);
            try
            {
                TBL_GroupPerson tgp = DCDC.TBL_GroupPersons.First(th => th.PersonID == this.PersonID);
                DCDC.TBL_GroupPersons.DeleteOnSubmit(tgp);
                DCDC.SubmitChanges();
            }
            catch { }

            for (int i = 0; i < itemPanel_Group.Items.Count; i++)
            {
                if ((itemPanel_Group.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                {
                    TBL_GroupPerson gh = new TBL_GroupPerson
                       {
                           PersonID = this.PersonID,
                           GroupID = int.Parse((itemPanel_Group.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Name)
                       };
                    DCDC.TBL_GroupPersons.InsertOnSubmit(gh);
                    DCDC.SubmitChanges();
                }
            }


            Close();
        }

        private int EditPerTelMob()
        {
            try
            {
                //Search For name_family's Duplex

                if (textBox_Name.Text != FName || textBox_Family.Text != LName)
                {
                    var FLName = from FLN in DCDC.TBL_PersonTelMobs
                                 where (FLN.FirstName == textBox_Name.Text) && (FLN.LastName == textBox_Family.Text)
                                 select FLN;
                    if (FLName.Count() != 0)
                        return 1;
                }


                //Update In PerTelMob Table
                TBL_PersonTelMob tptm = DCDC.TBL_PersonTelMobs.First(pt => pt.PersonID.Equals(PersonID));
                tptm.FirstName = textBox_Name.Text;
                tptm.LastName = textBox_Family.Text;
                tptm.Telephone = textBox_Tel.Text;
                tptm.Mobile = textBox_Mobile.Text;
                tptm.Telephone2 = textBox_Tel2.Text;
                tptm.Mobile2 = textBox_Mobile2.Text;
                tptm.Address = textBox_Address.Text;
                tptm.Email = textBox_Email.Text;
                tptm.Fax = textBox_Fax.Text;
                tptm.Description = textBox_Desc.Text;
                DCDC.SubmitChanges();
            }
            catch
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!");
                return 0;
            }

            return 2;
        }


        private void NETelMob_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        private void NETelMob_frm_Load(object sender, EventArgs e)
        {
            var hhg = from hg in DCDC.TBL_GroupTelMobs where hg.GroupID != 0 orderby hg.GroupID select hg.GroupID;
            
            foreach (int item in hhg)
            {
                DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                try
                {
                    Ch.Name = item.ToString();
                    Ch.Text = DCDC.TBL_GroupTelMobs.First(f => f.GroupID == item).GroupName;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanel_Group.Items.Add(Ch);
                    itemPanel_Group.Refresh();
                    try
                    {
                        DCDC.TBL_GroupPersons.First(f => f.GroupID == item && f.PersonID == PersonID);
                        Ch.Checked = true;
                    }
                    catch { }
                }
                catch { }
            }
        }
    }
}
