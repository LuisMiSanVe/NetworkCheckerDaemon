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
            // Open in a different Thread to not interrupt the UI Thread
            new Thread(() =>
            {
                this.Invoke(() => { tmrCheck.Enabled = false; });
                string statusText = "";
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
                            this.Invoke(() => {
                                tlstrptxtbx_Status.ForeColor = Color.Green;
                                lbl_StatusValue.ForeColor = Color.Green;
                            });
                            break;
                        case < 100:
                            statusIcon = "[\u26A0] "; // Warning Unicode Symbol
                            this.Invoke(() =>
                            {
                                tlstrptxtbx_Status.ForeColor = Color.Orange;
                                lbl_StatusValue.ForeColor = Color.Orange;
                            });
                            break;
                        case < 200:
                            statusIcon = "[\u0021] "; // Exclamation Unicode Symbol
                            this.Invoke(() =>
                            {
                                tlstrptxtbx_Status.ForeColor = Color.Red;
                                lbl_StatusValue.ForeColor = Color.Red;
                            });
                            break;
                        case > 200:
                            statusIcon = "[\u2716] "; // Cross Unicode Symbol
                            this.Invoke(() =>
                            {
                                tlstrptxtbx_Status.ForeColor = Color.Black;
                                lbl_StatusValue.ForeColor = Color.Black;
                            });
                            break;
                        default:
                            statusIcon = "[Error] ";
                            this.Invoke(() =>
                            {
                                tlstrptxtbx_Status.ForeColor = Color.Black;
                                lbl_StatusValue.ForeColor = Color.Black;
                            });
                            break;
                    }
                    if (reply.Status.ToString().Equals("Success")) // PING successs
                    {
                        statusText = "Accessible";
                        this.Invoke(() =>
                        {
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
                        });
                    }
                    else // PING fail
                    {
                        statusText = "Not accessible";
                        this.Invoke(() =>
                        {
                            tlstrptxtbx_Status.ForeColor = Color.Red;
                            lbl_StatusValue.ForeColor = Color.Red;
                            tlstrptxtbx_Status.Text = statusText;
                            lbl_StatusValue.Text = statusText;
                            lbl_PingStatusValue.Text = "Error";
                            lbl_TripTimeValue.Text = "Error";
                            lbl_BufferValue.Text = "Error";
                            lbl_TTLValue.Text = "Error";
                            lbl_FragmentValue.Text = "Error";
                            throw new Exception(statusText);
                        });
                    }
                    this.Invoke(() => { tmrCheck.Enabled = true; });
                }
                catch (Exception ex)
                {
                    this.Invoke(() =>
                    {
                        if (showErrorWindow)
                        {
                            btn_StartStop.BackgroundImage = imglst_startstop.Images[0];
                            lbl_StatusValue.ForeColor = Color.Black;
                            tlstrptxtbx_Status.ForeColor = Color.Black;
                            lbl_StatusValue.Text = "The Daemon is stopped.";
                            tlstrptxtbx_Status.Text = "The Daemon is stopped.";
                            txtbx_hostValue.Enabled = true;
                            tlstrpmnuitm_StartStop.Text = "Start Daemon";
                            var result = MessageBox.Show("An error has occurred, is possible the configured host is not reachable or doesn't exist.\nDo you want a notification to show up and the Daemon to stop each time an error occurs?", ex.Message, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.No)
                                showErrorWindow = false;
                        }
                    });
                }
            }).Start();
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

        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            if (tmrCheck.Enabled || lbl_StatusValue.ForeColor == Color.Red || lbl_StatusValue.Text.Contains("Not accessible"))
            {
                tmrCheck.Enabled = false;
                btn_StartStop.BackgroundImage = imglst_startstop.Images[0];
                lbl_StatusValue.ForeColor = Color.Black;
                tlstrptxtbx_Status.ForeColor = Color.Black;
                lbl_StatusValue.Text = "The Daemon is stopped.";
                tlstrptxtbx_Status.Text = "The Daemon is stopped.";
                txtbx_hostValue.Enabled = true;
                tlstrpmnuitm_StartStop.Text = "Start Daemon";
            }
            else
            {
                tmrCheck.Enabled = true;
                btn_StartStop.BackgroundImage = imglst_startstop.Images[1];
                lbl_StatusValue.ForeColor = Color.Black;
                lbl_StatusValue.Text = "Scanning...";
                txtbx_hostValue.Enabled = false;
                tlstrpmnuitm_StartStop.Text = "Stop Daemon";
            }
        }
    }
}
