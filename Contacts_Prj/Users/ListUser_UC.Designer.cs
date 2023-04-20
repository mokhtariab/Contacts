namespace Contacts_Prj
{

    partial class ListUser_UC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUser_UC));
            this.panelEx_Users = new DevComponents.DotNetBar.PanelEx();
            this.textBox_UUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_UFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_UName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_UCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView_UserList = new System.Windows.Forms.DataGridView();
            this.dgUL_usercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUL_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUL_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUL_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUL_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reflectionImage_Users = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.bubbleBar_Users = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.bubbleButton_URep = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_UAccess = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_UDel = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_UEdit = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_UNew = new DevComponents.DotNetBar.BubbleButton();
            this.gridControlUserList = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelEx_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx_Users
            // 
            this.panelEx_Users.AutoScroll = true;
            this.panelEx_Users.AutoScrollMinSize = new System.Drawing.Size(600, 500);
            this.panelEx_Users.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEx_Users.Controls.Add(this.gridControlUserList);
            this.panelEx_Users.Controls.Add(this.textBox_UUserName);
            this.panelEx_Users.Controls.Add(this.textBox_UFamily);
            this.panelEx_Users.Controls.Add(this.textBox_UName);
            this.panelEx_Users.Controls.Add(this.textBox_UCode);
            this.panelEx_Users.Controls.Add(this.dataGridView_UserList);
            this.panelEx_Users.Controls.Add(this.reflectionImage_Users);
            this.panelEx_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx_Users.Location = new System.Drawing.Point(0, 0);
            this.panelEx_Users.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelEx_Users.Name = "panelEx_Users";
            this.panelEx_Users.Padding = new System.Windows.Forms.Padding(114, 16, 114, 41);
            this.panelEx_Users.RightToLeftLayout = true;
            this.panelEx_Users.ShowFocusRectangle = true;
            this.panelEx_Users.Size = new System.Drawing.Size(901, 665);
            this.panelEx_Users.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_Users.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx_Users.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText;
            this.panelEx_Users.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_Users.Style.BorderColor.Color = System.Drawing.Color.Olive;
            this.panelEx_Users.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_Users.Style.GradientAngle = 90;
            this.panelEx_Users.TabIndex = 2;
            // 
            // textBox_UUserName
            // 
            this.textBox_UUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_UUserName.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBox_UUserName.Border.Class = "TextBoxBorder";
            this.textBox_UUserName.ForeColor = System.Drawing.Color.Black;
            this.textBox_UUserName.Location = new System.Drawing.Point(552, 113);
            this.textBox_UUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_UUserName.Name = "textBox_UUserName";
            this.textBox_UUserName.Size = new System.Drawing.Size(115, 22);
            this.textBox_UUserName.TabIndex = 14;
            this.textBox_UUserName.TextChanged += new System.EventHandler(this.textBox_UCode_TextChanged);
            // 
            // textBox_UFamily
            // 
            this.textBox_UFamily.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_UFamily.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBox_UFamily.Border.Class = "TextBoxBorder";
            this.textBox_UFamily.ForeColor = System.Drawing.Color.Black;
            this.textBox_UFamily.Location = new System.Drawing.Point(434, 113);
            this.textBox_UFamily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_UFamily.Name = "textBox_UFamily";
            this.textBox_UFamily.Size = new System.Drawing.Size(115, 22);
            this.textBox_UFamily.TabIndex = 13;
            this.textBox_UFamily.TextChanged += new System.EventHandler(this.textBox_UCode_TextChanged);
            // 
            // textBox_UName
            // 
            this.textBox_UName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_UName.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBox_UName.Border.Class = "TextBoxBorder";
            this.textBox_UName.ForeColor = System.Drawing.Color.Black;
            this.textBox_UName.Location = new System.Drawing.Point(316, 113);
            this.textBox_UName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_UName.Name = "textBox_UName";
            this.textBox_UName.Size = new System.Drawing.Size(115, 22);
            this.textBox_UName.TabIndex = 12;
            this.textBox_UName.TextChanged += new System.EventHandler(this.textBox_UCode_TextChanged);
            // 
            // textBox_UCode
            // 
            this.textBox_UCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_UCode.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBox_UCode.Border.Class = "TextBoxBorder";
            this.textBox_UCode.ForeColor = System.Drawing.Color.Black;
            this.textBox_UCode.Location = new System.Drawing.Point(198, 113);
            this.textBox_UCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_UCode.Name = "textBox_UCode";
            this.textBox_UCode.Size = new System.Drawing.Size(115, 22);
            this.textBox_UCode.TabIndex = 11;
            this.textBox_UCode.TextChanged += new System.EventHandler(this.textBox_UCode_TextChanged);
            // 
            // dataGridView_UserList
            // 
            this.dataGridView_UserList.AllowUserToAddRows = false;
            this.dataGridView_UserList.AllowUserToDeleteRows = false;
            this.dataGridView_UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_UserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_UserList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgUL_usercode,
            this.dgUL_FirstName,
            this.dgUL_LastName,
            this.dgUL_UserName,
            this.Column1,
            this.dgUL_CreateDate});
            this.dataGridView_UserList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_UserList.Location = new System.Drawing.Point(156, 137);
            this.dataGridView_UserList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_UserList.MinimumSize = new System.Drawing.Size(438, 165);
            this.dataGridView_UserList.Name = "dataGridView_UserList";
            this.dataGridView_UserList.ReadOnly = true;
            this.dataGridView_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_UserList.Size = new System.Drawing.Size(633, 423);
            this.dataGridView_UserList.TabIndex = 10;
            this.dataGridView_UserList.DoubleClick += new System.EventHandler(this.dataGridView_UserList_DoubleClick);
            this.dataGridView_UserList.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView_UserList_Paint);
            this.dataGridView_UserList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_UserList_KeyPress);
            // 
            // dgUL_usercode
            // 
            this.dgUL_usercode.DataPropertyName = "usercode";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUL_usercode.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgUL_usercode.HeaderText = "کد کاربر";
            this.dgUL_usercode.Name = "dgUL_usercode";
            this.dgUL_usercode.ReadOnly = true;
            // 
            // dgUL_FirstName
            // 
            this.dgUL_FirstName.DataPropertyName = "FirstName";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUL_FirstName.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgUL_FirstName.HeaderText = "نام کاربر";
            this.dgUL_FirstName.Name = "dgUL_FirstName";
            this.dgUL_FirstName.ReadOnly = true;
            // 
            // dgUL_LastName
            // 
            this.dgUL_LastName.DataPropertyName = "LastName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUL_LastName.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgUL_LastName.HeaderText = "نام فامیل کاربر";
            this.dgUL_LastName.Name = "dgUL_LastName";
            this.dgUL_LastName.ReadOnly = true;
            // 
            // dgUL_UserName
            // 
            this.dgUL_UserName.DataPropertyName = "UserName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUL_UserName.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgUL_UserName.HeaderText = "نام کاربری";
            this.dgUL_UserName.Name = "dgUL_UserName";
            this.dgUL_UserName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "password";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dgUL_CreateDate
            // 
            this.dgUL_CreateDate.DataPropertyName = "CDate";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUL_CreateDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgUL_CreateDate.HeaderText = "تاریخ ایجاد";
            this.dgUL_CreateDate.Name = "dgUL_CreateDate";
            this.dgUL_CreateDate.ReadOnly = true;
            // 
            // reflectionImage_Users
            // 
            this.reflectionImage_Users.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage_Users.Image")));
            this.reflectionImage_Users.Location = new System.Drawing.Point(4, 3);
            this.reflectionImage_Users.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reflectionImage_Users.Name = "reflectionImage_Users";
            this.reflectionImage_Users.Size = new System.Drawing.Size(141, 237);
            this.reflectionImage_Users.TabIndex = 9;
            // 
            // bubbleBar_Users
            // 
            this.bubbleBar_Users.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar_Users.AntiAlias = true;
            this.bubbleBar_Users.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.bubbleBar_Users.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Users.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar_Users.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar_Users.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar_Users.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar_Users.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar_Users.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bubbleBar_Users.ImageSizeLarge = new System.Drawing.Size(98, 98);
            this.bubbleBar_Users.ImageSizeNormal = new System.Drawing.Size(48, 48);
            this.bubbleBar_Users.Location = new System.Drawing.Point(0, 605);
            this.bubbleBar_Users.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bubbleBar_Users.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar_Users.Name = "bubbleBar_Users";
            this.bubbleBar_Users.SelectedTab = this.bubbleBarTab1;
            this.bubbleBar_Users.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar_Users.Size = new System.Drawing.Size(901, 60);
            this.bubbleBar_Users.TabIndex = 3;
            this.bubbleBar_Users.Tabs.Add(this.bubbleBarTab1);
            this.bubbleBar_Users.Text = "bubbleBar1";
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.bubbleButton_URep,
            this.bubbleButton_UAccess,
            this.bubbleButton_UDel,
            this.bubbleButton_UEdit,
            this.bubbleButton_UNew});
            this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab1.Text = "عملیات کاربران";
            this.bubbleBarTab1.TextColor = System.Drawing.Color.Black;
            // 
            // bubbleButton_URep
            // 
            this.bubbleButton_URep.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_URep.Image")));
            this.bubbleButton_URep.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_URep.ImageLarge")));
            this.bubbleButton_URep.Name = "bubbleButton_URep";
            this.bubbleButton_URep.TooltipText = "گزارش";
            this.bubbleButton_URep.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_URep_Click);
            // 
            // bubbleButton_UAccess
            // 
            this.bubbleButton_UAccess.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UAccess.Image")));
            this.bubbleButton_UAccess.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UAccess.ImageLarge")));
            this.bubbleButton_UAccess.Name = "bubbleButton_UAccess";
            this.bubbleButton_UAccess.TooltipText = "سطح دسترسی";
            this.bubbleButton_UAccess.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_UAccess_Click);
            // 
            // bubbleButton_UDel
            // 
            this.bubbleButton_UDel.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UDel.Image")));
            this.bubbleButton_UDel.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UDel.ImageLarge")));
            this.bubbleButton_UDel.Name = "bubbleButton_UDel";
            this.bubbleButton_UDel.TooltipText = "حذف کاربر";
            this.bubbleButton_UDel.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_UDel_Click);
            // 
            // bubbleButton_UEdit
            // 
            this.bubbleButton_UEdit.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UEdit.Image")));
            this.bubbleButton_UEdit.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UEdit.ImageLarge")));
            this.bubbleButton_UEdit.Name = "bubbleButton_UEdit";
            this.bubbleButton_UEdit.TooltipText = "ویرایش کاربر";
            this.bubbleButton_UEdit.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_UEdit_Click);
            // 
            // bubbleButton_UNew
            // 
            this.bubbleButton_UNew.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UNew.Image")));
            this.bubbleButton_UNew.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_UNew.ImageLarge")));
            this.bubbleButton_UNew.Name = "bubbleButton_UNew";
            this.bubbleButton_UNew.TooltipText = "کاربر جدید";
            this.bubbleButton_UNew.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_UNew_Click);
            // 
            // gridControlUserList
            // 
            this.gridControlUserList.AllowDrop = true;
            this.gridControlUserList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlUserList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlUserList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlUserList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlUserList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlUserList.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControlUserList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControlUserList.Location = new System.Drawing.Point(729, 417);
            this.gridControlUserList.LookAndFeel.SkinName = "Money Twins";
            this.gridControlUserList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlUserList.MainView = this.gridViewUserList;
            this.gridControlUserList.Name = "gridControlUserList";
            this.gridControlUserList.Size = new System.Drawing.Size(153, 118);
            this.gridControlUserList.TabIndex = 40;
            this.gridControlUserList.UseEmbeddedNavigator = true;
            this.gridControlUserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserList});
            this.gridControlUserList.Visible = false;
            // 
            // gridViewUserList
            // 
            this.gridViewUserList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewUserList.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewUserList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewUserList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewUserList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewUserList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserCode,
            this.FirstName,
            this.LastName,
            this.UserName,
            this.CDate});
            this.gridViewUserList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewUserList.GridControl = this.gridControlUserList;
            this.gridViewUserList.Name = "gridViewUserList";
            this.gridViewUserList.OptionsBehavior.Editable = false;
            this.gridViewUserList.OptionsCustomization.AllowGroup = false;
            this.gridViewUserList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewUserList.OptionsFilter.AllowFilterEditor = false;
            this.gridViewUserList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridViewUserList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridViewUserList.OptionsLayout.StoreAllOptions = true;
            this.gridViewUserList.OptionsLayout.StoreAppearance = true;
            this.gridViewUserList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewUserList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewUserList.OptionsView.ShowGroupPanel = false;
            this.gridViewUserList.OptionsView.ShowIndicator = false;
            // 
            // UserCode
            // 
            this.UserCode.Caption = "کد کاربر";
            this.UserCode.FieldName = "UserCode";
            this.UserCode.Name = "UserCode";
            this.UserCode.Visible = true;
            this.UserCode.VisibleIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "نام کاربر";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 3;
            // 
            // LastName
            // 
            this.LastName.Caption = "نام فامیل کاربر";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            // 
            // UserName
            // 
            this.UserName.Caption = "نام کاربری";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 1;
            // 
            // CDate
            // 
            this.CDate.Caption = "تاریخ ایجاد";
            this.CDate.FieldName = "CDate";
            this.CDate.Name = "CDate";
            this.CDate.Visible = true;
            this.CDate.VisibleIndex = 0;
            // 
            // ListUser_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bubbleBar_Users);
            this.Controls.Add(this.panelEx_Users);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListUser_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(901, 665);
            this.Load += new System.EventHandler(this.ListUser_UC_Load);
            this.panelEx_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx_Users;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage_Users;
        private DevComponents.DotNetBar.BubbleBar bubbleBar_Users;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_UAccess;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_UDel;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_UEdit;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_UNew;
        private System.Windows.Forms.DataGridView dataGridView_UserList;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_URep;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_UFamily;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_UName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_UCode;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_UUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUL_usercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUL_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUL_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUL_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUL_CreateDate;
        private DevExpress.XtraGrid.GridControl gridControlUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserList;
        private DevExpress.XtraGrid.Columns.GridColumn UserCode;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn CDate;
    }
}
