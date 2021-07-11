using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker;

namespace DeckTrackerReconnectPlugin
{
    public class ReconnectPlugin : Hearthstone_Deck_Tracker.Plugins.IPlugin
    {
        public ReconnectPlugin()
        {
            menu_item.Items.Add(close_connection_item);
            menu_item.Items.Add(diconnected_item);

            // close_connection_label
            // 
            //this.close_connection_item.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.close_connection_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.close_connection_item.Location = new System.Drawing.Point(0, 0);
            this.close_connection_item.Name = "close_connection_label";
            //this.close_connection_item.Size = new System.Drawing.Size(308, 54);
            this.close_connection_item.TabIndex = 0;
            //this.close_connection_item.Text = "Close connection";
            //this.close_connection_item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_connection_item.Visibility = Visibility.Visible;
            // 
            // disconnected_label
            // 
            //this.diconnected_item.BackColor = System.Drawing.Color.LemonChiffon;
            //this.diconnected_item.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.diconnected_item.Enabled = false;
            //this.diconnected_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.diconnected_item.Location = new System.Drawing.Point(0, 0);
            this.diconnected_item.Name = "disconnected_label";
            //this.diconnected_item.Size = new System.Drawing.Size(308, 54);
            this.diconnected_item.TabIndex = 1;
            //this.diconnected_item.Text = "Disconnected";
            //this.diconnected_item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.diconnected_item.Visible = false;
            this.close_connection_item.Visibility = Visibility.Hidden;            
        }
        public string Name => "ReconnectPlugin";

        public string Description => "This plugin allows you to disconnect during the game.";

        public string ButtonText => "None";

        public string Author => "Vaiz";

        public Version Version => Version.Parse("1.0.0");

        public System.Windows.Controls.MenuItem MenuItem => null;

        public void OnButtonPress()
        {
            MessageBox.Show("OnButtonPress");
        }

        public void OnLoad()
        {
            MessageBox.Show("OnLoad");
        }

        public void OnUnload()
        {
            MessageBox.Show("OnUnload");
        }

        public void OnUpdate()
        {
            //MessageBox.Show("OnUpdate");
        }


        MenuItem menu_item = new MenuItem();
        MenuItem diconnected_item = new MenuItem();
        MenuItem close_connection_item = new MenuItem();

    }
}
