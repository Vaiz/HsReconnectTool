using System;
using System.Drawing;
using System.Windows.Forms;
using UtilLib;

namespace HsReconnectTool
{
    public partial class MainWindow : Form
    {
        FloatReconnectButton floatReconnectButton;

        public MainWindow()
        {
            InitializeComponent();
            floatReconnectButton = new FloatReconnectButton();
            floatReconnectButton.Visible = float_button_checkBox.Checked;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateHsInfo();
        }

        private void UpdateHsInfo()
        {
            UpdateHsStatus();
        }

        private void UpdateHsStatus()
        {
            var hs = HsHelper.Instance.UpdateHsState();

            if (hs.IsRunning)
            {
                hs_exe_status_label.Text = String.Format("Running ({0})", hs.ProcessCount);
                hs_exe_status_label.ForeColor = Color.Green;
                connection_count_value_label.Text = hs.ConnectionCount.ToString();
            }
            else
            {
                hs_exe_status_label.Text = "Not running";
                hs_exe_status_label.ForeColor = Color.Salmon;
                connection_count_value_label.Text = "-";
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateHsInfo();
        }

        private void close_connsection_button_Click(object sender, EventArgs e)
        {
            HsHelper.Instance.CloseConnectionsToServer();
            UpdateHsInfo();
        }

        private void github_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Vaiz/HsReconnectTool");
        }

        private void float_reconnect_button_CheckedChanged(object sender, EventArgs e)
        {
            floatReconnectButton.Visible = float_button_checkBox.Checked;
        }
    }
}
