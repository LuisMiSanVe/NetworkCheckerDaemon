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
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            cntxmnustpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // tmrCheck
            // 
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
            cntxmnustpOptions.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripSeparator1, closeToolStripMenuItem });
            cntxmnustpOptions.Name = "cntxmnustpOptions";
            cntxmnustpOptions.Size = new Size(161, 77);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 31);
            toolStripTextBox1.Text = "A";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(160, 32);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // FrmNetworkCheckerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmNetworkCheckerGUI";
            Text = "Form1";
            FormClosing += FrmNetworkCheckerGUI_FormClosing;
            cntxmnustpOptions.ResumeLayout(false);
            cntxmnustpOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer tmrCheck;
        private NotifyIcon ntficnTaskbarCheck;
        private ContextMenuStrip cntxmnustpOptions;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}
