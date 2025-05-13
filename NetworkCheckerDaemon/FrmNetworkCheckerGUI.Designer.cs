namespace NetworkCheckerDaemon
{
    partial class FrmNetworkCheckerGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNetworkCheckerGUI));
            tmrCheck = new System.Windows.Forms.Timer(components);
            ntficnTaskbarCheck = new NotifyIcon(components);
            cntxmnustpOptions = new ContextMenuStrip(components);
            tlstrptxtbx_StatusLabel = new ToolStripTextBox();
            tlstrptxtbx_Status = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            tlstrpmnuitm_HideShow = new ToolStripMenuItem();
            tlstrpmnuitm_Close = new ToolStripMenuItem();
            grpbx_Advanced = new GroupBox();
            txtbx_hostValue = new TextBox();
            lbl_FragmentValue = new Label();
            lbl_Fragment = new Label();
            lbl_TTLValue = new Label();
            lbl_BufferValue = new Label();
            lbl_TripTimeValue = new Label();
            lbl_TTL = new Label();
            lbl_Buffer = new Label();
            lbl_TripTime = new Label();
            lbl_host = new Label();
            lbl_Status = new Label();
            lbl_StatusValue = new Label();
            lbl_PingStatusValue = new Label();
            lbl_PingStatus = new Label();
            btn_StartStop = new Button();
            btn_Close = new Button();
            imglst_startstop = new ImageList(components);
            tltp_Help = new ToolTip(components);
            cntxmnustpOptions.SuspendLayout();
            grpbx_Advanced.SuspendLayout();
            SuspendLayout();
            // 
            // tmrCheck
            // 
            tmrCheck.Enabled = true;
            tmrCheck.Interval = 1000;
            tmrCheck.Tick += tmrCheck_Tick;
            // 
            // ntficnTaskbarCheck
            // 
            ntficnTaskbarCheck.ContextMenuStrip = cntxmnustpOptions;
            ntficnTaskbarCheck.Icon = (Icon)resources.GetObject("ntficnTaskbarCheck.Icon");
            ntficnTaskbarCheck.Text = "Network Checker";
            ntficnTaskbarCheck.Visible = true;
            // 
            // cntxmnustpOptions
            // 
            cntxmnustpOptions.ImageScalingSize = new Size(24, 24);
            cntxmnustpOptions.Items.AddRange(new ToolStripItem[] { tlstrptxtbx_StatusLabel, tlstrptxtbx_Status, toolStripSeparator1, tlstrpmnuitm_HideShow, tlstrpmnuitm_Close });
            cntxmnustpOptions.Name = "cntxmnustpOptions";
            cntxmnustpOptions.Size = new Size(226, 144);
            // 
            // tlstrptxtbx_StatusLabel
            // 
            tlstrptxtbx_StatusLabel.Enabled = false;
            tlstrptxtbx_StatusLabel.Name = "tlstrptxtbx_StatusLabel";
            tlstrptxtbx_StatusLabel.Size = new Size(150, 31);
            tlstrptxtbx_StatusLabel.Text = "Network Status:";
            // 
            // tlstrptxtbx_Status
            // 
            tlstrptxtbx_Status.Name = "tlstrptxtbx_Status";
            tlstrptxtbx_Status.Size = new Size(150, 31);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(222, 6);
            // 
            // tlstrpmnuitm_HideShow
            // 
            tlstrpmnuitm_HideShow.Name = "tlstrpmnuitm_HideShow";
            tlstrpmnuitm_HideShow.Size = new Size(225, 32);
            tlstrpmnuitm_HideShow.Text = "Hide Detailed GUI";
            tlstrpmnuitm_HideShow.Click += tlstrpmnuitm_HideShow_Click;
            // 
            // tlstrpmnuitm_Close
            // 
            tlstrpmnuitm_Close.Name = "tlstrpmnuitm_Close";
            tlstrpmnuitm_Close.Size = new Size(225, 32);
            tlstrpmnuitm_Close.Text = "Close";
            tlstrpmnuitm_Close.Click += tlstrpmnuitm_Close_Click;
            // 
            // grpbx_Advanced
            // 
            grpbx_Advanced.Controls.Add(txtbx_hostValue);
            grpbx_Advanced.Controls.Add(lbl_FragmentValue);
            grpbx_Advanced.Controls.Add(lbl_Fragment);
            grpbx_Advanced.Controls.Add(lbl_TTLValue);
            grpbx_Advanced.Controls.Add(lbl_BufferValue);
            grpbx_Advanced.Controls.Add(lbl_TripTimeValue);
            grpbx_Advanced.Controls.Add(lbl_TTL);
            grpbx_Advanced.Controls.Add(lbl_Buffer);
            grpbx_Advanced.Controls.Add(lbl_TripTime);
            grpbx_Advanced.Controls.Add(lbl_host);
            grpbx_Advanced.Location = new Point(12, 84);
            grpbx_Advanced.Name = "grpbx_Advanced";
            grpbx_Advanced.Size = new Size(417, 223);
            grpbx_Advanced.TabIndex = 1;
            grpbx_Advanced.TabStop = false;
            grpbx_Advanced.Text = "Advanced";
            // 
            // txtbx_hostValue
            // 
            txtbx_hostValue.Enabled = false;
            txtbx_hostValue.Location = new Point(113, 34);
            txtbx_hostValue.Name = "txtbx_hostValue";
            txtbx_hostValue.Size = new Size(298, 31);
            txtbx_hostValue.TabIndex = 10;
            txtbx_hostValue.Text = "8.8.8.8";
            // 
            // lbl_FragmentValue
            // 
            lbl_FragmentValue.AutoSize = true;
            lbl_FragmentValue.Location = new Point(113, 187);
            lbl_FragmentValue.Name = "lbl_FragmentValue";
            lbl_FragmentValue.Size = new Size(96, 25);
            lbl_FragmentValue.TabIndex = 9;
            lbl_FragmentValue.Text = "Scanning...";
            // 
            // lbl_Fragment
            // 
            lbl_Fragment.AutoSize = true;
            lbl_Fragment.Location = new Point(6, 187);
            lbl_Fragment.Name = "lbl_Fragment";
            lbl_Fragment.Size = new Size(92, 25);
            lbl_Fragment.TabIndex = 8;
            lbl_Fragment.Text = "Fragment:";
            // 
            // lbl_TTLValue
            // 
            lbl_TTLValue.AutoSize = true;
            lbl_TTLValue.Location = new Point(113, 151);
            lbl_TTLValue.Name = "lbl_TTLValue";
            lbl_TTLValue.Size = new Size(96, 25);
            lbl_TTLValue.TabIndex = 7;
            lbl_TTLValue.Text = "Scanning...";
            // 
            // lbl_BufferValue
            // 
            lbl_BufferValue.AutoSize = true;
            lbl_BufferValue.Location = new Point(113, 113);
            lbl_BufferValue.Name = "lbl_BufferValue";
            lbl_BufferValue.Size = new Size(96, 25);
            lbl_BufferValue.TabIndex = 6;
            lbl_BufferValue.Text = "Scanning...";
            // 
            // lbl_TripTimeValue
            // 
            lbl_TripTimeValue.AutoSize = true;
            lbl_TripTimeValue.Location = new Point(113, 73);
            lbl_TripTimeValue.Name = "lbl_TripTimeValue";
            lbl_TripTimeValue.Size = new Size(96, 25);
            lbl_TripTimeValue.TabIndex = 5;
            lbl_TripTimeValue.Text = "Scanning...";
            // 
            // lbl_TTL
            // 
            lbl_TTL.AutoSize = true;
            lbl_TTL.Location = new Point(6, 151);
            lbl_TTL.Name = "lbl_TTL";
            lbl_TTL.Size = new Size(42, 25);
            lbl_TTL.TabIndex = 3;
            lbl_TTL.Text = "TTL:";
            // 
            // lbl_Buffer
            // 
            lbl_Buffer.AutoSize = true;
            lbl_Buffer.Location = new Point(6, 113);
            lbl_Buffer.Name = "lbl_Buffer";
            lbl_Buffer.Size = new Size(63, 25);
            lbl_Buffer.TabIndex = 2;
            lbl_Buffer.Text = "Buffer:";
            // 
            // lbl_TripTime
            // 
            lbl_TripTime.AutoSize = true;
            lbl_TripTime.Location = new Point(6, 73);
            lbl_TripTime.Name = "lbl_TripTime";
            lbl_TripTime.Size = new Size(87, 25);
            lbl_TripTime.TabIndex = 1;
            lbl_TripTime.Text = "Trip Time:";
            // 
            // lbl_host
            // 
            lbl_host.AutoSize = true;
            lbl_host.Location = new Point(6, 34);
            lbl_host.Name = "lbl_host";
            lbl_host.Size = new Size(54, 25);
            lbl_host.TabIndex = 0;
            lbl_host.Text = "Host:";
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Location = new Point(12, 9);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(136, 25);
            lbl_Status.TabIndex = 3;
            lbl_Status.Text = "Network Status:";
            // 
            // lbl_StatusValue
            // 
            lbl_StatusValue.AutoSize = true;
            lbl_StatusValue.Location = new Point(154, 9);
            lbl_StatusValue.Name = "lbl_StatusValue";
            lbl_StatusValue.Size = new Size(96, 25);
            lbl_StatusValue.TabIndex = 4;
            lbl_StatusValue.Text = "Scanning...";
            // 
            // lbl_PingStatusValue
            // 
            lbl_PingStatusValue.AutoSize = true;
            lbl_PingStatusValue.Location = new Point(154, 48);
            lbl_PingStatusValue.Name = "lbl_PingStatusValue";
            lbl_PingStatusValue.Size = new Size(96, 25);
            lbl_PingStatusValue.TabIndex = 9;
            lbl_PingStatusValue.Text = "Scanning...";
            // 
            // lbl_PingStatus
            // 
            lbl_PingStatus.AutoSize = true;
            lbl_PingStatus.Location = new Point(12, 48);
            lbl_PingStatus.Name = "lbl_PingStatus";
            lbl_PingStatus.Size = new Size(133, 25);
            lbl_PingStatus.TabIndex = 8;
            lbl_PingStatus.Text = "Package Status:";
            // 
            // btn_StartStop
            // 
            btn_StartStop.BackgroundImage = (Image)resources.GetObject("btn_StartStop.BackgroundImage");
            btn_StartStop.BackgroundImageLayout = ImageLayout.Stretch;
            btn_StartStop.Location = new Point(397, 12);
            btn_StartStop.Name = "btn_StartStop";
            btn_StartStop.Size = new Size(30, 30);
            btn_StartStop.TabIndex = 10;
            tltp_Help.SetToolTip(btn_StartStop, "Start or Stop the Daemon");
            btn_StartStop.UseVisualStyleBackColor = true;
            btn_StartStop.Click += btn_StartStop_Click;
            // 
            // btn_Close
            // 
            btn_Close.BackgroundImage = (Image)resources.GetObject("btn_Close.BackgroundImage");
            btn_Close.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Close.Location = new Point(397, 57);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(30, 30);
            btn_Close.TabIndex = 11;
            tltp_Help.SetToolTip(btn_Close, "Close");
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // imglst_startstop
            // 
            imglst_startstop.ColorDepth = ColorDepth.Depth32Bit;
            imglst_startstop.ImageStream = (ImageListStreamer)resources.GetObject("imglst_startstop.ImageStream");
            imglst_startstop.TransparentColor = Color.Transparent;
            imglst_startstop.Images.SetKeyName(0, "buttonStart.png");
            imglst_startstop.Images.SetKeyName(1, "buttonStop.png");
            // 
            // FrmNetworkCheckerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 316);
            Controls.Add(btn_Close);
            Controls.Add(btn_StartStop);
            Controls.Add(lbl_PingStatusValue);
            Controls.Add(lbl_PingStatus);
            Controls.Add(lbl_StatusValue);
            Controls.Add(lbl_Status);
            Controls.Add(grpbx_Advanced);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmNetworkCheckerGUI";
            Text = "Network Checker GUI";
            FormClosing += FrmNetworkCheckerGUI_FormClosing;
            cntxmnustpOptions.ResumeLayout(false);
            cntxmnustpOptions.PerformLayout();
            grpbx_Advanced.ResumeLayout(false);
            grpbx_Advanced.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrCheck;
        private NotifyIcon ntficnTaskbarCheck;
        private ContextMenuStrip cntxmnustpOptions;
        private ToolStripTextBox tlstrptxtbx_StatusLabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tlstrpmnuitm_Close;
        private ToolStripTextBox tlstrptxtbx_Status;
        private ToolStripMenuItem tlstrpmnuitm_HideShow;
        private GroupBox grpbx_Advanced;
        private Label lbl_Status;
        private Label lbl_StatusValue;
        private Label lbl_host;
        private Label lbl_TTL;
        private Label lbl_TripTime;
        private Label lbl_Buffer;
        private Label lbl_TTLValue;
        private Label lbl_BufferValue;
        private Label lbl_TripTimeValue;
        private Label lbl_PingStatusValue;
        private Label lbl_PingStatus;
        private Label lbl_FragmentValue;
        private Label lbl_Fragment;
        private Button btn_StartStop;
        private Button btn_Close;
        private ImageList imglst_startstop;
        private TextBox txtbx_hostValue;
        private ToolTip tltp_Help;
    }
}
