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
    public partial class RstPass_frm : Form
    {
        public RstPass_frm()
        {
            InitializeComponent();
        }
        
        public bool Edit_Enter;
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Edit_Enter)
            {
                if (textBox_PrePass.Text != DeCodePassRestore(Global_Cls.PssRstrr))
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "رمز قبلی اشتباه می باشد. دوباره آنرا وارد نمایید");
                    textBox_PrePass.Focus();
                    return;
                }
                if (textBox_ReNewPass.Text != textBox_NewPass.Text)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "رمزی که دوباره وارد شده اشتباه می باشد. دوباره آنرا وارد نمایید");
                    textBox_ReNewPass.Focus();
                    return;
                }

                Global_Cls.PssRstrr = CodePassRestore(textBox_ReNewPass.Text);
            }
            else 
            {
                if (textBox_Pass.Text == DeCodePassRestore(Global_Cls.PssRstrr))
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "All BackUp Files(*.bak)|*.bak";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        Function_Cls.SetRestoreDBAll(dlg.FileName);
                        //SetDataSet_GridViewFiles();
                    }
                }
                else
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "رمزی که وارد شده اشتباه می باشد. دوباره آنرا وارد نمایید");
                    textBox_Pass.Focus();
                    return;
                }
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RstPass_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }

        private string CodePassRestore(string PassRst)
        {
            string Result="";
            for (int i=0;i<PassRst.Length;i++) 
                Result += Convert.ToChar(PassRst[i]+'D');
            return Result;
        }

        private string DeCodePassRestore(string PassRst)
        {
            string Result = "";
            for (int i = 0; i < PassRst.Length; i++)
                Result += Convert.ToChar(PassRst[i] - 'D');
            return Result;
        }
    }
}
