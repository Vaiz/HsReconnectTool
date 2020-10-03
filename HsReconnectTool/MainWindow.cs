using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HsReconnectTool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*
        private T[] ConcatArrays<T>(T[] array1, T[] array2)
        {
            T[] newArray = new T[array1.Length + array2.Length];
            Array.Copy(array1, newArray, array1.Length);
            Array.Copy(array2, 0, newArray, array1.Length, array2.Length);
            return newArray;
        }
        */
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
            var hs = HsHelper.GetHsState();

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
            HsHelper.CloseConnectionsToServer();
            UpdateHsInfo();
        }

        private void github_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Vaiz/HsReconnectTool");
        }
    }
}
