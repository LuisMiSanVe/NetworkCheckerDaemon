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
            cntxmnustpOptions.SuspendLayout();
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
            // FrmNetworkCheckerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNetworkCheckerGUI";
            Text = "Network Checker GUI";
            FormClosing += FrmNetworkCheckerGUI_FormClosing;
            cntxmnustpOptions.ResumeLayout(false);
            cntxmnustpOptions.PerformLayout();
            ResumeLayout(false);
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
    }
}
