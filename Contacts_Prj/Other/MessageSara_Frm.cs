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
    public partial class MessageSara_Frm : Form
    {
        public MessageSara_Frm()
        {
            InitializeComponent();
        }

        private void MessageSara_Frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
            if (Height == 225) Height = 130;
            else Height = 225;
        }



    }
}
