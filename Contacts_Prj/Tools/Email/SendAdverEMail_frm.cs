using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Contacts_Prj.Properties;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

namespace Contacts_Prj
{
    public partial class SendAdverEMail_frm : Form
    {
        public SendAdverEMail_frm(string Text)
        {
            InitializeComponent();
            textBox_EMailText.Text = Text;
        }
        
        #region Button&UI
        public string MobileStr;
        private void SendAdverEMail_frm_Load(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            var hh = from prd in DCMD.TBL_PersonTelMobs
                     where prd.Email != ""
                     select new
                     {
                         prd.PersonID,
                         prd.Email
                     };
            Recive_txt.DataSource = hh;
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        TextBox SmtpServer = new TextBox();
        
        ListBox AttachList = new ListBox();
        private void buttonItem_SendEMail_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Recive_txt.Text, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") && System.Text.RegularExpressions.Regex.IsMatch(Settings.Default.UserName.ToString(), @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
            {
                MessageBox.Show("یکی از ایمیل ها اشتباه وارد شده است.");
            }
            else
            {
                if (Settings.Default.UserName.ToString().EndsWith("@gmail.com"))
                {
                    SmtpServer.Text = "smtp.gmail.com";
                }
                else if (Settings.Default.UserName.ToString().EndsWith("@yahoo.com"))
                {
                    SmtpServer.Text = "smtp.mail.yahoo.com";
                }

                try
                {
                    Ping ping = new Ping();
                    PingReply pingStatus = ping.Send("google.com");
                    if (pingStatus.Status == IPStatus.Success)
                    {
                        MailMessage msg = new MailMessage(new MailAddress(Settings.Default.UserName.ToString()), new MailAddress(Recive_txt.Text));    //  Create a MailMessage object with a from and to address
                        msg.Subject = Subject_txt.Text; //  Add your subject
                        msg.SubjectEncoding = System.Text.Encoding.UTF8;
                        msg.Body = textBox_EMailText.Text;    //  Add the body of your message
                        msg.BodyEncoding = System.Text.Encoding.UTF8;
                        msg.IsBodyHtml = false; //  Does the body contain html

                        SmtpClient client = new SmtpClient(SmtpServer.Text, 587); //  Create an instance of SmtpClient with your smtp host and port
                        client.Credentials = new NetworkCredential(Settings.Default.UserName.ToString(), Settings.Default.Password.ToString()); //  Assign your username and password to connect to gmail
                        client.EnableSsl = false;  //  Enable SSL
                        if (Settings.Default.UserName.ToString().EndsWith("@gmail.com"))
                        {
                            client.EnableSsl = true;
                        }
                        if (Settings.Default.UserName.ToString().EndsWith("@yahoo.com"))
                        {
                            client.EnableSsl = false;
                        }

                        if (AttachList.Items.Count != 0)
                        {
                            foreach (object i in AttachList.Items)
                            {
                                msg.Attachments.Add(new Attachment(i.ToString()));
                            }
                        }
                        try
                        {
                            client.Send(msg);   //  Try to send your message;
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "ایمیل ارسال شد");
                            //MessageBox.Show("Message Sent.");
                        }
                        catch (SmtpException ex)
                        {
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "", ex.Message);
                            //MessageBox.Show(ex.Message);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "", ex.Message);
                }
            }
        }



        private void Recive_txt_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Recive_txt.Text, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
            {
                errorProvider1.RightToLeft = true;
                errorProvider1.SetError(Recive_txt, "ایمیل وارد شده اشتباه است.");
            }
            Global_Cls.GetFarsiOrLatinLanguage("Fa");
        }

        private void Attach_btn_Click(object sender, EventArgs e)
        {
            AttachList.Items.Clear();
            SendAdverAttach_frm Attach = new SendAdverAttach_frm();
            Attach.ShowDialog(this);
            try
            {
                labelFiles.Text = " تعداد " + Attach.CntCheck.ToString() + " فایل ";
            }
            catch { }
            try{
                TextReader tr = new StreamReader("Attachments.xml");
                String[] strItems = null;
                strItems = tr.ReadToEnd().Split(',');
                tr.Close(); tr.Dispose();
                foreach (string strItem in strItems)
                {
                    if (strItem != "") { AttachList.Items.Add(strItem); }
                }
            }
            catch { }
        }

        private void Recive_txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Recive_txt_Enter(object sender, EventArgs e)
        {
            Global_Cls.GetFarsiOrLatinLanguage("us");
        }

    }
}
