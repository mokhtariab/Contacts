namespace Contacts_Prj
{
    partial class ReciveSMS_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciveSMS_frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonBar_SdAvSMS = new DevComponents.DotNetBar.RibbonBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_rbmsgsim = new System.Windows.Forms.CheckBox();
            this.radiobtn_rbmsgphone = new System.Windows.Forms.CheckBox();
            this.buttonItem_DelRcSMS = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_ListView = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.panel_Text = new DevComponents.DotNetBar.PanelEx();
            this.lstInbox = new System.Windows.Forms.ListView();
            this.clmFrom = new System.Windows.Forms.ColumnHeader();
            this.clmMessage = new System.Windows.Forms.ColumnHeader();
            this.clmTime = new System.Windows.Forms.ColumnHeader();
            this.txoutput = new System.Windows.Forms.TextBox();
            this.dataGridView_ReciveSMS = new System.Windows.Forms.DataGridView();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.ribbonBar_SdAvSMS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_Text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReciveSMS)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar_SdAvSMS
            // 
            this.ribbonBar_SdAvSMS.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_SdAvSMS.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_SdAvSMS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_SdAvSMS.ContainerControlProcessDialogKey = true;
            this.ribbonBar_SdAvSMS.Controls.Add(this.groupBox2);
            this.ribbonBar_SdAvSMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar_SdAvSMS.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar_SdAvSMS.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_DelRcSMS,
            this.buttonItem_ListView,
            this.buttonItem_Cancel});
            this.ribbonBar_SdAvSMS.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar_SdAvSMS.Name = "ribbonBar_SdAvSMS";
            this.ribbonBar_SdAvSMS.Size = new System.Drawing.Size(830, 73);
            this.ribbonBar_SdAvSMS.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_SdAvSMS.TabIndex = 8;
            // 
            // 
            // 
            this.ribbonBar_SdAvSMS.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_SdAvSMS.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.754717F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.ribbonBar_SdAvSMS.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radiobtn_rbmsgsim);
            this.groupBox2.Controls.Add(this.radiobtn_rbmsgphone);
            this.groupBox2.Location = new System.Drawing.Point(584, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 41);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "منبع نمایش ";
            // 
            // radiobtn_rbmsgsim
            // 
            this.radiobtn_rbmsgsim.AutoSize = true;
            this.radiobtn_rbmsgsim.Checked = true;
            this.radiobtn_rbmsgsim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radiobtn_rbmsgsim.Location = new System.Drawing.Point(129, 15);
            this.radiobtn_rbmsgsim.Name = "radiobtn_rbmsgsim";
            this.radiobtn_rbmsgsim.Size = new System.Drawing.Size(78, 18);
            this.radiobtn_rbmsgsim.TabIndex = 4;
            this.radiobtn_rbmsgsim.Text = "سیم کارت";
            this.radiobtn_rbmsgsim.UseVisualStyleBackColor = true;
            // 
            // radiobtn_rbmsgphone
            // 
            this.radiobtn_rbmsgphone.AutoSize = true;
            this.radiobtn_rbmsgphone.Location = new System.Drawing.Point(10, 15);
            this.radiobtn_rbmsgphone.Name = "radiobtn_rbmsgphone";
            this.radiobtn_rbmsgphone.Size = new System.Drawing.Size(92, 18);
            this.radiobtn_rbmsgphone.TabIndex = 3;
            this.radiobtn_rbmsgphone.Text = "حافظه موبایل";
            this.radiobtn_rbmsgphone.UseVisualStyleBackColor = true;
            // 
            // buttonItem_DelRcSMS
            // 
            this.buttonItem_DelRcSMS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_DelRcSMS.FixedSize = new System.Drawing.Size(120, 60);
            this.buttonItem_DelRcSMS.HotFontBold = true;
            this.buttonItem_DelRcSMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_DelRcSMS.Image")));
            this.buttonItem_DelRcSMS.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem_DelRcSMS.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItem_DelRcSMS.ImagePaddingHorizontal = 20;
            this.buttonItem_DelRcSMS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_DelRcSMS.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItem_DelRcSMS.Name = "buttonItem_DelRcSMS";
            this.buttonItem_DelRcSMS.SubItemsExpandWidth = 14;
            this.buttonItem_DelRcSMS.Text = "حذف پیامک";
            this.buttonItem_DelRcSMS.Click += new System.EventHandler(this.buttonItem_DelRcSMS_Click);
            // 
            // buttonItem_ListView
            // 
            this.buttonItem_ListView.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_ListView.FixedSize = new System.Drawing.Size(160, 60);
            this.buttonItem_ListView.HotFontBold = true;
            this.buttonItem_ListView.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_ListView.Image")));
            this.buttonItem_ListView.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem_ListView.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItem_ListView.ImagePaddingHorizontal = 20;
            this.buttonItem_ListView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_ListView.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItem_ListView.Name = "buttonItem_ListView";
            this.buttonItem_ListView.SubItemsExpandWidth = 14;
            this.buttonItem_ListView.Text = "نمایش لیست دریافتی";
            this.buttonItem_ListView.Click += new System.EventHandler(this.buttonItem_ListView_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(100, 60);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SplitButton = true;
            this.buttonItem_Cancel.Stretch = true;
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "خروج";
            this.buttonItem_Cancel.Tooltip = "Esc";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // panel_Text
            // 
            this.panel_Text.Controls.Add(this.lstInbox);
            this.panel_Text.Controls.Add(this.txoutput);
            this.panel_Text.Controls.Add(this.dataGridView_ReciveSMS);
            this.panel_Text.Controls.Add(this.reflectionImage2);
            this.panel_Text.Controls.Add(this.reflectionImage1);
            this.panel_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Text.Location = new System.Drawing.Point(0, 73);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(830, 415);
            this.panel_Text.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_Text.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_Text.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_Text.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_Text.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_Text.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_Text.Style.GradientAngle = 90;
            this.panel_Text.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_Text.TabIndex = 10;
            this.panel_Text.Text = "لیست دریافت";
            // 
            // lstInbox
            // 
            this.lstInbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInbox.CheckBoxes = true;
            this.lstInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFrom,
            this.clmMessage,
            this.clmTime});
            this.lstInbox.FullRowSelect = true;
            this.lstInbox.GridLines = true;
            this.lstInbox.Location = new System.Drawing.Point(67, 26);
            this.lstInbox.Name = "lstInbox";
            this.lstInbox.RightToLeftLayout = true;
            this.lstInbox.Size = new System.Drawing.Size(728, 368);
            this.lstInbox.TabIndex = 23;
            this.lstInbox.UseCompatibleStateImageBehavior = false;
            this.lstInbox.View = System.Windows.Forms.View.Details;
            this.lstInbox.DoubleClick += new System.EventHandler(this.lstInbox_DoubleClick);
            // 
            // clmFrom
            // 
            this.clmFrom.Text = "فرستنده";
            this.clmFrom.Width = 120;
            // 
            // clmMessage
            // 
            this.clmMessage.Text = "متن";
            this.clmMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmMessage.Width = 450;
            // 
            // clmTime
            // 
            this.clmTime.Text = "تاریخ و ساعت";
            this.clmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTime.Width = 125;
            // 
            // txoutput
            // 
            this.txoutput.Location = new System.Drawing.Point(12, 238);
            this.txoutput.Multiline = true;
            this.txoutput.Name = "txoutput";
            this.txoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txoutput.Size = new System.Drawing.Size(21, 67);
            this.txoutput.TabIndex = 22;
            this.txoutput.Visible = false;
            // 
            // dataGridView_ReciveSMS
            // 
            this.dataGridView_ReciveSMS.AllowUserToAddRows = false;
            this.dataGridView_ReciveSMS.AllowUserToDeleteRows = false;
            this.dataGridView_ReciveSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ReciveSMS.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ReciveSMS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ReciveSMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReciveSMS.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_ReciveSMS.Location = new System.Drawing.Point(55, 352);
            this.dataGridView_ReciveSMS.Name = "dataGridView_ReciveSMS";
            this.dataGridView_ReciveSMS.ReadOnly = true;
            this.dataGridView_ReciveSMS.Size = new System.Drawing.Size(327, 50);
            this.dataGridView_ReciveSMS.TabIndex = 19;
            this.dataGridView_ReciveSMS.Visible = false;
            // 
            // reflectionImage2
            // 
            this.reflectionImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.reflectionImage2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage2.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage2.Image")));
            this.reflectionImage2.Location = new System.Drawing.Point(12, 341);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(34, 72);
            this.reflectionImage2.TabIndex = 3;
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(3, 26);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(46, 72);
            this.reflectionImage1.TabIndex = 2;
            // 
            // ReciveSMS_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 488);
            this.Controls.Add(this.panel_Text);
            this.Controls.Add(this.ribbonBar_SdAvSMS);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReciveSMS_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیامک های دریافتی";
            this.Load += new System.EventHandler(this.ReciveSMS_frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReciveSMS_frm_FormClosed);
            this.ribbonBar_SdAvSMS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_Text.ResumeLayout(false);
            this.panel_Text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReciveSMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_SdAvSMS;
        private DevComponents.DotNetBar.ButtonItem buttonItem_ListView;
        private DevComponents.DotNetBar.PanelEx panel_Text;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox radiobtn_rbmsgsim;
        private System.Windows.Forms.CheckBox radiobtn_rbmsgphone;
        private System.Windows.Forms.DataGridView dataGridView_ReciveSMS;
        private System.Windows.Forms.TextBox txoutput;
        private DevComponents.DotNetBar.ButtonItem buttonItem_DelRcSMS;
        private System.Windows.Forms.ListView lstInbox;
        private System.Windows.Forms.ColumnHeader clmFrom;
        private System.Windows.Forms.ColumnHeader clmMessage;
        private System.Windows.Forms.ColumnHeader clmTime;
    }
}