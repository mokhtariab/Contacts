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
    public partial class SMSMobSelect_frm : Form
    {
        public SMSMobSelect_frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        private void ShowTelGroup()
        {
            var PT = from prd in DCDC.TBL_GroupTelMobs
                     select new { prd.GroupID, prd.GroupName };
            comboBoxGroup.DataSource = PT;
        }


        private void ShowTelMob()
        {
            var SU = from prd in DCDC.TBL_PersonTelMobs
                     select prd;
            dataGridView_TelMobList.DataSource = SU;
        }

        private void SMSMobSelect_frm_Load(object sender, EventArgs e)
        {
            //string UPer = Global_Cls.MainForm.UserPermission;
            //if (UPer != "" && UPer != "admin")
            //{
            //    if (UPer.Contains(bubbleButton_TMNew.Name)) bubbleButton_TMNew.Enabled = false;
            //    if (UPer.Contains(bubbleButton_TMEdit.Name)) bubbleButton_TMEdit.Enabled = false;
            //    if (UPer.Contains(bubbleButton_TMDel.Name)) bubbleButton_TMDel.Enabled = false;
            //    if (UPer.Contains(bubbleButton_TMSMS.Name)) bubbleButton_TMSMS.Enabled = false;
            //    if (UPer.Contains(bubbleButton_TMRepTel.Name)) bubbleButton_TMRepTel.Enabled = false;
            //}

            ////codeing
            //if (!Global_Cls.SoftwareCode.Contains("+S"))
            //    bubbleButton_TMSMS.Enabled = false;
            ////codeing

            ShowTelGroup();
            ShowTelMob();
        }
        public string MobileReturn = "";
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            MobileReturn = "";
            if (rbSingle.Checked)
                MobileReturn = textBoxSingle.Text + ";";
            else if (rbGroup.Checked)
            {
                try
                {
                    if (int.Parse(comboBoxGroup.SelectedValue.ToString()) == 0)
                    {
                        var SU = from prd in DCDC.TBL_PersonTelMobs
                                 select prd.Mobile;


                        foreach (object hj in SU)
                            MobileReturn += hj + ";";
                    }
                    else
                    {
                        var SU = from prd in DCDC.TBL_PersonTelMobs
                                 join k in DCDC.TBL_GroupPersons on prd.PersonID equals k.PersonID //into h1 
                                 where k.GroupID == int.Parse(comboBoxGroup.SelectedValue.ToString())
                                 select prd.Mobile;


                        foreach (object hj in SU)
                            MobileReturn += hj + ";";
                    }
                }
                catch 
                {
                }
            }
            else if (rbAllMob.Checked)
            {
                try
                {
                    for (int i = 0; i < dataGridView_TelMobList.RowCount; i++)
                    {
                        try
                        {
                            if (bool.Parse(dataGridView_TelMobList.Rows[i].Cells["Select"].Value.ToString()) == true)
                                MobileReturn += dataGridView_TelMobList.Rows[i].Cells["Mobile"].Value.ToString() + ";";
                        }
                        catch { }
                    }
                }
                catch
                {
                }
            }
            Close();

        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
