namespace Contacts_Prj
{
    partial class NEMobGroup_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NEMobGroup_frm));
            this.button_OK = new DevComponents.DotNetBar.ButtonX();
            this.button_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel_EnterPass = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBox_GroupName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel_EnterPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_OK.ForeColor = System.Drawing.Color.Black;
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(169, 56);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.button_OK.Size = new System.Drawing.Size(122, 24);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "تایید";
            this.button_OK.Tooltip = "F2";
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("button_Cancel.Image")));
            this.button_Cancel.Location = new System.Drawing.Point(41, 56);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(122, 24);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "انصراف";
            this.button_Cancel.Tooltip = "Esc";
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupPanel_EnterPass
            // 
            this.groupPanel_EnterPass.CanvasColor = System.Drawing.Color.Empty;
            this.groupPanel_EnterPass.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_EnterPass.Controls.Add(this.textBox_GroupName);
            this.groupPanel_EnterPass.Controls.Add(this.labelX3);
            this.groupPanel_EnterPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_EnterPass.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_EnterPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_EnterPass.Name = "groupPanel_EnterPass";
            this.groupPanel_EnterPass.Size = new System.Drawing.Size(332, 49);
            // 
            // 
            // 
            this.groupPanel_EnterPass.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupPanel_EnterPass.Style.BackColor2 = System.Drawing.SystemColors.ButtonHighlight;
            this.groupPanel_EnterPass.Style.BackColorGradientAngle = 90;
            this.groupPanel_EnterPass.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderBottomWidth = 1;
            this.groupPanel_EnterPass.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_EnterPass.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderLeftWidth = 1;
            this.groupPanel_EnterPass.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderRightWidth = 1;
            this.groupPanel_EnterPass.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderTopWidth = 1;
            this.groupPanel_EnterPass.Style.CornerDiameter = 4;
            this.groupPanel_EnterPass.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_EnterPass.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_EnterPass.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_EnterPass.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_EnterPass.TabIndex = 0;
            // 
            // textBox_GroupName
            // 
            // 
            // 
            // 
            this.textBox_GroupName.Border.Class = "TextBoxBorder";
            this.textBox_GroupName.Location = new System.Drawing.Point(36, 12);
            this.textBox_GroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_GroupName.Name = "textBox_GroupName";
            this.textBox_GroupName.Size = new System.Drawing.Size(214, 22);
            this.textBox_GroupName.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(247, 10);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 22);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "نام گروه:";
            // 
            // NEMobGroup_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 89);
            this.Controls.Add(this.groupPanel_EnterPass);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Cancel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "NEMobGroup_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گروه";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NEMobGroup_frm_KeyDown);
            this.groupPanel_EnterPass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX button_OK;
        public DevComponents.DotNetBar.ButtonX button_Cancel;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_GroupName;
        private DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel_EnterPass;
    }
}