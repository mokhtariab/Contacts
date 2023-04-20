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
    public partial class SMSLogView_frm : Form
    {
        public SMSLogView_frm()
        {
            InitializeComponent();
        }

        DataClassesSecondDataContext DCMD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        private void SMSLogView_frm_Load(object sender, EventArgs e)
        {
            ShowListLog(dataGridView_Log.RowCount - 1);
        }

        private void ShowListLog(int RowFocus)
        {
            var LS = from prd in DCMD.TBL_SendSMS
                     where prd.UserCode == Global_Cls.UserCode_Exist || Global_Cls.MainForm.UserPermission == "admin"
                     select new
                      {
                          prd.SMSCode,
                          prd.Mobile_No,
                          prd.MessageText,
                          StatusStr = ChangeSts( prd.Status ),
                          prd.UseName,
                          prd.SMS_Few,
                          prd.Description,
                          prd.SendDate,
                          prd.SendTime,
                          prd.Archive
                      };
            dataGridView_Log.DataSource = LS;

            for (int i = 0; i < dataGridView_Log.RowCount; i++)
            {
                try
                {
                    dataGridView_Log.Rows[i].Cells["Select"].Value = false;
                }
                catch { }
            }

            try
            {
                dataGridView_Log.CurrentCell = dataGridView_Log.Rows[RowFocus].Cells[dataGridView_Log.CurrentCell.ColumnIndex];
            }
            catch
            {
                try
                {
                    dataGridView_Log.CurrentCell = dataGridView_Log.Rows[0].Cells[8];
                }
                catch { }
            }
        }

        private string ChangeSts(int? STS)
        {
            if (STS == 0) return "در حال ارسال";
            if (STS == 1) return "ارسال شده";
            if (STS == 2) return "ارسال نشده";
            return "";
        }

        private void buttonItem_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_Log.RowCount == 0) return;

            int SelCount = dataGridView_Log.SelectedRows.Count;
            if (SelCount == 1)
            {
                int RFocus = dataGridView_Log.CurrentRow.Index;
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این پیامک حذف شود؟")) return;
                TBL_SendSMS tss = DCMD.TBL_SendSMS.First(th => th.SMSCode.Equals(Convert.ToInt32(dataGridView_Log.CurrentRow.Cells["SMSCode"].Value)));
                DCMD.TBL_SendSMS.DeleteOnSubmit(tss);
                DCMD.SubmitChanges();
                ShowListLog(RFocus - 1);
            }
            else
            {
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این " + SelCount.ToString() + " پیامک حذف شوند؟ ")) return;
                while (SelCount > 0)
                {
                    SelCount--;
                    TBL_SendSMS tss = DCMD.TBL_SendSMS.First(th => th.SMSCode.Equals(Convert.ToInt32(dataGridView_Log.SelectedRows[SelCount].Cells["SMSCode"].Value)));
                    DCMD.TBL_SendSMS.DeleteOnSubmit(tss);
                    DCMD.SubmitChanges();
                }
                ShowListLog(0);

            }


            //if (dataGridView_Log.RowCount == 0) return;

            //int RFocus = dataGridView_Log.CurrentRow.Index;
            //int SelCount = 0;

            //for (int i = 0; i < dataGridView_Log.RowCount; i++)
            //{
            //    try
            //    {
            //        if (dataGridView_Log.Rows[i].Cells["Select"].Value.ToString() == "True")
            //            SelCount++;
            //    }
            //    catch { }
            //}
            //if (SelCount == 0)
            //{
            //    ShowListLog(RFocus);
            //    return;
            //}

            //if (SelCount == 1)
            //{
            //    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این پیامک حذف شود؟")) return;
            //}
            //else
            //{
            //    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این " + SelCount.ToString() + " پیامک حذف شوند؟ ")) return;
            //}

            //for (int j = 0; j < dataGridView_Log.RowCount; j++)
            //{
            //    if (bool.Parse(dataGridView_Log.Rows[j].Cells["Select"].Value.ToString()))
            //    {
            //        TBL_SendSMS tss = DCMD.TBL_SendSMS.First(th => th.SMSCode.Equals(Convert.ToInt32(dataGridView_Log.CurrentRow.Cells["SMSCode"].Value)));
            //        DCMD.TBL_SendSMS.DeleteOnSubmit(tss);
            //        DCMD.SubmitChanges();
            //    }
            //}

            //ShowListLog(RFocus - 1);
        }

        private void buttonItem_Resend_Click(object sender, EventArgs e)
        {
            if (dataGridView_Log.RowCount == 0) return;

            int SelCount = dataGridView_Log.SelectedRows.Count;
            if (SelCount == 1)
            {
                int RFocus = dataGridView_Log.CurrentRow.Index;
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این پیامک دوباره ارسال شود؟")) return;
                int SMSID = Convert.ToInt32(dataGridView_Log.CurrentRow.Cells["SMSCode"].Value);
                TBL_SendSMS tss = DCMD.TBL_SendSMS.First(th => th.SMSCode.Equals(SMSID));
                tss.Status = 0;
                tss.Description = "";
                DCMD.SubmitChanges();
                ShowListLog(RFocus);
                SMSClass.SendList(SMSID);
            }
            else
            {
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این " + SelCount.ToString() + " پیامک دوباره ارسال شوند؟ ")) return;
                while (SelCount > 0)
                {
                    SelCount--;
                    TBL_SendSMS tss = DCMD.TBL_SendSMS.First(th => th.SMSCode.Equals(Convert.ToInt32(dataGridView_Log.SelectedRows[SelCount].Cells["SMSCode"].Value)));
                    tss.Status = 0;
                    tss.Description = "";
                    DCMD.SubmitChanges();
                }
                ShowListLog(0);
                SMSClass.SendList(0);
            }





            //if (dataGridView_Log.RowCount == 0) return;

            //int RFocus = dataGridView_Log.CurrentRow.Index;
            //int SelCount = 0;

            //for (int i = 0; i < dataGridView_Log.RowCount; i++)
            //{
            //    if (dataGridView_Log.Rows[i].Cells["Select"].Value!= null)
            //        SelCount++;
            //}
            //if (SelCount == 0)
            //{
            //    ShowListLog(RFocus);
            //    return;
            //}

            //if (SelCount == 1)
            //{
            //    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این پیامک دوباره ارسال شود؟")) return;
            //}
            //else
            //{
            //    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این " + SelCount.ToString() + " پیامک دوباره ارسال شوند؟ ")) return;
            //}

            //for (int j = 0; j < dataGridView_Log.RowCount; j++)
            //{
            //    if (bool.Parse(dataGridView_Log.Rows[j].Cells["Select"].Value.ToString()))
            //    {
            //        TBL_SendSMS tss = DCMD.TBL_SendSMS.First(th => th.SMSCode.Equals(Convert.ToInt32(dataGridView_Log.CurrentRow.Cells["SMSCode"].Value)));
            //        tss.Status = 0;
            //        tss.Description = "";
            //        DCMD.SubmitChanges();
            //    }
            //}

            //ShowListLog(RFocus - 1);
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                int RFocus = dataGridView_Log.CurrentRow.Index;
                ShowListLog(RFocus);
            }
            catch { }
        }
    }
}
