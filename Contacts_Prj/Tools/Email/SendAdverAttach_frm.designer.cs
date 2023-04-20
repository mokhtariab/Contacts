namespace Contacts_Prj
{
    partial class SendAdverAttach_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendAdverAttach_frm));
            this.ribbonBar_ieSearch = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.panel_Text = new DevComponents.DotNetBar.PanelEx();
            this.listViewAttach = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chSize = new System.Windows.Forms.ColumnHeader();
            this.btnDelAll = new DevComponents.DotNetBar.ButtonX();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalFile_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Text.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
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
            this.ribbonBar_ieSearch.Size = new System.Drawing.Size(465, 67);
            this.ribbonBar_ieSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_ieSearch.TabIndex = 11;
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
            this.panel_Text.Controls.Add(this.listViewAttach);
            this.panel_Text.Controls.Add(this.btnDelAll);
            this.panel_Text.Controls.Add(this.btnDel);
            this.panel_Text.Controls.Add(this.btnAdd);
            this.panel_Text.Controls.Add(this.label1);
            this.panel_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Text.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_Text.Location = new System.Drawing.Point(0, 67);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(465, 399);
            this.panel_Text.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_Text.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_Text.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_Text.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_Text.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_Text.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_Text.Style.GradientAngle = 90;
            this.panel_Text.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_Text.TabIndex = 12;
            this.panel_Text.Text = "لیست فایل های اضافه شده";
            // 
            // listViewAttach
            // 
            this.listViewAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAttach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSize});
            this.listViewAttach.Location = new System.Drawing.Point(12, 57);
            this.listViewAttach.Name = "listViewAttach";
            this.listViewAttach.RightToLeftLayout = true;
            this.listViewAttach.Size = new System.Drawing.Size(379, 332);
            this.listViewAttach.TabIndex = 6;
            this.listViewAttach.UseCompatibleStateImageBehavior = false;
            this.listViewAttach.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "نام فایل";
            this.chName.Width = 262;
            // 
            // chSize
            // 
            this.chSize.Text = "سایز (کیلو بایت)";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSize.Width = 100;
            // 
            // btnDelAll
            // 
            this.btnDelAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDelAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAll.Image")));
            this.btnDelAll.Location = new System.Drawing.Point(397, 133);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(56, 32);
            this.btnDelAll.TabIndex = 5;
            this.btnDelAll.Text = "حذف کلی";
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(397, 95);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(56, 32);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "حذف";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(397, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "توجه: حداکثر مجموع حجم فایل ها 15000 کیلوبایت می باشد.";
            // 
            // TotalFile_lbl
            // 
            this.TotalFile_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalFile_lbl.BackColor = System.Drawing.Color.MistyRose;
            this.TotalFile_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFile_lbl.Location = new System.Drawing.Point(210, 3);
            this.TotalFile_lbl.Name = "TotalFile_lbl";
            this.TotalFile_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalFile_lbl.Size = new System.Drawing.Size(148, 26);
            this.TotalFile_lbl.TabIndex = 2;
            this.TotalFile_lbl.Text = "0";
            this.TotalFile_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(360, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "حجم فایل ها:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.TotalFile_lbl);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 466);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(465, 32);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(143, 8);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "کیلو بایت";
            // 
            // SendAdverAttach_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 498);
            this.Controls.Add(this.panel_Text);
            this.Controls.Add(this.ribbonBar_ieSearch);
            this.Controls.Add(this.panelEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendAdverAttach_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن فایل (Attachments)";
            this.TopMost = true;
            this.panel_Text.ResumeLayout(false);
            this.panel_Text.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_ieSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.PanelEx panel_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalFile_lbl;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnDelAll;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ListView listViewAttach;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.Label label3;
    }
}