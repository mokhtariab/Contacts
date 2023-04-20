using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Contacts_Prj
{
    public partial class SendAdverAttach_frm : Form
    {
        public SendAdverAttach_frm()
        {
            InitializeComponent();
        }

        

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (float.Parse(TotalFile_lbl.Text) > 15000)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "حجم فایل (ها) بیش از حد مجاز می باشد");
                return;
            }

            try
            {
                TextWriter tw = new StreamWriter("Attachments.xml");
                String strItems = "";

                foreach (ListViewItem strObject in listViewAttach.Items)
                {
                    strItems += strObject.Text + ",";
                }

                tw.Write(strItems);
                tw.Close();
                tw.Dispose();
                this.Close();
            }
            catch { }
        }

        public int CntCheck = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Multiselect = true;
            if (open1.ShowDialog() == DialogResult.OK)
            {
                foreach (object FName in open1.FileNames)
                {
                    listViewAttach.Items.Add(FName.ToString());
                    var size = new FileInfo(open1.FileName).Length/1024;
                    listViewAttach.Items[CntCheck].SubItems.Add(size.ToString());
                    CntCheck++;
                    TotalFile_lbl.Text = (float.Parse(TotalFile_lbl.Text) + size).ToString();
                }
                
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TotalFile_lbl.Text = (float.Parse(TotalFile_lbl.Text) - float.Parse(listViewAttach.SelectedItems[0].SubItems[1].Text)).ToString();
            listViewAttach.Items.Remove(listViewAttach.SelectedItems[0]);
            CntCheck--;
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            listViewAttach.Items.Clear();
            CntCheck = 0;
            TotalFile_lbl.Text = "0";
        }
        
    }
}