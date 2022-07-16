namespace LAKMS
{
    partial class LAKMS
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab = new System.Windows.Forms.TabControl();
            this.Tab_LocalActivate = new System.Windows.Forms.TabPage();
            this.GroupBox_KMSProductKey = new System.Windows.Forms.GroupBox();
            this.CheckBox_ManuallySelect = new System.Windows.Forms.CheckBox();
            this.TextBox_KMSProductKey = new System.Windows.Forms.TextBox();
            this.GroupBox_OSInfo = new System.Windows.Forms.GroupBox();
            this.Label_Version = new System.Windows.Forms.Label();
            this.TextBox_Version = new System.Windows.Forms.TextBox();
            this.TextBox_OS = new System.Windows.Forms.TextBox();
            this.Button_GetInfo = new System.Windows.Forms.Button();
            this.Button_Activate = new System.Windows.Forms.Button();
            this.Tab_Server = new System.Windows.Forms.TabPage();
            this.GroupBox_Host = new System.Windows.Forms.GroupBox();
            this.Label_PrivateIPAddress = new System.Windows.Forms.Label();
            this.TextBox_PrivateIPAddress = new System.Windows.Forms.TextBox();
            this.Label_GrobalIPAddress = new System.Windows.Forms.Label();
            this.TextBox_GrobalIPAddress = new System.Windows.Forms.TextBox();
            this.Label_ServerImportant = new System.Windows.Forms.Label();
            this.Button_StartKMSServer = new System.Windows.Forms.Button();
            this.Tab_Settings = new System.Windows.Forms.TabPage();
            this.GroupBox_OnOff = new System.Windows.Forms.GroupBox();
            this.CheckBox_Log = new System.Windows.Forms.CheckBox();
            this.Tab_Advanced = new System.Windows.Forms.TabPage();
            this.Tab_Log = new System.Windows.Forms.TabPage();
            this.TextBox_Log = new System.Windows.Forms.TextBox();
            this.Tab_About = new System.Windows.Forms.TabPage();
            this.Button_ChangeLogs = new System.Windows.Forms.Button();
            this.TextBox_About = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Space = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Label_GitHub = new System.Windows.Forms.Label();
            this.LinkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.Tab.SuspendLayout();
            this.Tab_LocalActivate.SuspendLayout();
            this.GroupBox_KMSProductKey.SuspendLayout();
            this.GroupBox_OSInfo.SuspendLayout();
            this.Tab_Server.SuspendLayout();
            this.GroupBox_Host.SuspendLayout();
            this.Tab_Settings.SuspendLayout();
            this.GroupBox_OnOff.SuspendLayout();
            this.Tab_Log.SuspendLayout();
            this.Tab_About.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Tab_LocalActivate);
            this.Tab.Controls.Add(this.Tab_Server);
            this.Tab.Controls.Add(this.Tab_Settings);
            this.Tab.Controls.Add(this.Tab_Advanced);
            this.Tab.Controls.Add(this.Tab_Log);
            this.Tab.Controls.Add(this.Tab_About);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(453, 363);
            this.Tab.TabIndex = 0;
            // 
            // Tab_LocalActivate
            // 
            this.Tab_LocalActivate.Controls.Add(this.GroupBox_KMSProductKey);
            this.Tab_LocalActivate.Controls.Add(this.GroupBox_OSInfo);
            this.Tab_LocalActivate.Controls.Add(this.Button_GetInfo);
            this.Tab_LocalActivate.Controls.Add(this.Button_Activate);
            this.Tab_LocalActivate.Location = new System.Drawing.Point(4, 22);
            this.Tab_LocalActivate.Name = "Tab_LocalActivate";
            this.Tab_LocalActivate.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_LocalActivate.Size = new System.Drawing.Size(445, 337);
            this.Tab_LocalActivate.TabIndex = 0;
            this.Tab_LocalActivate.Text = "LocalActivate";
            this.Tab_LocalActivate.UseVisualStyleBackColor = true;
            // 
            // GroupBox_KMSProductKey
            // 
            this.GroupBox_KMSProductKey.Controls.Add(this.CheckBox_ManuallySelect);
            this.GroupBox_KMSProductKey.Controls.Add(this.TextBox_KMSProductKey);
            this.GroupBox_KMSProductKey.Location = new System.Drawing.Point(6, 83);
            this.GroupBox_KMSProductKey.Name = "GroupBox_KMSProductKey";
            this.GroupBox_KMSProductKey.Size = new System.Drawing.Size(433, 87);
            this.GroupBox_KMSProductKey.TabIndex = 9;
            this.GroupBox_KMSProductKey.TabStop = false;
            this.GroupBox_KMSProductKey.Text = "KMS Product Key";
            // 
            // CheckBox_ManuallySelect
            // 
            this.CheckBox_ManuallySelect.AutoSize = true;
            this.CheckBox_ManuallySelect.Location = new System.Drawing.Point(6, 43);
            this.CheckBox_ManuallySelect.Name = "CheckBox_ManuallySelect";
            this.CheckBox_ManuallySelect.Size = new System.Drawing.Size(369, 16);
            this.CheckBox_ManuallySelect.TabIndex = 9;
            this.CheckBox_ManuallySelect.Text = "Manually Select (If you don\'t know what you are doing, don\'t check)";
            this.CheckBox_ManuallySelect.UseVisualStyleBackColor = true;
            this.CheckBox_ManuallySelect.Click += new System.EventHandler(this.CheckBox_ManuallySelect_Click);
            // 
            // TextBox_KMSProductKey
            // 
            this.TextBox_KMSProductKey.Location = new System.Drawing.Point(6, 18);
            this.TextBox_KMSProductKey.Name = "TextBox_KMSProductKey";
            this.TextBox_KMSProductKey.ReadOnly = true;
            this.TextBox_KMSProductKey.Size = new System.Drawing.Size(421, 19);
            this.TextBox_KMSProductKey.TabIndex = 8;
            this.TextBox_KMSProductKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox_OSInfo
            // 
            this.GroupBox_OSInfo.Controls.Add(this.Label_Version);
            this.GroupBox_OSInfo.Controls.Add(this.TextBox_Version);
            this.GroupBox_OSInfo.Controls.Add(this.TextBox_OS);
            this.GroupBox_OSInfo.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_OSInfo.Name = "GroupBox_OSInfo";
            this.GroupBox_OSInfo.Size = new System.Drawing.Size(433, 71);
            this.GroupBox_OSInfo.TabIndex = 3;
            this.GroupBox_OSInfo.TabStop = false;
            this.GroupBox_OSInfo.Text = "OS Information";
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Location = new System.Drawing.Point(4, 46);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(50, 12);
            this.Label_Version.TabIndex = 3;
            this.Label_Version.Text = "Version: ";
            // 
            // TextBox_Version
            // 
            this.TextBox_Version.Location = new System.Drawing.Point(60, 43);
            this.TextBox_Version.Name = "TextBox_Version";
            this.TextBox_Version.ReadOnly = true;
            this.TextBox_Version.Size = new System.Drawing.Size(100, 19);
            this.TextBox_Version.TabIndex = 2;
            this.TextBox_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_OS
            // 
            this.TextBox_OS.Location = new System.Drawing.Point(6, 18);
            this.TextBox_OS.Name = "TextBox_OS";
            this.TextBox_OS.ReadOnly = true;
            this.TextBox_OS.Size = new System.Drawing.Size(421, 19);
            this.TextBox_OS.TabIndex = 1;
            this.TextBox_OS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_GetInfo
            // 
            this.Button_GetInfo.Location = new System.Drawing.Point(150, 295);
            this.Button_GetInfo.Name = "Button_GetInfo";
            this.Button_GetInfo.Size = new System.Drawing.Size(198, 23);
            this.Button_GetInfo.TabIndex = 2;
            this.Button_GetInfo.Text = "Get Info and Check Compatibility.\r\n";
            this.Button_GetInfo.UseVisualStyleBackColor = true;
            this.Button_GetInfo.Click += new System.EventHandler(this.Button_GetInfo_Click);
            // 
            // Button_Activate
            // 
            this.Button_Activate.Enabled = false;
            this.Button_Activate.Location = new System.Drawing.Point(354, 295);
            this.Button_Activate.Name = "Button_Activate";
            this.Button_Activate.Size = new System.Drawing.Size(75, 23);
            this.Button_Activate.TabIndex = 0;
            this.Button_Activate.Text = "Activate !";
            this.Button_Activate.UseVisualStyleBackColor = true;
            this.Button_Activate.Click += new System.EventHandler(this.Button_Activate_Click);
            // 
            // Tab_Server
            // 
            this.Tab_Server.Controls.Add(this.GroupBox_Host);
            this.Tab_Server.Controls.Add(this.Label_ServerImportant);
            this.Tab_Server.Controls.Add(this.Button_StartKMSServer);
            this.Tab_Server.Location = new System.Drawing.Point(4, 22);
            this.Tab_Server.Name = "Tab_Server";
            this.Tab_Server.Size = new System.Drawing.Size(445, 337);
            this.Tab_Server.TabIndex = 4;
            this.Tab_Server.Text = "Server";
            this.Tab_Server.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Host
            // 
            this.GroupBox_Host.Controls.Add(this.Label_PrivateIPAddress);
            this.GroupBox_Host.Controls.Add(this.TextBox_PrivateIPAddress);
            this.GroupBox_Host.Controls.Add(this.Label_GrobalIPAddress);
            this.GroupBox_Host.Controls.Add(this.TextBox_GrobalIPAddress);
            this.GroupBox_Host.Location = new System.Drawing.Point(5, 3);
            this.GroupBox_Host.Name = "GroupBox_Host";
            this.GroupBox_Host.Size = new System.Drawing.Size(437, 113);
            this.GroupBox_Host.TabIndex = 4;
            this.GroupBox_Host.TabStop = false;
            this.GroupBox_Host.Text = "Host";
            // 
            // Label_PrivateIPAddress
            // 
            this.Label_PrivateIPAddress.AutoSize = true;
            this.Label_PrivateIPAddress.Location = new System.Drawing.Point(6, 40);
            this.Label_PrivateIPAddress.Name = "Label_PrivateIPAddress";
            this.Label_PrivateIPAddress.Size = new System.Drawing.Size(107, 12);
            this.Label_PrivateIPAddress.TabIndex = 4;
            this.Label_PrivateIPAddress.Text = "Private IP Address: ";
            // 
            // TextBox_PrivateIPAddress
            // 
            this.TextBox_PrivateIPAddress.Location = new System.Drawing.Point(119, 37);
            this.TextBox_PrivateIPAddress.Name = "TextBox_PrivateIPAddress";
            this.TextBox_PrivateIPAddress.ReadOnly = true;
            this.TextBox_PrivateIPAddress.Size = new System.Drawing.Size(312, 19);
            this.TextBox_PrivateIPAddress.TabIndex = 5;
            this.TextBox_PrivateIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_GrobalIPAddress
            // 
            this.Label_GrobalIPAddress.AutoSize = true;
            this.Label_GrobalIPAddress.Location = new System.Drawing.Point(6, 15);
            this.Label_GrobalIPAddress.Name = "Label_GrobalIPAddress";
            this.Label_GrobalIPAddress.Size = new System.Drawing.Size(104, 12);
            this.Label_GrobalIPAddress.TabIndex = 2;
            this.Label_GrobalIPAddress.Text = "Grobal IP Address: ";
            // 
            // TextBox_GrobalIPAddress
            // 
            this.TextBox_GrobalIPAddress.Location = new System.Drawing.Point(116, 12);
            this.TextBox_GrobalIPAddress.Name = "TextBox_GrobalIPAddress";
            this.TextBox_GrobalIPAddress.ReadOnly = true;
            this.TextBox_GrobalIPAddress.Size = new System.Drawing.Size(315, 19);
            this.TextBox_GrobalIPAddress.TabIndex = 3;
            this.TextBox_GrobalIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_ServerImportant
            // 
            this.Label_ServerImportant.AutoSize = true;
            this.Label_ServerImportant.ForeColor = System.Drawing.Color.Blue;
            this.Label_ServerImportant.Location = new System.Drawing.Point(3, 310);
            this.Label_ServerImportant.Name = "Label_ServerImportant";
            this.Label_ServerImportant.Size = new System.Drawing.Size(246, 24);
            this.Label_ServerImportant.TabIndex = 1;
            this.Label_ServerImportant.Text = "Important: This isn\'t a local activator, \r\nso This PC can\'t be activate with this" +
    " function.";
            // 
            // Button_StartKMSServer
            // 
            this.Button_StartKMSServer.Location = new System.Drawing.Point(281, 305);
            this.Button_StartKMSServer.Name = "Button_StartKMSServer";
            this.Button_StartKMSServer.Size = new System.Drawing.Size(155, 23);
            this.Button_StartKMSServer.TabIndex = 0;
            this.Button_StartKMSServer.Text = "Start KMS Server";
            this.Button_StartKMSServer.UseVisualStyleBackColor = true;
            this.Button_StartKMSServer.Click += new System.EventHandler(this.Button_StartKMSServer_Click);
            // 
            // Tab_Settings
            // 
            this.Tab_Settings.Controls.Add(this.GroupBox_OnOff);
            this.Tab_Settings.Location = new System.Drawing.Point(4, 22);
            this.Tab_Settings.Name = "Tab_Settings";
            this.Tab_Settings.Size = new System.Drawing.Size(445, 337);
            this.Tab_Settings.TabIndex = 2;
            this.Tab_Settings.Text = "Settings";
            this.Tab_Settings.UseVisualStyleBackColor = true;
            // 
            // GroupBox_OnOff
            // 
            this.GroupBox_OnOff.Controls.Add(this.CheckBox_Log);
            this.GroupBox_OnOff.Location = new System.Drawing.Point(3, 3);
            this.GroupBox_OnOff.Name = "GroupBox_OnOff";
            this.GroupBox_OnOff.Size = new System.Drawing.Size(241, 177);
            this.GroupBox_OnOff.TabIndex = 0;
            this.GroupBox_OnOff.TabStop = false;
            this.GroupBox_OnOff.Text = "On - Off";
            // 
            // CheckBox_Log
            // 
            this.CheckBox_Log.AutoSize = true;
            this.CheckBox_Log.Checked = true;
            this.CheckBox_Log.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Log.Location = new System.Drawing.Point(6, 18);
            this.CheckBox_Log.Name = "CheckBox_Log";
            this.CheckBox_Log.Size = new System.Drawing.Size(42, 16);
            this.CheckBox_Log.TabIndex = 0;
            this.CheckBox_Log.Text = "Log";
            this.CheckBox_Log.UseVisualStyleBackColor = true;
            this.CheckBox_Log.CheckedChanged += new System.EventHandler(this.CheckBox_Log_CheckedChanged);
            // 
            // Tab_Advanced
            // 
            this.Tab_Advanced.Location = new System.Drawing.Point(4, 22);
            this.Tab_Advanced.Name = "Tab_Advanced";
            this.Tab_Advanced.Size = new System.Drawing.Size(445, 337);
            this.Tab_Advanced.TabIndex = 3;
            this.Tab_Advanced.Text = "Advanced";
            this.Tab_Advanced.UseVisualStyleBackColor = true;
            // 
            // Tab_Log
            // 
            this.Tab_Log.BackColor = System.Drawing.Color.Black;
            this.Tab_Log.Controls.Add(this.TextBox_Log);
            this.Tab_Log.Location = new System.Drawing.Point(4, 22);
            this.Tab_Log.Name = "Tab_Log";
            this.Tab_Log.Size = new System.Drawing.Size(445, 337);
            this.Tab_Log.TabIndex = 5;
            this.Tab_Log.Text = "Log";
            // 
            // TextBox_Log
            // 
            this.TextBox_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Log.BackColor = System.Drawing.Color.Black;
            this.TextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Log.ForeColor = System.Drawing.Color.Magenta;
            this.TextBox_Log.Location = new System.Drawing.Point(12, 12);
            this.TextBox_Log.Multiline = true;
            this.TextBox_Log.Name = "TextBox_Log";
            this.TextBox_Log.ReadOnly = true;
            this.TextBox_Log.Size = new System.Drawing.Size(421, 310);
            this.TextBox_Log.TabIndex = 0;
            // 
            // Tab_About
            // 
            this.Tab_About.Controls.Add(this.Button_ChangeLogs);
            this.Tab_About.Controls.Add(this.TextBox_About);
            this.Tab_About.Location = new System.Drawing.Point(4, 22);
            this.Tab_About.Name = "Tab_About";
            this.Tab_About.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_About.Size = new System.Drawing.Size(445, 337);
            this.Tab_About.TabIndex = 1;
            this.Tab_About.Text = "About";
            this.Tab_About.UseVisualStyleBackColor = true;
            // 
            // Button_ChangeLogs
            // 
            this.Button_ChangeLogs.Location = new System.Drawing.Point(330, 308);
            this.Button_ChangeLogs.Name = "Button_ChangeLogs";
            this.Button_ChangeLogs.Size = new System.Drawing.Size(89, 23);
            this.Button_ChangeLogs.TabIndex = 2;
            this.Button_ChangeLogs.Text = "ChangeLogs";
            this.Button_ChangeLogs.UseVisualStyleBackColor = true;
            this.Button_ChangeLogs.Click += new System.EventHandler(this.Button_ChangeLogs_Click);
            // 
            // TextBox_About
            // 
            this.TextBox_About.BackColor = System.Drawing.Color.White;
            this.TextBox_About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_About.Location = new System.Drawing.Point(3, 3);
            this.TextBox_About.Multiline = true;
            this.TextBox_About.Name = "TextBox_About";
            this.TextBox_About.ReadOnly = true;
            this.TextBox_About.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_About.Size = new System.Drawing.Size(439, 331);
            this.TextBox_About.TabIndex = 1;
            this.TextBox_About.Text = "LAKMS by zulux07437.\r\n\r\nThis program runs KMS Emulation locally and obtains a pse" +
    "udo License.\r\n\r\nIt is simple, But can runs KMS Emulation Server and activate oth" +
    "er Windows Products.";
            this.TextBox_About.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_Label,
            this.StatusStrip_Space,
            this.StatusStrip_ProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 435);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(477, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStrip_Label
            // 
            this.StatusStrip_Label.Name = "StatusStrip_Label";
            this.StatusStrip_Label.Size = new System.Drawing.Size(46, 17);
            this.StatusStrip_Label.Text = "v1.0.0.0";
            // 
            // StatusStrip_Space
            // 
            this.StatusStrip_Space.Name = "StatusStrip_Space";
            this.StatusStrip_Space.Size = new System.Drawing.Size(114, 17);
            this.StatusStrip_Space.Spring = true;
            // 
            // StatusStrip_ProgressBar
            // 
            this.StatusStrip_ProgressBar.Maximum = 10;
            this.StatusStrip_ProgressBar.Name = "StatusStrip_ProgressBar";
            this.StatusStrip_ProgressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // Label_GitHub
            // 
            this.Label_GitHub.AutoSize = true;
            this.Label_GitHub.Location = new System.Drawing.Point(12, 378);
            this.Label_GitHub.Name = "Label_GitHub";
            this.Label_GitHub.Size = new System.Drawing.Size(331, 12);
            this.Label_GitHub.TabIndex = 2;
            this.Label_GitHub.Text = "The idea and some source code are from The Microsoft Toolkit.";
            // 
            // LinkLabel_GitHub
            // 
            this.LinkLabel_GitHub.AutoSize = true;
            this.LinkLabel_GitHub.Location = new System.Drawing.Point(437, 423);
            this.LinkLabel_GitHub.Name = "LinkLabel_GitHub";
            this.LinkLabel_GitHub.Size = new System.Drawing.Size(40, 12);
            this.LinkLabel_GitHub.TabIndex = 3;
            this.LinkLabel_GitHub.TabStop = true;
            this.LinkLabel_GitHub.Text = "GitHub";
            this.LinkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_GitHub_LinkClicked);
            // 
            // LAKMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 457);
            this.Controls.Add(this.LinkLabel_GitHub);
            this.Controls.Add(this.Label_GitHub);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LAKMS";
            this.ShowIcon = false;
            this.Text = "LAKMS";
            this.Load += new System.EventHandler(this.LAKMS_Load);
            this.Tab.ResumeLayout(false);
            this.Tab_LocalActivate.ResumeLayout(false);
            this.GroupBox_KMSProductKey.ResumeLayout(false);
            this.GroupBox_KMSProductKey.PerformLayout();
            this.GroupBox_OSInfo.ResumeLayout(false);
            this.GroupBox_OSInfo.PerformLayout();
            this.Tab_Server.ResumeLayout(false);
            this.Tab_Server.PerformLayout();
            this.GroupBox_Host.ResumeLayout(false);
            this.GroupBox_Host.PerformLayout();
            this.Tab_Settings.ResumeLayout(false);
            this.GroupBox_OnOff.ResumeLayout(false);
            this.GroupBox_OnOff.PerformLayout();
            this.Tab_Log.ResumeLayout(false);
            this.Tab_Log.PerformLayout();
            this.Tab_About.ResumeLayout(false);
            this.Tab_About.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Tab_LocalActivate;
        private System.Windows.Forms.TabPage Tab_About;
        private System.Windows.Forms.Button Button_Activate;
        private System.Windows.Forms.TextBox TextBox_OS;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripProgressBar StatusStrip_ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Label;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Space;
        private System.Windows.Forms.Button Button_GetInfo;
        private System.Windows.Forms.GroupBox GroupBox_OSInfo;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.TextBox TextBox_Version;
        private System.Windows.Forms.GroupBox GroupBox_KMSProductKey;
        private System.Windows.Forms.TextBox TextBox_KMSProductKey;
        private System.Windows.Forms.CheckBox CheckBox_ManuallySelect;
        private System.Windows.Forms.TabPage Tab_Settings;
        private System.Windows.Forms.TextBox TextBox_About;
        private System.Windows.Forms.TabPage Tab_Advanced;
        private System.Windows.Forms.TabPage Tab_Server;
        private System.Windows.Forms.TabPage Tab_Log;
        private System.Windows.Forms.TextBox TextBox_Log;
        private System.Windows.Forms.Button Button_StartKMSServer;
        private System.Windows.Forms.Label Label_ServerImportant;
        private System.Windows.Forms.GroupBox GroupBox_Host;
        private System.Windows.Forms.Label Label_GrobalIPAddress;
        private System.Windows.Forms.TextBox TextBox_GrobalIPAddress;
        private System.Windows.Forms.Label Label_PrivateIPAddress;
        private System.Windows.Forms.TextBox TextBox_PrivateIPAddress;
        private System.Windows.Forms.Button Button_ChangeLogs;
        private System.Windows.Forms.GroupBox GroupBox_OnOff;
        private System.Windows.Forms.CheckBox CheckBox_Log;
        private System.Windows.Forms.Label Label_GitHub;
        private System.Windows.Forms.LinkLabel LinkLabel_GitHub;
    }
}

