using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Contacts_Prj.Properties;


namespace Contacts_Prj
{
    public partial class NEMobGroup_frm : Form
    {
        bool _insOrEdit = true;
        int _groupCode = 0;
        public NEMobGroup_frm(bool InsOrEdit)
        {
            InitializeComponent();
            _insOrEdit = InsOrEdit;
        }

        public NEMobGroup_frm(bool InsOrEdit, int GroupCode, string GroupName)
        {
            InitializeComponent();
            _insOrEdit = InsOrEdit;
            _groupCode = GroupCode;
            textBox_GroupName.Text = GroupName;
        }


        private void button_OK_Click(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DS = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            if (_insOrEdit)
            {
                int GrpCode = DS.TBL_GroupTelMobs.Max(hj => hj.GroupID);
                TBL_GroupTelMob Group = new TBL_GroupTelMob()
                {
                    GroupID = GrpCode + 1,
                    GroupName = textBox_GroupName.Text
                };
                DS.TBL_GroupTelMobs.InsertOnSubmit(Group);
                DS.SubmitChanges();
            }
            else
            {
                TBL_GroupTelMob Group = DS.TBL_GroupTelMobs.First(fg => fg.GroupID == _groupCode);
                Group.GroupName = textBox_GroupName.Text;
                DS.SubmitChanges();
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NEMobGroup_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }
    }
}
