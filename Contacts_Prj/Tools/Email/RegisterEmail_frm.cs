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
    public partial class RegisterEmail_frm : Form
    {
        string _text = "";
        public RegisterEmail_frm(string Text)
        {
            InitializeComponent();
            _text = Text;
        }

       

        private void buttonX_OK_Click(object sender, EventArgs e)
        {
            if (UserName_txt.Text == null || Password_txt.Text == null)
            {
                MessageBox.Show("پسورد یا نام کاربری خالی است");
            }
            else
            {
                if (Remember_check.Checked == true)
                {
                    Properties.Settings.Default.UserName = UserName_txt.Text;
                    Properties.Settings.Default.Password = Password_txt.Text;
                    Properties.Settings.Default.Save();
                    SendAdverEMail_frm email = new SendAdverEMail_frm(_text);
                    this.Hide();
                    email.ShowDialog();
                }
                else
                {
                    SendAdverEMail_frm email = new SendAdverEMail_frm(_text);
                    this.Hide();
                    email.ShowDialog();
                }

            }
        }

        
        private void buttonX_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterEmail_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                buttonX_OK_Click(this, null);
        }
        private void UserName_txt_Leave(object sender, EventArgs e)
        {
            //if (Sender_txt.Text.EndsWith("@gmail.com"))
            //{
            //    SmtpServer.Text = "smtp.gmail.com";
            //}
            //else if (Sender_txt.Text.EndsWith("@yahoo.com"))
            //{
            //    SmtpServer.Text = "smtp.mail.yahoo.com";
            //}

            
            e2.RightToLeft = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(UserName_txt.Text, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
            {   
                
                e2.SetError(UserName_txt, "ایمیل وارد شده اشتباه است.");
            }
           
        }

        private void RegisterEmail_frm_Load(object sender, EventArgs e)
        {
            UserName_txt.Text = Properties.Settings.Default.UserName.ToString();
            Password_txt.Text = Properties.Settings.Default.Password.ToString();
        }

        private void UserName_txt_TextChanged(object sender, EventArgs e)
        {
            e2.Clear();
        }

        


    }
}
