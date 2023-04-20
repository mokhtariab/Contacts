namespace Contacts_Prj
{
    partial class SendAdverSMS_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendAdverSMS_frm));
            this.panel_SelectMobile = new DevComponents.DotNetBar.PanelEx();
            this.btnDelAll = new DevComponents.DotNetBar.ButtonX();
            this.listBox_mobile = new System.Windows.Forms.ListBox();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.panel_Text = new DevComponents.DotNetBar.PanelEx();
            this.textBox_SMSText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonBar_SdAvSMS = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_Log = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_SendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_AdverPrint = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.panel_SelectMobile.SuspendLayout();
            this.panel_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_SelectMobile
            // 
            this.panel_SelectMobile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_SelectMobile.Controls.Add(this.btnDelAll);
            this.panel_SelectMobile.Controls.Add(this.listBox_mobile);
            this.panel_SelectMobile.Controls.Add(this.btnDel);
            this.panel_SelectMobile.Controls.Add(this.btnAdd);
            this.panel_SelectMobile.Controls.Add(this.reflectionImage2);
            this.panel_SelectMobile.Controls.Add(this.reflectionImage1);
            this.panel_SelectMobile.Location = new System.Drawing.Point(4, 350);
            this.panel_SelectMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_SelectMobile.Name = "panel_SelectMobile";
            this.panel_SelectMobile.Size = new System.Drawing.Size(344, 125);
            this.panel_SelectMobile.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_SelectMobile.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_SelectMobile.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_SelectMobile.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_SelectMobile.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_SelectMobile.Style.ForeColor.Color = System.Drawing.Color.Black;
            this.panel_SelectMobile.Style.GradientAngle = 90;
            this.panel_SelectMobile.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_SelectMobile.TabIndex = 6;
            this.panel_SelectMobile.Text = "انتخاب موبایل ها جهت ارسال";
            // 
            // btnDelAll
            // 
            this.btnDelAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAll.Image")));
            this.btnDelAll.Location = new System.Drawing.Point(62, 87);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(79, 25);
            this.btnDelAll.TabIndex = 9;
            this.btnDelAll.Text = "حذف همه";
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // listBox_mobile
            // 
            this.listBox_mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_mobile.FormattingEnabled = true;
            this.listBox_mobile.ItemHeight = 14;
            this.listBox_mobile.Location = new System.Drawing.Point(147, 26);
            this.listBox_mobile.Name = "listBox_mobile";
            this.listBox_mobile.ScrollAlwaysVisible = true;
            this.listBox_mobile.Size = new System.Drawing.Size(152, 88);
            this.listBox_mobile.TabIndex = 8;
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(62, 56);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(79, 25);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "حذف";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(62, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // reflectionImage2
            // 
            this.reflectionImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionImage2.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage2.Image")));
            this.reflectionImage2.Location = new System.Drawing.Point(304, 3);
            this.reflectionImage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(30, 68);
            this.reflectionImage2.TabIndex = 3;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(6, 2);
            this.reflectionImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(40, 68);
            this.reflectionImage1.TabIndex = 2;
            // 
            // panel_Text
            // 
            this.panel_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Text.Controls.Add(this.textBox_SMSText);
            this.panel_Text.Location = new System.Drawing.Point(4, 77);
            this.panel_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(344, 269);
            this.panel_Text.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_Text.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_Text.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_Text.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_Text.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_Text.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_Text.Style.GradientAngle = 90;
            this.panel_Text.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_Text.TabIndex = 8;
            this.panel_Text.Text = "متن ارسالی";
            // 
            // textBox_SMSText
            // 
            this.textBox_SMSText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_SMSText.Border.Class = "TextBoxBorder";
            this.textBox_SMSText.ForeColor = System.Drawing.Color.Black;
            this.textBox_SMSText.Location = new System.Drawing.Point(14, 21);
            this.textBox_SMSText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SMSText.MaxLength = 2000;
            this.textBox_SMSText.Multiline = true;
            this.textBox_SMSText.Name = "textBox_SMSText";
            this.textBox_SMSText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SMSText.Size = new System.Drawing.Size(317, 236);
            this.textBox_SMSText.TabIndex = 0;
            this.textBox_SMSText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ribbonBar_SdAvSMS
            // 
            this.ribbonBar_SdAvSMS.AutoOverflowEnabled = true;
            this.ribbonBar_SdAvSMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar_SdAvSMS.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar_SdAvSMS.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_Log,
            this.buttonItem_SendSMS,
            this.buttonItem_AdverPrint,
            this.buttonItem_Cancel});
            this.ribbonBar_SdAvSMS.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar_SdAvSMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_SdAvSMS.Name = "ribbonBar_SdAvSMS";
            this.ribbonBar_SdAvSMS.Size = new System.Drawing.Size(352, 73);
            this.ribbonBar_SdAvSMS.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_SdAvSMS.TabIndex = 7;
            // 
            // 
            // 
            this.ribbonBar_SdAvSMS.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.754717F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // buttonItem_Log
            // 
            this.buttonItem_Log.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Log.FixedSize = new System.Drawing.Size(70, 60);
            this.buttonItem_Log.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Log.Image")));
            this.buttonItem_Log.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Log.ImagePaddingHorizontal = 8;
            this.buttonItem_Log.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Log.Name = "buttonItem_Log";
            this.buttonItem_Log.SubItemsExpandWidth = 14;
            this.buttonItem_Log.Text = "وضعیت";
            this.buttonItem_Log.Click += new System.EventHandler(this.buttonItem_Log_Click);
            // 
            // buttonItem_SendSMS
            // 
            this.buttonItem_SendSMS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_SendSMS.FixedSize = new System.Drawing.Size(90, 60);
            this.buttonItem_SendSMS.HotFontBold = true;
            this.buttonItem_SendSMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_SendSMS.Image")));
            this.buttonItem_SendSMS.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_SendSMS.ImagePaddingHorizontal = 20;
            this.buttonItem_SendSMS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_SendSMS.Name = "buttonItem_SendSMS";
            this.buttonItem_SendSMS.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F10);
            this.buttonItem_SendSMS.SubItemsExpandWidth = 20;
            this.buttonItem_SendSMS.Text = "SMS";
            this.buttonItem_SendSMS.Tooltip = "F10";
            this.buttonItem_SendSMS.Click += new System.EventHandler(this.buttonItem_SendSMS_Click);
            // 
            // buttonItem_AdverPrint
            // 
            this.buttonItem_AdverPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_AdverPrint.FixedSize = new System.Drawing.Size(90, 60);
            this.buttonItem_AdverPrint.HotFontBold = true;
            this.buttonItem_AdverPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_AdverPrint.Image")));
            this.buttonItem_AdverPrint.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_AdverPrint.ImagePaddingHorizontal = 8;
            this.buttonItem_AdverPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_AdverPrint.Name = "buttonItem_AdverPrint";
            this.buttonItem_AdverPrint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12);
            this.buttonItem_AdverPrint.SubItemsExpandWidth = 14;
            this.buttonItem_AdverPrint.Text = "چاپ آگهی";
            this.buttonItem_AdverPrint.Tooltip = "F12";
            this.buttonItem_AdverPrint.Click += new System.EventHandler(this.buttonItem_Print_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(60, 60);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SplitButton = true;
            this.buttonItem_Cancel.Stretch = true;
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "انصراف";
            this.buttonItem_Cancel.Tooltip = "Esc";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // SendAdverSMS_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 480);
            this.Controls.Add(this.panel_Text);
            this.Controls.Add(this.ribbonBar_SdAvSMS);
            this.Controls.Add(this.panel_SelectMobile);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 387);
            this.Name = "SendAdverSMS_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.Load += new System.EventHandler(this.SendAdverSMS_frm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SendAdverSMS_frm_KeyPress);
            this.panel_SelectMobile.ResumeLayout(false);
            this.panel_Text.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel_SelectMobile;
        private DevComponents.DotNetBar.PanelEx panel_Text;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_SdAvSMS;
        private DevComponents.DotNetBar.ButtonItem buttonItem_SendSMS;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_SMSText;
        public DevComponents.DotNetBar.ButtonItem buttonItem_AdverPrint;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        public DevComponents.DotNetBar.ButtonItem buttonItem_Log;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.ListBox listBox_mobile;
        private DevComponents.DotNetBar.ButtonX btnDelAll;
    }
}