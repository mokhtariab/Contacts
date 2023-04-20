namespace Contacts_Prj
{
    partial class SMSMobSelect_frm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSMobSelect_frm));
            this.dataGridView_TelMobList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgTML_PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTML_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTML_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMTL_Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTML_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTML_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTML_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rbGroup = new System.Windows.Forms.RadioButton();
            this.rbAllMob = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.textBoxSingle = new System.Windows.Forms.TextBox();
            this.ribbonBar_ieSearch = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.panel_Text = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TelMobList)).BeginInit();
            this.panel_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_TelMobList
            // 
            this.dataGridView_TelMobList.AllowUserToAddRows = false;
            this.dataGridView_TelMobList.AllowUserToDeleteRows = false;
            this.dataGridView_TelMobList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_TelMobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TelMobList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_TelMobList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_TelMobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TelMobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.dgTML_PersonID,
            this.dgTML_FirstName,
            this.dgTML_LastName,
            this.dgMTL_Telephone,
            this.Mobile,
            this.dgTML_Email,
            this.dgTML_Address,
            this.dgTML_Description});
            this.dataGridView_TelMobList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_TelMobList.Location = new System.Drawing.Point(22, 95);
            this.dataGridView_TelMobList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_TelMobList.MinimumSize = new System.Drawing.Size(438, 165);
            this.dataGridView_TelMobList.Name = "dataGridView_TelMobList";
            this.dataGridView_TelMobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TelMobList.Size = new System.Drawing.Size(463, 340);
            this.dataGridView_TelMobList.TabIndex = 23;
            // 
            // Select
            // 
            this.Select.HeaderText = "انتخاب";
            this.Select.Name = "Select";
            // 
            // dgTML_PersonID
            // 
            this.dgTML_PersonID.DataPropertyName = "PersonID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgTML_PersonID.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTML_PersonID.HeaderText = "شماره شخص";
            this.dgTML_PersonID.Name = "dgTML_PersonID";
            this.dgTML_PersonID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgTML_FirstName
            // 
            this.dgTML_FirstName.DataPropertyName = "FirstName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgTML_FirstName.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTML_FirstName.HeaderText = "نام";
            this.dgTML_FirstName.Name = "dgTML_FirstName";
            // 
            // dgTML_LastName
            // 
            this.dgTML_LastName.DataPropertyName = "LastName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgTML_LastName.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgTML_LastName.HeaderText = "نام فامیل";
            this.dgTML_LastName.Name = "dgTML_LastName";
            // 
            // dgMTL_Telephone
            // 
            this.dgMTL_Telephone.DataPropertyName = "Telephone";
            this.dgMTL_Telephone.HeaderText = "تلفن ثابت";
            this.dgMTL_Telephone.Name = "dgMTL_Telephone";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            // 
            // dgTML_Email
            // 
            this.dgTML_Email.DataPropertyName = "Email";
            this.dgTML_Email.HeaderText = "Email";
            this.dgTML_Email.Name = "dgTML_Email";
            this.dgTML_Email.Visible = false;
            // 
            // dgTML_Address
            // 
            this.dgTML_Address.DataPropertyName = "Address";
            this.dgTML_Address.HeaderText = "Address";
            this.dgTML_Address.Name = "dgTML_Address";
            this.dgTML_Address.Visible = false;
            // 
            // dgTML_Description
            // 
            this.dgTML_Description.DataPropertyName = "Description";
            this.dgTML_Description.HeaderText = "Description";
            this.dgTML_Description.Name = "dgTML_Description";
            this.dgTML_Description.Visible = false;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroup.DisplayMember = "GroupName";
            this.comboBoxGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.ItemHeight = 15;
            this.comboBoxGroup.Location = new System.Drawing.Point(236, 57);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(249, 21);
            this.comboBoxGroup.TabIndex = 30;
            this.comboBoxGroup.ValueMember = "GroupID";
            // 
            // rbGroup
            // 
            this.rbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbGroup.AutoSize = true;
            this.rbGroup.Location = new System.Drawing.Point(512, 57);
            this.rbGroup.Name = "rbGroup";
            this.rbGroup.Size = new System.Drawing.Size(164, 17);
            this.rbGroup.TabIndex = 31;
            this.rbGroup.Text = "گروه مورد نظر را مشخص کنید:";
            this.rbGroup.UseVisualStyleBackColor = true;
            // 
            // rbAllMob
            // 
            this.rbAllMob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAllMob.AutoSize = true;
            this.rbAllMob.Location = new System.Drawing.Point(495, 104);
            this.rbAllMob.Name = "rbAllMob";
            this.rbAllMob.Size = new System.Drawing.Size(181, 17);
            this.rbAllMob.TabIndex = 32;
            this.rbAllMob.Text = "اشخاص مورد نظر را مشخص کنید:";
            this.rbAllMob.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSingle.AutoSize = true;
            this.rbSingle.Checked = true;
            this.rbSingle.Location = new System.Drawing.Point(504, 17);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(172, 17);
            this.rbSingle.TabIndex = 33;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "موبایل مورد نظر را مشخص کنید:";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // textBoxSingle
            // 
            this.textBoxSingle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSingle.Location = new System.Drawing.Point(236, 16);
            this.textBoxSingle.Name = "textBoxSingle";
            this.textBoxSingle.Size = new System.Drawing.Size(249, 21);
            this.textBoxSingle.TabIndex = 34;
            // 
            // ribbonBar_ieSearch
            // 
            this.ribbonBar_ieSearch.AutoOverflowEnabled = true;
            this.ribbonBar_ieSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar_ieSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ribbonBar_ieSearch.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar_ieSearch.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK,
            this.buttonItem_Cancel});
            this.ribbonBar_ieSearch.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar_ieSearch.Name = "ribbonBar_ieSearch";
            this.ribbonBar_ieSearch.Size = new System.Drawing.Size(717, 67);
            this.ribbonBar_ieSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_ieSearch.TabIndex = 35;
            // 
            // 
            // 
            this.ribbonBar_ieSearch.TitleStyle.Font = new System.Drawing.Font("Tahoma", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ribbonBar_ieSearch.TitleVisible = false;
            // 
            // buttonItem_OK
            // 
            this.buttonItem_OK.FixedSize = new System.Drawing.Size(100, 60);
            this.buttonItem_OK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_OK.Image")));
            this.buttonItem_OK.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonItem_OK.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_OK.ImagePaddingHorizontal = 8;
            this.buttonItem_OK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_OK.Name = "buttonItem_OK";
            this.buttonItem_OK.SubItemsExpandWidth = 14;
            this.buttonItem_OK.Text = "تایید";
            this.buttonItem_OK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(80, 60);
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
            // panel_Text
            // 
            this.panel_Text.Controls.Add(this.label1);
            this.panel_Text.Controls.Add(this.rbGroup);
            this.panel_Text.Controls.Add(this.textBoxSingle);
            this.panel_Text.Controls.Add(this.dataGridView_TelMobList);
            this.panel_Text.Controls.Add(this.rbSingle);
            this.panel_Text.Controls.Add(this.comboBoxGroup);
            this.panel_Text.Controls.Add(this.rbAllMob);
            this.panel_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Text.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_Text.Location = new System.Drawing.Point(0, 67);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(717, 459);
            this.panel_Text.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_Text.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_Text.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_Text.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_Text.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_Text.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_Text.Style.GradientAngle = 90;
            this.panel_Text.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_Text.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "جهت جداسازی موبایل ها از ; استفاده نمایید";
            // 
            // SMSMobSelect_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(717, 526);
            this.Controls.Add(this.panel_Text);
            this.Controls.Add(this.ribbonBar_ieSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SMSMobSelect_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب موبایل ها";
            this.Load += new System.EventHandler(this.SMSMobSelect_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TelMobList)).EndInit();
            this.panel_Text.ResumeLayout(false);
            this.panel_Text.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_TelMobList;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxGroup;
        private System.Windows.Forms.RadioButton rbGroup;
        private System.Windows.Forms.RadioButton rbAllMob;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.TextBox textBoxSingle;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_ieSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.PanelEx panel_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTML_PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTML_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTML_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMTL_Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTML_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTML_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTML_Description;

    }
}
