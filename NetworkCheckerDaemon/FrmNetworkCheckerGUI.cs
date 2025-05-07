using System.Net.NetworkInformation;

namespace NetworkCheckerDaemon
{
    public partial class FrmNetworkCheckerGUI : Form
    {
        private bool allowClose = false;
        public FrmNetworkCheckerGUI()
        {
            InitializeComponent();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            Ping ping = new Ping();
        }

        private void FrmNetworkCheckerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                e.Cancel = true;

                this.Hide();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            this.Close();
        }
    }
}
