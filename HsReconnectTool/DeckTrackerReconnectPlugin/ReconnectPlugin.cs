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
        FloatReconnectButton floatReconnectButton = new FloatReconnectButton();
        public ReconnectPlugin()
        {
        }
        public string Name => "ReconnectPlugin";

        public string Description => "This plugin allows you to disconnect during the game.";

        public string ButtonText => "None";

        public string Author => "Vaiz";

        public Version Version => Version.Parse("1.0.0");

        public System.Windows.Controls.MenuItem MenuItem => null;

        public void OnButtonPress() {}

        public void OnLoad()
        {
            floatReconnectButton.Show();
            MessageBox.Show("OnLoad 1");
        }

        public void OnUnload()
        {
            MessageBox.Show("OnUnload 1");
        }

        public void OnUpdate()
        {
            //MessageBox.Show("OnUpdate");
        }


    }
}
