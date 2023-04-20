namespace Contacts_Prj
{
    partial class SMSLogView_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSLogView_frm));
            this.ribbonBar_SMSLog = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_Resend = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Del = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.panel_t = new DevComponents.DotNetBar.PanelEx();
            this.dataGridView_Log = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SMSCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMS_Few = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.buttonItem_Refresh = new DevComponents.DotNetBar.ButtonItem();
            this.panel_t.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar_SMSLog
            // 
            this.ribbonBar_SMSLog.AutoOverflowEnabled = true;
            this.ribbonBar_SMSLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar_SMSLog.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar_SMSLog.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_Refresh,
            this.buttonItem_Resend,
            this.buttonItem_Del,
            this.buttonItem_Cancel});
            this.ribbonBar_SMSLog.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar_SMSLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_SMSLog.Name = "ribbonBar_SMSLog";
            this.ribbonBar_SMSLog.Size = new System.Drawing.Size(815, 71);
            this.ribbonBar_SMSLog.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_SMSLog.TabIndex = 9;
            // 
            // 
            // 
            this.ribbonBar_SMSLog.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.754717F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // buttonItem_Resend
            // 
            this.buttonItem_Resend.FixedSize = new System.Drawing.Size(100, 60);
            this.buttonItem_Resend.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Resend.Image")));
            this.buttonItem_Resend.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Resend.ImagePaddingHorizontal = 8;
            this.buttonItem_Resend.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Resend.Name = "buttonItem_Resend";
            this.buttonItem_Resend.SubItemsExpandWidth = 14;
            this.buttonItem_Resend.Text = "ارسال دوباره";
            this.buttonItem_Resend.Click += new System.EventHandler(this.buttonItem_Resend_Click);
            // 
            // buttonItem_Del
            // 
            this.buttonItem_Del.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Del.FixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem_Del.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Del.Image")));
            this.buttonItem_Del.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Del.ImagePaddingHorizontal = 8;
            this.buttonItem_Del.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Del.Name = "buttonItem_Del";
            this.buttonItem_Del.SubItemsExpandWidth = 14;
            this.buttonItem_Del.Text = "حذف";
            this.buttonItem_Del.Click += new System.EventHandler(this.buttonItem_Del_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(100, 60);
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
            this.buttonItem_Cancel.Text = "خروج";
            this.buttonItem_Cancel.Tooltip = "Esc";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // panel_t
            // 
            this.panel_t.Controls.Add(this.dataGridView_Log);
            this.panel_t.Controls.Add(this.reflectionImage2);
            this.panel_t.Controls.Add(this.reflectionImage1);
            this.panel_t.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_t.Location = new System.Drawing.Point(0, 71);
            this.panel_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_t.Name = "panel_t";
            this.panel_t.Size = new System.Drawing.Size(815, 389);
            this.panel_t.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_t.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_t.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_t.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_t.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_t.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_t.Style.GradientAngle = 90;
            this.panel_t.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_t.TabIndex = 11;
            this.panel_t.Text = "لیست وضعیت";
            // 
            // dataGridView_Log
            // 
            this.dataGridView_Log.AllowUserToAddRows = false;
            this.dataGridView_Log.AllowUserToDeleteRows = false;
            this.dataGridView_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.SMSCode,
            this.SendDate,
            this.SendTime,
            this.Archive,
            this.Mobile_No,
            this.MessageText,
            this.StatusStr,
            this.SMS_Few,
            this.UseName,
            this.Description});
            this.dataGridView_Log.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Log.Location = new System.Drawing.Point(48, 22);
            this.dataGridView_Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Log.Name = "dataGridView_Log";
            this.dataGridView_Log.ReadOnly = true;
            this.dataGridView_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Log.Size = new System.Drawing.Size(723, 341);
            this.dataGridView_Log.TabIndex = 19;
            // 
            // Select
            // 
            this.Select.FalseValue = "False";
            this.Select.FillWeight = 35.40075F;
            this.Select.HeaderText = "انتخاب";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.TrueValue = "True";
            this.Select.Visible = false;
            // 
            // SMSCode
            // 
            this.SMSCode.DataPropertyName = "SMSCode";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SMSCode.DefaultCellStyle = dataGridViewCellStyle9;
            this.SMSCode.FillWeight = 49.41956F;
            this.SMSCode.HeaderText = "کد ارسال";
            this.SMSCode.Name = "SMSCode";
            this.SMSCode.ReadOnly = true;
            // 
            // SendDate
            // 
            this.SendDate.DataPropertyName = "SendDate";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SendDate.DefaultCellStyle = dataGridViewCellStyle10;
            this.SendDate.FillWeight = 68.95837F;
            this.SendDate.HeaderText = "تاریخ ارسال";
            this.SendDate.Name = "SendDate";
            this.SendDate.ReadOnly = true;
            // 
            // SendTime
            // 
            this.SendTime.DataPropertyName = "SendTime";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SendTime.DefaultCellStyle = dataGridViewCellStyle11;
            this.SendTime.FillWeight = 75.30321F;
            this.SendTime.HeaderText = "زمان ارسال";
            this.SendTime.Name = "SendTime";
            this.SendTime.ReadOnly = true;
            // 
            // Archive
            // 
            this.Archive.DataPropertyName = "Archive";
            this.Archive.HeaderText = "Archive";
            this.Archive.Name = "Archive";
            this.Archive.ReadOnly = true;
            this.Archive.Visible = false;
            // 
            // Mobile_No
            // 
            this.Mobile_No.DataPropertyName = "Mobile_No";
            this.Mobile_No.FillWeight = 188.1681F;
            this.Mobile_No.HeaderText = "شماره موبایل";
            this.Mobile_No.Name = "Mobile_No";
            this.Mobile_No.ReadOnly = true;
            // 
            // MessageText
            // 
            this.MessageText.DataPropertyName = "MessageText";
            this.MessageText.FillWeight = 97.1168F;
            this.MessageText.HeaderText = "متن";
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            // 
            // StatusStr
            // 
            this.StatusStr.DataPropertyName = "StatusStr";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StatusStr.DefaultCellStyle = dataGridViewCellStyle12;
            this.StatusStr.FillWeight = 153.9818F;
            this.StatusStr.HeaderText = "وضعیت ارسال";
            this.StatusStr.Name = "StatusStr";
            this.StatusStr.ReadOnly = true;
            // 
            // SMS_Few
            // 
            this.SMS_Few.DataPropertyName = "SMS_Few";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SMS_Few.DefaultCellStyle = dataGridViewCellStyle13;
            this.SMS_Few.FillWeight = 43.39948F;
            this.SMS_Few.HeaderText = "تعداد ارسال";
            this.SMS_Few.Name = "SMS_Few";
            this.SMS_Few.ReadOnly = true;
            this.SMS_Few.Visible = false;
            // 
            // UseName
            // 
            this.UseName.DataPropertyName = "UseName";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UseName.DefaultCellStyle = dataGridViewCellStyle14;
            this.UseName.FillWeight = 143.9744F;
            this.UseName.HeaderText = "نام کاربر";
            this.UseName.Name = "UseName";
            this.UseName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 144.2776F;
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // reflectionImage2
            // 
            this.reflectionImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionImage2.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage2.Image")));
            this.reflectionImage2.Location = new System.Drawing.Point(777, 25);
            this.reflectionImage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(30, 68);
            this.reflectionImage2.TabIndex = 3;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(3, 25);
            this.reflectionImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(40, 68);
            this.reflectionImage1.TabIndex = 2;
            // 
            // buttonItem_Refresh
            // 
            this.buttonItem_Refresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Refresh.Image")));
            this.buttonItem_Refresh.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Refresh.ImagePaddingHorizontal = 8;
            this.buttonItem_Refresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Refresh.Name = "buttonItem_Refresh";
            this.buttonItem_Refresh.SubItemsExpandWidth = 14;
            this.buttonItem_Refresh.Text = "بازخوانی";
            this.buttonItem_Refresh.Click += new System.EventHandler(this.buttonItem_Refresh_Click);
            // 
            // SMSLogView_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 460);
            this.Controls.Add(this.panel_t);
            this.Controls.Add(this.ribbonBar_SMSLog);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SMSLogView_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست وضعیت SMS ها";
            this.Load += new System.EventHandler(this.SMSLogView_frm_Load);
            this.panel_t.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_SMSLog;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.PanelEx panel_t;
        private System.Windows.Forms.DataGridView dataGridView_Log;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Resend;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Del;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageText;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMS_Few;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Refresh;
    }
}