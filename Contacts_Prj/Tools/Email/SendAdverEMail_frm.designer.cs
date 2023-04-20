namespace Contacts_Prj
{
    partial class SendAdverEMail_frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendAdverEMail_frm));
            this.Recive_txt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.panel_Text = new DevComponents.DotNetBar.PanelEx();
            this.labelFiles = new DevComponents.DotNetBar.LabelX();
            this.Attach_btn = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.Subject_txt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_EMailText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonBar_SdAvSMS = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_SendEMail = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Recive_txt
            // 
            this.Recive_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Recive_txt.DisplayMember = "Email";
            this.Recive_txt.DropDownHeight = 100;
            this.Recive_txt.ForeColor = System.Drawing.Color.Black;
            this.Recive_txt.IntegralHeight = false;
            this.Recive_txt.ItemHeight = 14;
            this.Recive_txt.Location = new System.Drawing.Point(66, 24);
            this.Recive_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Recive_txt.Name = "Recive_txt";
            this.Recive_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Recive_txt.Size = new System.Drawing.Size(228, 22);
            this.Recive_txt.TabIndex = 2;
            this.Recive_txt.ValueMember = "PersonID";
            this.Recive_txt.Leave += new System.EventHandler(this.Recive_txt_Leave);
            this.Recive_txt.Enter += new System.EventHandler(this.Recive_txt_Enter);
            this.Recive_txt.TextChanged += new System.EventHandler(this.Recive_txt_TextChanged);
            // 
            // reflectionImage2
            // 
            this.reflectionImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionImage2.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage2.Image")));
            this.reflectionImage2.Location = new System.Drawing.Point(403, 2);
            this.reflectionImage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(46, 65);
            this.reflectionImage2.TabIndex = 3;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(3, 2);
            this.reflectionImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(52, 68);
            this.reflectionImage1.TabIndex = 2;
            // 
            // panel_Text
            // 
            this.panel_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Text.Controls.Add(this.labelFiles);
            this.panel_Text.Controls.Add(this.Attach_btn);
            this.panel_Text.Controls.Add(this.reflectionImage1);
            this.panel_Text.Controls.Add(this.Recive_txt);
            this.panel_Text.Controls.Add(this.reflectionImage2);
            this.panel_Text.Controls.Add(this.labelX1);
            this.panel_Text.Controls.Add(this.labelX3);
            this.panel_Text.Controls.Add(this.Subject_txt);
            this.panel_Text.Controls.Add(this.textBox_EMailText);
            this.panel_Text.Location = new System.Drawing.Point(0, 68);
            this.panel_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(455, 365);
            this.panel_Text.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_Text.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_Text.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_Text.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_Text.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_Text.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_Text.Style.GradientAngle = 90;
            this.panel_Text.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_Text.TabIndex = 8;
            this.panel_Text.Text = "ایمیل";
            // 
            // labelFiles
            // 
            this.labelFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFiles.Location = new System.Drawing.Point(129, 81);
            this.labelFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(97, 19);
            this.labelFiles.TabIndex = 7;
            this.labelFiles.Text = "تعداد 0 فایل";
            // 
            // Attach_btn
            // 
            this.Attach_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Attach_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Attach_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Attach_btn.Image = ((System.Drawing.Image)(resources.GetObject("Attach_btn.Image")));
            this.Attach_btn.Location = new System.Drawing.Point(232, 76);
            this.Attach_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Attach_btn.Name = "Attach_btn";
            this.Attach_btn.Size = new System.Drawing.Size(151, 28);
            this.Attach_btn.TabIndex = 6;
            this.Attach_btn.Text = "Attach (افزودن فایل)";
            this.Attach_btn.Click += new System.EventHandler(this.Attach_btn_Click);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.Location = new System.Drawing.Point(295, 24);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 19);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "ایمیل گیرنده (TO):";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.Location = new System.Drawing.Point(295, 51);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(97, 19);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "موضوع (Subject):";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // Subject_txt
            // 
            this.Subject_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Subject_txt.Border.Class = "TextBoxBorder";
            this.Subject_txt.Location = new System.Drawing.Point(66, 50);
            this.Subject_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subject_txt.Name = "Subject_txt";
            this.Subject_txt.Size = new System.Drawing.Size(228, 22);
            this.Subject_txt.TabIndex = 4;
            // 
            // textBox_EMailText
            // 
            this.textBox_EMailText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_EMailText.Border.Class = "TextBoxBorder";
            this.textBox_EMailText.ForeColor = System.Drawing.Color.Black;
            this.textBox_EMailText.Location = new System.Drawing.Point(12, 108);
            this.textBox_EMailText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_EMailText.MaxLength = 2000;
            this.textBox_EMailText.Multiline = true;
            this.textBox_EMailText.Name = "textBox_EMailText";
            this.textBox_EMailText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_EMailText.Size = new System.Drawing.Size(431, 247);
            this.textBox_EMailText.TabIndex = 5;
            this.textBox_EMailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ribbonBar_SdAvSMS
            // 
            this.ribbonBar_SdAvSMS.AutoOverflowEnabled = true;
            this.ribbonBar_SdAvSMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar_SdAvSMS.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar_SdAvSMS.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_SendEMail,
            this.buttonItem_Cancel});
            this.ribbonBar_SdAvSMS.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar_SdAvSMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_SdAvSMS.Name = "ribbonBar_SdAvSMS";
            this.ribbonBar_SdAvSMS.Size = new System.Drawing.Size(457, 66);
            this.ribbonBar_SdAvSMS.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_SdAvSMS.TabIndex = 7;
            // 
            // 
            // 
            this.ribbonBar_SdAvSMS.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.754717F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // buttonItem_SendEMail
            // 
            this.buttonItem_SendEMail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_SendEMail.FixedSize = new System.Drawing.Size(120, 50);
            this.buttonItem_SendEMail.HotFontBold = true;
            this.buttonItem_SendEMail.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_SendEMail.Image")));
            this.buttonItem_SendEMail.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonItem_SendEMail.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItem_SendEMail.ImagePaddingHorizontal = 20;
            this.buttonItem_SendEMail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_SendEMail.Name = "buttonItem_SendEMail";
            this.buttonItem_SendEMail.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F10);
            this.buttonItem_SendEMail.SubItemsExpandWidth = 20;
            this.buttonItem_SendEMail.Text = "ارسال";
            this.buttonItem_SendEMail.Tooltip = "F10";
            this.buttonItem_SendEMail.Click += new System.EventHandler(this.buttonItem_SendEMail_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(80, 50);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // SendAdverEMail_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 434);
            this.Controls.Add(this.panel_Text);
            this.Controls.Add(this.ribbonBar_SdAvSMS);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 387);
            this.Name = "SendAdverEMail_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMail";
            this.Load += new System.EventHandler(this.SendAdverEMail_frm_Load);
            this.panel_Text.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel_Text;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_SdAvSMS;
        private DevComponents.DotNetBar.ButtonItem buttonItem_SendEMail;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_EMailText;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Recive_txt;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX Subject_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.ButtonX Attach_btn;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelFiles;
    }
}