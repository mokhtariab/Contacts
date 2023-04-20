using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Contacts_Prj.Properties;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Data.SqlClient;

namespace Contacts_Prj
{
    public partial class Setting_frm : Form
    {
        public Setting_frm()
        {
            InitializeComponent();
        }

        private bool CloseOK = false;


        #region Load & UI
        private void Setting_frm_Load(object sender, EventArgs e)
        {
            

            treeView_Setting.ExpandAll();
            //TreeNodeMouseClickEventArgs a = new TreeNodeMouseClickEventArgs(treeView_Setting.SelectedNode, MouseButtons.Left, 1, 0, 0);
            //treeView_Setting_NodeMouseClick(this, a);



            //sms start
            InitializeComboBoxSMS();

            cmbPort.Text = Global_Cls.SMSPort.ToString();
            cmbBaudRate.Text = Global_Cls.SMSBaudRate.ToString();
            cmbDataBits.Text = Global_Cls.SMSDataBits.ToString();
            cmbParity.SelectedIndex = Global_Cls.SMSParity;
            cmbStopBits.SelectedIndex = Global_Cls.SMSStopBits - 1;
            cmbFlowControl.SelectedIndex = Global_Cls.SMSFlowControl;
            cmbTimeOut.Text = Global_Cls.SMSTimeOut.ToString();

            cmbEncoding.SelectedIndex = Global_Cls.SMSEncoding;
            cmbLongMsg.SelectedIndex = Global_Cls.SMSLongMsg;
            chkDeliveryReport.Checked = Global_Cls.SMSDeliveryReport;

            //new 930925
            radioButtonInternet.Checked = Global_Cls.SMSSet;
            radioButtonGSM.Checked = !radioButtonInternet.Checked;
            textBoxUserName.Text = Global_Cls.IntUserName;
            textBoxPassword.Text = Global_Cls.IntPassword;
            textBoxTelNumber.Text = Global_Cls.IntTelNumber;
            //new 930925

            //sms end 



            //BkpRst start
            label_BkpAuto.Text = Global_Cls.BkpAutoRoot;
            radioButton_BkpAuto.Checked = (Global_Cls.BkpExitType == 2);
            radioButton_BkpNonAuto.Checked = (Global_Cls.BkpExitType == 1);
            radioButton_BkpNo.Checked = (Global_Cls.BkpExitType == 0);
            checkBox_BRPicFilm.Checked = Global_Cls.BkpRstPicsFilms;
            checkBox_BRDesignRep.Checked = Global_Cls.BkpRstDesignReport;
            //BkpRst end


            //Main Start

            textBox_CName.Text = Global_Cls.CustomerName;
            textBox_CoName.Text = Global_Cls.CoName;
            textBox_CNationalCode.Text = Global_Cls.CoNationalCode;
            textBox_Address.Text = Global_Cls.CoAddress;
            textBox_Tel.Text = Global_Cls.CoTel;
            textBox_mobile.Text = Global_Cls.CoMobile;
            textBox_EMail.Text = Global_Cls.CoEmail;

            //Main End

        }

        private void InitializeComboBoxSMS()
        {
            //-------------------------------------
            //Initialize COM Port DropDown List
            //-------------------------------------
            cmbPort.Items.Add("Select Port");
            for (int i = 1; i <= 256; i++)
            {
                cmbPort.Items.Add("COM" + i.ToString());
            }
            cmbPort.SelectedIndex = 0;


            //--------------------------------------
            //Initialize BaudRate DropDown List
            //--------------------------------------
            cmbBaudRate.Items.Add("110");
            cmbBaudRate.Items.Add("300");
            cmbBaudRate.Items.Add("1200");
            cmbBaudRate.Items.Add("2400");
            cmbBaudRate.Items.Add("4800");
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("14400");
            cmbBaudRate.Items.Add("19200");
            cmbBaudRate.Items.Add("38400");
            cmbBaudRate.Items.Add("57600");
            cmbBaudRate.Items.Add("115200");
            cmbBaudRate.Items.Add("230400");
            cmbBaudRate.Items.Add("460800");
            cmbBaudRate.Items.Add("921600");
            //cmbBaudRate.SelectedIndex = cmbBaudRate.FindString(((int)objSMS.BaudRate).ToString());

            //--------------------------------------
            //Initialize DataBits DropDown List
            //--------------------------------------
            cmbDataBits.Items.Add("4");
            cmbDataBits.Items.Add("5");
            cmbDataBits.Items.Add("6");
            cmbDataBits.Items.Add("7");
            cmbDataBits.Items.Add("8");
            //cmbDataBits.SelectedIndex = cmbDataBits.FindString(((int)objSMS.DataBits).ToString());


            //--------------------------------------
            //Initialize Parity DropDown List
            //--------------------------------------
            cmbParity.Items.Add("None");
            cmbParity.Items.Add("Odd");
            cmbParity.Items.Add("Even");
            cmbParity.Items.Add("Mark");
            cmbParity.Items.Add("Space");
            //cmbParity.SelectedIndex = (int)objSMS.Parity;


            //--------------------------------------
            //Initialize StopBits DropDown List
            //--------------------------------------
            cmbStopBits.Items.Add("1");
            cmbStopBits.Items.Add("2");
            cmbStopBits.Items.Add("1.5");
            //cmbStopBits.SelectedIndex = (int)objSMS.StopBits - 1;


            //--------------------------------------
            //Initialize FlowControl DropDown List
            //--------------------------------------
            cmbFlowControl.Items.Add("None");
            cmbFlowControl.Items.Add("Hardware");
            cmbFlowControl.Items.Add("Xon/Xoff");
            //cmbFlowControl.SelectedIndex = (int)objSMS.FlowControl;


            cmbEncoding.Items.Add("Default Alphabet");
            cmbEncoding.Items.Add("ANSI (8-bit)");
            cmbEncoding.Items.Add("Unicode (16-bit)");
            //cmbEncoding.SelectedIndex = (int)objSMS.Encoding;

            //----------------------------------------
            //Initialize Long Message DropDown List
            //----------------------------------------
            cmbLongMsg.Items.Add("Truncate");
            cmbLongMsg.Items.Add("Simple Split");
            cmbLongMsg.Items.Add("Formatted Split");
            cmbLongMsg.Items.Add("Concatenate");
        }



        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }
        #endregion



