namespace Contacts_Prj
{
    partial class NEUser_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NEUser_frm));
            this.ribbonBar_UChange = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx_1 = new DevComponents.DotNetBar.PanelEx();
            this.textBox_Family = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX_Familly = new DevComponents.DotNetBar.LabelX();
            this.labelX_Name = new DevComponents.DotNetBar.LabelX();
            this.panelEx_2 = new DevComponents.DotNetBar.PanelEx();
            this.textBox_ReNewPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_NewPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_PrePass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_UserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX_ReNewPass = new DevComponents.DotNetBar.LabelX();
            this.labelX_NewPass = new DevComponents.DotNetBar.LabelX();
            this.labelX_PrePass = new DevComponents.DotNetBar.LabelX();
            this.labelX_Username = new DevComponents.DotNetBar.LabelX();
            this.panelEx_1.SuspendLayout();
            this.panelEx_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar_UChange
            // 
            this.ribbonBar_UChange.AutoOverflowEnabled = true;
            this.ribbonBar_UChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar_UChange.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar_UChange.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK,
            this.buttonItem_Cancel});
            this.ribbonBar_UChange.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar_UChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_UChange.Name = "ribbonBar_UChange";
            this.ribbonBar_UChange.Size = new System.Drawing.Size(346, 75);
            this.ribbonBar_UChange.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_UChange.TabIndex = 1;
            // 
            // buttonItem_OK
            // 
            this.buttonItem_OK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_OK.FixedSize = new System.Drawing.Size(90, 55);
            this.buttonItem_OK.HotFontBold = true;
            this.buttonItem_OK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_OK.Image")));
            this.buttonItem_OK.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_OK.ImagePaddingHorizontal = 20;
            this.buttonItem_OK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_OK.Name = "buttonItem_OK";
            this.buttonItem_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_OK.SubItemsExpandWidth = 20;
            this.buttonItem_OK.Text = "تایید";
            this.buttonItem_OK.Tooltip = "F2";
            this.buttonItem_OK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(100, 55);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "انصراف";
            this.buttonItem_Cancel.Tooltip = "Esc";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // panelEx_1
            // 
            this.panelEx_1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_1.Controls.Add(this.textBox_Family);
            this.panelEx_1.Controls.Add(this.textBox_Name);
            this.panelEx_1.Controls.Add(this.labelX_Familly);
            this.panelEx_1.Controls.Add(this.labelX_Name);
            this.panelEx_1.Location = new System.Drawing.Point(10, 79);
            this.panelEx_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx_1.Name = "panelEx_1";
            this.panelEx_1.Size = new System.Drawing.Size(326, 72);
            this.panelEx_1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_1.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx_1.Style.BackColor2.Color = System.Drawing.Color.Transparent;
            this.panelEx_1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx_1.Style.ForeColor.Color = System.Drawing.Color.White;
            this.panelEx_1.Style.TextTrimming = System.Drawing.StringTrimming.None;
            this.panelEx_1.TabIndex = 0;
            // 
            // textBox_Family
            // 
            // 
            // 
            // 
            this.textBox_Family.Border.Class = "TextBoxBorder";
            this.textBox_Family.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_Family.Location = new System.Drawing.Point(18, 38);
            this.textBox_Family.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Family.MaxLength = 50;
            this.textBox_Family.Name = "textBox_Family";
            this.textBox_Family.Size = new System.Drawing.Size(172, 22);
            this.textBox_Family.TabIndex = 1;
            // 
            // textBox_Name
            // 
            // 
            // 
            // 
            this.textBox_Name.Border.Class = "TextBoxBorder";
            this.textBox_Name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_Name.Location = new System.Drawing.Point(18, 11);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Name.MaxLength = 30;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(172, 22);
            this.textBox_Name.TabIndex = 0;
            // 
            // labelX_Familly
            // 
            this.labelX_Familly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_Familly.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_Familly.Location = new System.Drawing.Point(221, 37);
            this.labelX_Familly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_Familly.Name = "labelX_Familly";
            this.labelX_Familly.Size = new System.Drawing.Size(93, 22);
            this.labelX_Familly.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_Familly.TabIndex = 0;
            this.labelX_Familly.Text = "نام خانوادگی:";
            // 
            // labelX_Name
            // 
            this.labelX_Name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_Name.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_Name.Location = new System.Drawing.Point(241, 10);
            this.labelX_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_Name.Name = "labelX_Name";
            this.labelX_Name.Size = new System.Drawing.Size(74, 22);
            this.labelX_Name.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_Name.TabIndex = 1;
            this.labelX_Name.Text = "نام:";
            // 
            // panelEx_2
            // 
            this.panelEx_2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_2.Controls.Add(this.textBox_ReNewPass);
            this.panelEx_2.Controls.Add(this.textBox_NewPass);
            this.panelEx_2.Controls.Add(this.textBox_PrePass);
            this.panelEx_2.Controls.Add(this.textBox_UserName);
            this.panelEx_2.Controls.Add(this.panel1);
            this.panelEx_2.Controls.Add(this.labelX_ReNewPass);
            this.panelEx_2.Controls.Add(this.labelX_NewPass);
            this.panelEx_2.Controls.Add(this.labelX_PrePass);
            this.panelEx_2.Controls.Add(this.labelX_Username);
            this.panelEx_2.Location = new System.Drawing.Point(10, 155);
            this.panelEx_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx_2.Name = "panelEx_2";
            this.panelEx_2.Size = new System.Drawing.Size(326, 152);
            this.panelEx_2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_2.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx_2.Style.BackColor2.Color = System.Drawing.Color.Transparent;
            this.panelEx_2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx_2.Style.ForeColor.Color = System.Drawing.Color.White;
            this.panelEx_2.Style.TextTrimming = System.Drawing.StringTrimming.None;
            this.panelEx_2.TabIndex = 1;
            this.panelEx_2.Text = "panelEx2";
            // 
            // textBox_ReNewPass
            // 
            // 
            // 
            // 
            this.textBox_ReNewPass.Border.Class = "TextBoxBorder";
            this.textBox_ReNewPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_ReNewPass.Location = new System.Drawing.Point(18, 120);
            this.textBox_ReNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ReNewPass.MaxLength = 20;
            this.textBox_ReNewPass.Name = "textBox_ReNewPass";
            this.textBox_ReNewPass.PasswordChar = '*';
            this.textBox_ReNewPass.Size = new System.Drawing.Size(172, 22);
            this.textBox_ReNewPass.TabIndex = 5;
            // 
            // textBox_NewPass
            // 
            // 
            // 
            // 
            this.textBox_NewPass.Border.Class = "TextBoxBorder";
            this.textBox_NewPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_NewPass.Location = new System.Drawing.Point(18, 90);
            this.textBox_NewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NewPass.MaxLength = 20;
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.PasswordChar = '*';
            this.textBox_NewPass.Size = new System.Drawing.Size(172, 22);
            this.textBox_NewPass.TabIndex = 4;
            // 
            // textBox_PrePass
            // 
            // 
            // 
            // 
            this.textBox_PrePass.Border.Class = "TextBoxBorder";
            this.textBox_PrePass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_PrePass.Location = new System.Drawing.Point(18, 59);
            this.textBox_PrePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_PrePass.MaxLength = 20;
            this.textBox_PrePass.Name = "textBox_PrePass";
            this.textBox_PrePass.PasswordChar = '*';
            this.textBox_PrePass.Size = new System.Drawing.Size(172, 22);
            this.textBox_PrePass.TabIndex = 3;
            // 
            // textBox_UserName
            // 
            // 
            // 
            // 
            this.textBox_UserName.Border.Class = "TextBoxBorder";
            this.textBox_UserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_UserName.Location = new System.Drawing.Point(18, 12);
            this.textBox_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_UserName.MaxLength = 20;
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(172, 22);
            this.textBox_UserName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(26, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 3);
            this.panel1.TabIndex = 6;
            // 
            // labelX_ReNewPass
            // 
            this.labelX_ReNewPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_ReNewPass.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_ReNewPass.Location = new System.Drawing.Point(196, 105);
            this.labelX_ReNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_ReNewPass.Name = "labelX_ReNewPass";
            this.labelX_ReNewPass.Size = new System.Drawing.Size(118, 44);
            this.labelX_ReNewPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_ReNewPass.TabIndex = 4;
            this.labelX_ReNewPass.Text = "رمز ورود را دوباره وارد نمایید:";
            this.labelX_ReNewPass.WordWrap = true;
            // 
            // labelX_NewPass
            // 
            this.labelX_NewPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_NewPass.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_NewPass.Location = new System.Drawing.Point(221, 85);
            this.labelX_NewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_NewPass.Name = "labelX_NewPass";
            this.labelX_NewPass.Size = new System.Drawing.Size(93, 22);
            this.labelX_NewPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_NewPass.TabIndex = 5;
            this.labelX_NewPass.Text = "رمز ورود جدید:";
            // 
            // labelX_PrePass
            // 
            this.labelX_PrePass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_PrePass.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_PrePass.Location = new System.Drawing.Point(221, 58);
            this.labelX_PrePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_PrePass.Name = "labelX_PrePass";
            this.labelX_PrePass.Size = new System.Drawing.Size(93, 22);
            this.labelX_PrePass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_PrePass.TabIndex = 2;
            this.labelX_PrePass.Text = "رمز ورود قبلی:";
            // 
            // labelX_Username
            // 
            this.labelX_Username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_Username.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_Username.Location = new System.Drawing.Point(221, 11);
            this.labelX_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_Username.Name = "labelX_Username";
            this.labelX_Username.Size = new System.Drawing.Size(93, 22);
            this.labelX_Username.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_Username.TabIndex = 3;
            this.labelX_Username.Text = "نام کاربری:";
            // 
            // NEUser_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 312);
            this.Controls.Add(this.panelEx_2);
            this.Controls.Add(this.panelEx_1);
            this.Controls.Add(this.ribbonBar_UChange);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "NEUser_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملیات کاربران";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchHouse_KeyPress);
            this.panelEx_1.ResumeLayout(false);
            this.panelEx_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_UChange;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.PanelEx panelEx_1;
        private DevComponents.DotNetBar.PanelEx panelEx_2;
        private DevComponents.DotNetBar.LabelX labelX_Familly;
        private DevComponents.DotNetBar.LabelX labelX_Name;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX_ReNewPass;
        private DevComponents.DotNetBar.LabelX labelX_NewPass;
        private DevComponents.DotNetBar.LabelX labelX_PrePass;
        private DevComponents.DotNetBar.LabelX labelX_Username;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_Family;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_ReNewPass;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_NewPass;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_PrePass;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_UserName;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_Name;
    }
}