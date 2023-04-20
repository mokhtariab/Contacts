using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Contacts_Prj.Properties;

namespace Contacts_Prj
{
    public partial class ListUser_UC : UserControl
    {
        public ListUser_UC()
        {
            InitializeComponent();
        }

        private void ListUser_UC_Load(object sender, EventArgs e)
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(bubbleButton_UNew.Name)) bubbleButton_UNew.Enabled = false;
                if (UPer.Contains(bubbleButton_UEdit.Name)) bubbleButton_UEdit.Enabled = false;
                if (UPer.Contains(bubbleButton_UDel.Name)) bubbleButton_UDel.Enabled = false;
                if (UPer.Contains(bubbleButton_UAccess.Name)) bubbleButton_UAccess.Enabled = false;
                if (UPer.Contains(bubbleButton_URep.Name)) bubbleButton_URep.Enabled = false;
            }

            ShowUsers(0);
            try
            {
                dataGridView_UserList.CurrentCell = dataGridView_UserList.Rows[dataGridView_UserList.RowCount-1].Cells[dataGridView_UserList.CurrentCell.ColumnIndex];
            }
            catch { }
        }

        private void ShowUsers(int RowFocus)
        {
            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            var SU = from prd in DCDC.TBL_Users
                     select new
                     {
                         prd.UserCode,
                         prd.FirstName,
                         prd.LastName,
                         prd.UserName,
                         prd.Password,
                         CDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value)
                     };
            
            ListWhereSearch = " Where (1=1) ";
            try
            {
                if (textBox_UCode.Text != "")
                {
                    SU = SU.Where(i => i.UserCode == Convert.ToInt32(textBox_UCode.Text));
                    ListWhereSearch += " And (UserCode = " + textBox_UCode.Text + ")";
                }
            }
            catch { }

            if (textBox_UName.Text != "")
            {
                SU = SU.Where(i => i.FirstName.Contains(textBox_UName.Text));
                ListWhereSearch += " And (FirstName like N'%" + textBox_UName.Text + "%')";
            }

            if (textBox_UFamily.Text != "")
            {
                SU = SU.Where(i => i.LastName.Contains(textBox_UFamily.Text));
                ListWhereSearch += " And (LastName like N'%" + textBox_UFamily.Text + "%')";
            }

            if (textBox_UUserName.Text != "")
            {
                SU = SU.Where(i => i.UserName.Contains(textBox_UUserName.Text));
                ListWhereSearch += " And (UserName like N'%" + textBox_UUserName.Text + "%')";
            }
                
            dataGridView_UserList.DataSource = SU;
            gridControlUserList.DataSource = SU;
            try
            {
                dataGridView_UserList.CurrentCell = dataGridView_UserList.Rows[RowFocus].Cells[dataGridView_UserList.CurrentCell.ColumnIndex];
            }
            catch
            {
                try
                {
                    dataGridView_UserList.CurrentCell = dataGridView_UserList.Rows[0].Cells[0];
                }
                catch { }
            }

        }

        private void bubbleButton_UNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            NEUser_frm UCF = new NEUser_frm();
            UCF.UserID = Convert.ToInt32( dataGridView_UserList.CurrentRow.Cells[0].Value );

            int rowcnt = dataGridView_UserList.Rows.Count;
            int RFocus = dataGridView_UserList.CurrentRow.Index;
            
            UCF.UseFormInInsertOrEditMode(1);
            
            ShowUsers(RFocus);
            if (dataGridView_UserList.Rows.Count > rowcnt)
                dataGridView_UserList.CurrentCell = dataGridView_UserList.Rows[rowcnt].Cells[dataGridView_UserList.CurrentCell.ColumnIndex];
        }

        private void bubbleButton_UEdit_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            EditUserFunc();
        }

        private void EditUserFunc()
        {
            int RFocus = dataGridView_UserList.CurrentRow.Index;
            
            NEUser_frm UCF = new NEUser_frm();

            try
            {
                UCF.textBox_Name.Text = Convert.ToString(dataGridView_UserList.CurrentRow.Cells[1].Value);
                UCF.textBox_Family.Text = Convert.ToString(dataGridView_UserList.CurrentRow.Cells[2].Value);
                UCF.textBox_UserName.Text = Convert.ToString(dataGridView_UserList.CurrentRow.Cells[3].Value);
                UCF.UserID = Convert.ToInt32(dataGridView_UserList.CurrentRow.Cells[0].Value);

                UCF.UseFormInInsertOrEditMode(2);

                ShowUsers(RFocus);
            }
            catch { }
        }

        private void bubbleButton_UDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                int RFocus = dataGridView_UserList.CurrentRow.Index;
                DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                TBL_User thf = DCDC.TBL_Users.First(th => th.UserCode.Equals(Convert.ToInt32(dataGridView_UserList.CurrentRow.Cells[0].Value)));
                if (thf.UserPermission == "admin")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "امکان حذف کاربر اصلی وجود ندارد");
                    return;
                }
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا به حذف این کاربر اطمینان دارید؟"))
                {
                    DCDC.TBL_Users.DeleteOnSubmit(thf);
                    DCDC.SubmitChanges();
                    ShowUsers(RFocus-1);
                }
            }
            catch { }
        }

        private void dataGridView_UserList_DoubleClick(object sender, EventArgs e)
        {
            if (bubbleButton_UEdit.Enabled) EditUserFunc();
        }

        private void bubbleButton_UAccess_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            TBL_User thf = DCDC.TBL_Users.First(th => th.UserCode.Equals(Convert.ToInt32(dataGridView_UserList.CurrentRow.Cells[0].Value)));
            UserPermission_frm UPF = new UserPermission_frm();
            UPF.UserPermission_LoadDataAndForm(thf.UserCode);
        }

        

        DevComponents.DotNetBar.Controls.TextBoxX tbx = null;
        string ListWhereSearch = "";
        private void textBox_UCode_TextChanged(object sender, EventArgs e)
        {
            tbx = (DevComponents.DotNetBar.Controls.TextBoxX)sender;
            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            try
            {
                var SU = from prd in DCDC.TBL_Users
                         select new
                         {
                             prd.UserCode,
                             prd.FirstName,
                             prd.LastName,
                             prd.UserName,
                             prd.Password,
                             CDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value)
                         };
                
                ListWhereSearch = " Where (1=1) ";
                try
                {
                    if (textBox_UCode.Text != "")
                    {
                        SU = SU.Where(i => i.UserCode == Convert.ToInt32(textBox_UCode.Text));
                        ListWhereSearch += " And (UserCode = " + textBox_UCode.Text + ")";
                    }
                }
                catch { }

                if (textBox_UName.Text != "")
                {
                    SU = SU.Where(i => i.FirstName.Contains(textBox_UName.Text));
                    ListWhereSearch += " And (FirstName like N'%" + textBox_UName.Text + "%')";
                }

                if (textBox_UFamily.Text != "")
                {
                    SU = SU.Where(i => i.LastName.Contains(textBox_UFamily.Text));
                    ListWhereSearch += " And (LastName like N'%" + textBox_UFamily.Text + "%')";
                }

                if (textBox_UUserName.Text != "")
                {
                    SU = SU.Where(i => i.UserName.Contains(textBox_UUserName.Text));
                    ListWhereSearch += " And (UserName like N'%" + textBox_UUserName.Text + "%')";
                }
                
                dataGridView_UserList.DataSource = SU;
                gridControlUserList.DataSource = SU;
            }
            catch { }

        }

        private void dataGridView_UserList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                textBox_UCode.Text = "";
                textBox_UName.Text = "";
                textBox_UFamily.Text = "";
                textBox_UUserName.Text = "";
            }
        }

        private void dataGridView_UserList_Paint(object sender, PaintEventArgs e)
        {
            textBox_UCode.Width = dataGridView_UserList.Columns[0].Width - 2;
            textBox_UName.Width = dataGridView_UserList.Columns[1].Width - 2;
            textBox_UFamily.Width = dataGridView_UserList.Columns[2].Width - 2;
            textBox_UUserName.Width = dataGridView_UserList.Columns[3].Width - 2;


            textBox_UCode.Left = dataGridView_UserList.Left + 40;
            textBox_UName.Left = textBox_UCode.Left + dataGridView_UserList.Columns[3].Width;
            textBox_UFamily.Left = textBox_UName.Left + dataGridView_UserList.Columns[2].Width;
            textBox_UUserName.Left = textBox_UFamily.Left + dataGridView_UserList.Columns[1].Width;
        }

        private void bubbleButton_URep_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            gridControlUserList.ShowPrintPreview();
        }


    }
}