        #region OK

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            //panel_Date_Leave(this, null);

            //sms start

            Global_Cls.SMSPort = cmbPort.Text;
            Global_Cls.SMSBaudRate = Convert.ToInt32(cmbBaudRate.Text);
            Global_Cls.SMSDataBits = Convert.ToInt32(cmbDataBits.Text);
            Global_Cls.SMSParity = cmbParity.SelectedIndex;
            Global_Cls.SMSStopBits = cmbStopBits.SelectedIndex + 1;
            Global_Cls.SMSFlowControl = cmbFlowControl.SelectedIndex;
            Global_Cls.SMSTimeOut = Convert.ToInt32(cmbTimeOut.Text);

            Global_Cls.SMSEncoding = cmbEncoding.SelectedIndex;
            Global_Cls.SMSLongMsg = cmbLongMsg.SelectedIndex;
            Global_Cls.SMSDeliveryReport = chkDeliveryReport.Checked;

            //new 930925
            Global_Cls.SMSSet = radioButtonInternet.Checked;
            Global_Cls.IntUserName = textBoxUserName.Text;
            Global_Cls.IntPassword = textBoxPassword.Text;
            Global_Cls.IntTelNumber = textBoxTelNumber.Text;
            //new 930925

            //Agancy end


            //BkpRst start
            Global_Cls.BkpAutoRoot = label_BkpAuto.Text;
            if (radioButton_BkpAuto.Checked) Global_Cls.BkpExitType = 2;
            else if (radioButton_BkpNonAuto.Checked) Global_Cls.BkpExitType = 1;
            else Global_Cls.BkpExitType = 0;
            Global_Cls.BkpRstPicsFilms = checkBox_BRPicFilm.Checked;
            Global_Cls.BkpRstDesignReport = checkBox_BRDesignRep.Checked;
            //BkpRst end


            //Main Start 931222

            Global_Cls.CustomerName = textBox_CName.Text;
            Global_Cls.CoName = textBox_CoName.Text;
            Global_Cls.CoNationalCode = textBox_CNationalCode.Text;
            Global_Cls.CoAddress = textBox_Address.Text;
            Global_Cls.CoTel = textBox_Tel.Text;
            Global_Cls.CoMobile = textBox_mobile.Text;
            Global_Cls.CoEmail = textBox_EMail.Text;

            //Main End




            Function_Cls.WriteToXmlFiles();

            CloseOK = true;
            this.Close();

        }

        #endregion



        #region Other


        private void button_BkpAuto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.SelectedPath = label_BkpAuto.Text;
            if (dir.ShowDialog() == DialogResult.OK)
            {
                label_BkpAuto.Text = dir.SelectedPath;
            }
        }

        private void button_RstChangePass_Click(object sender, EventArgs e)
        {
            Function_Cls.Restore_Func(true);
        }

        private void treeView_Setting_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "NodeMain") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItemMain"];
            
            if (e.Node.Name == "Node_SetBkpRst") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetBkpRst"];

            if (e.Node.Name == "Node_Sms") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SMS"];
        }

        private void buttonTestCredit_Click(object sender, EventArgs e)
        {
            bool a = Global_Cls.SMSSet;
            Global_Cls.SMSSet = true;
            if (SMSClass.ConnectToPort())
            {
                double DCredit = SMSClass.GetCreditSMS(textBoxUserName.Text, textBoxPassword.Text);
                if (DCredit >= 1 && DCredit <= 10)
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال ", " کد اشکال : " + DCredit.ToString());
                else
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "مبلغ باقیمانده شارژ " + DCredit.ToString() + "ریال می باشد");
            }
            Global_Cls.SMSSet = a;
        }

        #endregion



    }
}


