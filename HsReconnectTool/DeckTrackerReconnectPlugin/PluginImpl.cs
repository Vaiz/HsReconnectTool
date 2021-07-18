using HsReconnectTool;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DeckTrackerReconnectPlugin
{
    class PluginImpl : IDisposable
    {
        FloatReconnectButton floatReconnectButton;
        MenuItem menu = new MenuItem();
        readonly string errorMessage = "To enable disconnect feature you need to restart application with admin priviliges.";

        public PluginImpl()
        {
            menu.Header = "Reconnect button";
            if (Util.IsElevated())
            {
                floatReconnectButton = new FloatReconnectButton();
                floatReconnectButton.Show();

                menu.IsCheckable = true;
                menu.IsChecked = true;
                menu.Checked += UpdateReconnectButton;
                menu.Unchecked += UpdateReconnectButton;
            }
            else
            {
                menu.ToolTip = errorMessage;
                menu.Icon = System.Windows.Forms.MessageBoxIcon.Warning;

                System.Windows.Forms.MessageBox.Show(
                    "To enable disconnect feature you need to restart application with admin priviliges.",
                    "ReconnectPlugin",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void UpdateReconnectButton(object sender, RoutedEventArgs e)
        {
            if (floatReconnectButton != null)
                floatReconnectButton.Visible = menu.IsChecked;
        }

        public MenuItem Menu => menu;

        public void Dispose()
        {
            if (floatReconnectButton != null)
                floatReconnectButton.Dispose();
        }
    }
}
