using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilLib
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            disconnectMin.Value = SettingsFile.Default.DisconnectIntervalMin;
            disconnectMax.Value = SettingsFile.Default.DisconnectIntervalMax;
            disconnectButtonPosX.Value = SettingsFile.Default.DisconnectButtonPosX;
            disconnectButtonPosY.Value = SettingsFile.Default.DisconnectButtonPosY;
            disconnectButtonCheckbox.Checked = SettingsFile.Default.EnableDisconnectButton;
            disablePrivilegeWarningCheckbox.Checked = SettingsFile.Default.DisablePrivilegeWarning;

            new ToolTip().SetToolTip(disconnectMin, "Minimal diconnect time in seconds");
            new ToolTip().SetToolTip(disconnectMax, "Maximal diconnect time in seconds");
            new ToolTip().SetToolTip(disconnectIntervalLabel, "if game crashes try to adjust those intervals");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SettingsFile.Default.DisconnectIntervalMin = disconnectMin.Value;
            SettingsFile.Default.DisconnectIntervalMax = disconnectMax.Value;
            SettingsFile.Default.DisconnectButtonPosX = (int)disconnectButtonPosX.Value;
            SettingsFile.Default.DisconnectButtonPosY = (int)disconnectButtonPosY.Value;
            SettingsFile.Default.EnableDisconnectButton = disconnectButtonCheckbox.Checked;
            SettingsFile.Default.DisablePrivilegeWarning = disablePrivilegeWarningCheckbox.Checked;
            SettingsFile.Default.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
