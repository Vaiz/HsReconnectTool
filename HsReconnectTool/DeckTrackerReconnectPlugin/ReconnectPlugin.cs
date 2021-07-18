using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker;
using HsReconnectTool;

namespace DeckTrackerReconnectPlugin
{
    public class ReconnectPlugin : Hearthstone_Deck_Tracker.Plugins.IPlugin
    {
        FloatReconnectButton floatReconnectButton;
        MenuItem menu;

        public ReconnectPlugin()
        {
            menu = new MenuItem();
            menu.Header = "Reconnect button";
            menu.IsCheckable = true;
            menu.IsChecked = true;
            menu.Checked += UpdateReconnectButton;
            menu.Unchecked += UpdateReconnectButton;
        }

        private void UpdateReconnectButton(object sender, RoutedEventArgs e)
        {
            floatReconnectButton.Visible = menu.IsChecked;
        }

        public string Name => "ReconnectPlugin";

        public string Description => "This plugin allows you to disconnect during the game.";

        public string ButtonText => "None";

        public string Author => "Vaiz";

        public Version Version => Version.Parse("1.0.0");

        public MenuItem MenuItem => menu;

        public void OnButtonPress() { }

        public void OnLoad()
        {
            floatReconnectButton = new FloatReconnectButton();
            floatReconnectButton.Show();
        }

        public void OnUnload()
        {
            floatReconnectButton.Dispose();
            floatReconnectButton = null;
        }

        public void OnUpdate()
        {
        }


    }
}
