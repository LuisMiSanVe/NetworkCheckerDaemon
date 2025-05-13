using System.Net.NetworkInformation;

namespace NetworkCheckerDaemon
{
    public partial class FrmNetworkCheckerGUI : Form
    {
        private bool allowClose = false;
        private bool showErrorWindow = true;
        public FrmNetworkCheckerGUI()
        {
            InitializeComponent();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                Ping pingHost = new Ping();
                PingReply reply = pingHost.Send(txtbx_hostValue.Text);

                // Style the response data
                string statusIcon = "";
                switch (reply.RoundtripTime)
                {
                    case < 50:
                        statusIcon = "[\u2714] "; // Check Unicode Symbol
                        tlstrptxtbx_Status.ForeColor = Color.Green;
                        lbl_StatusValue.ForeColor = Color.Green;
                        break;
                    case < 100:
                        statusIcon = "[\u26A0] "; // Warning Unicode Symbol
                        tlstrptxtbx_Status.ForeColor = Color.Orange;
                        lbl_StatusValue.ForeColor = Color.Orange;
                        break;
                    case < 200:
                        statusIcon = "[\u0021] "; // Exclamation Unicode Symbol
                        tlstrptxtbx_Status.ForeColor = Color.Red;
                        lbl_StatusValue.ForeColor = Color.Red;
                        break;
                    case > 200:
                        statusIcon = "[\u2716] "; // Cross Unicode Symbol
                        tlstrptxtbx_Status.ForeColor = Color.Black;
                        lbl_StatusValue.ForeColor = Color.Black;
                        break;
                    default:
                        statusIcon = "[Error] ";
                        tlstrptxtbx_Status.ForeColor = Color.Black;
                        lbl_StatusValue.ForeColor = Color.Black;
                        break;
                }

                string statusText = "";
                if (reply.Status.ToString().Equals("Success"))
                    statusText = "Accessible";
                else
                    statusText = "Not accessible";
                
                // Show the data
                tlstrptxtbx_Status.Text = statusIcon + statusText;
                lbl_StatusValue.Text = statusIcon + statusText;
                lbl_PingStatusValue.Text = reply.Status.ToString();
                lbl_TripTimeValue.Text = reply.RoundtripTime.ToString() + " ms";
                lbl_BufferValue.Text = reply.Buffer.Length.ToString() + " bytes";
                if (reply.Options != null)
                {
                    lbl_TTLValue.Text = reply.Options.Ttl.ToString() + " jumps";
                    if (reply.Options.DontFragment)
                        lbl_FragmentValue.Text = "The package can be fragmented";
                    else
                        lbl_FragmentValue.Text = "The package can't be fragmented";
                }
                else
                {
                    lbl_TTLValue.Text = "Couldn't determine router jumps";
                    lbl_FragmentValue.Text = "Couldn't determine fragmentability";
                }
            }
            catch (Exception ex)
            {
                if (showErrorWindow)
                {
                    btn_StartStop_Click(sender, e);
                    var result = MessageBox.Show("An unexpected error has occurred, is possible the configured host is not reachable or doesn't exist.\nDo you want a notification to show up and the Daemon to stop each time an error occurs?", ex.Message, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.No)
                        showErrorWindow = false;
                }
                else
                {
                    lbl_StatusValue.Text = "An error occurred.";
                }
            }
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            tlstrpmnuitm_Close_Click(sender,e);
        }

        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            if (tmrCheck.Enabled)
            {
                tmrCheck.Enabled = false;
                btn_StartStop.BackgroundImage = imglst_startstop.Images[0];
                lbl_StatusValue.ForeColor = Color.Black;
                lbl_StatusValue.Text = "The Daemon is stopped.";
                txtbx_hostValue.Enabled = true;
            }
            else
            {
                tmrCheck.Enabled = true;
                btn_StartStop.BackgroundImage = imglst_startstop.Images[1];
                lbl_StatusValue.ForeColor = Color.Black;
                lbl_StatusValue.Text = "Scanning...";
                txtbx_hostValue.Enabled = false;
            }
        }
    }
}
