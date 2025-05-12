using System.Net.NetworkInformation;

namespace NetworkCheckerDaemon
{
    public partial class FrmNetworkCheckerGUI : Form
    {
        private bool allowClose = false;
        private string host = "8.8.8.8";
        public FrmNetworkCheckerGUI()
        {
            InitializeComponent();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            Ping pingHost = new Ping();
            PingReply reply = pingHost.Send(host);

            string statusIcon = "";
            switch (reply.RoundtripTime)
            {
                case < 50:
                    statusIcon = "[\u2714] ";
                    tlstrptxtbx_Status.ForeColor = Color.Green;
                    break;
                case < 100:
                    statusIcon = "[\u26A0] ";
                    tlstrptxtbx_Status.ForeColor = Color.Orange;
                    break;
                case < 200:
                    statusIcon = "[\u0021] ";
                    tlstrptxtbx_Status.ForeColor = Color.Red;
                    break;
                case > 200:
                    statusIcon = "[\u2716] ";
                    tlstrptxtbx_Status.ForeColor = Color.Black;
                    break;
                default:
                    statusIcon = "[Error] ";
                    tlstrptxtbx_Status.ForeColor = Color.Black;
                    break;
            }

            string statusText = "";
            if (reply.Status.ToString().Equals("Success"))
                statusText = "Accessible";
            else
                statusText = "Not accessible";

            tlstrptxtbx_Status.Text = statusIcon + statusText;
        }

        private void FrmNetworkCheckerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                e.Cancel = true;

                this.Hide();
                tlstrpmnuitm_HideShow.Text = tlstrpmnuitm_HideShow.Text.Replace("Hide", "Show");
            }
        }

        private void tlstrpmnuitm_HideShow_Click(object sender, EventArgs e)
        {
            if (tlstrpmnuitm_HideShow.Text.Contains("Hide"))
            {
                this.Hide();
                tlstrpmnuitm_HideShow.Text = tlstrpmnuitm_HideShow.Text.Replace("Hide", "Show");
            }
            else 
            { 
                this.Show();
                tlstrpmnuitm_HideShow.Text = tlstrpmnuitm_HideShow.Text.Replace("Show", "Hide");
            }
        }

        private void tlstrpmnuitm_Close_Click(object sender, EventArgs e)
        {
            allowClose = true;
            this.Close();
        }
    }
}
