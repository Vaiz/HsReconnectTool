﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HsReconnectTool
{
    public partial class FloatReconnectButton : Form
    {
        bool dragModeActive = false;
        Point dragStartPoint;
        System.Windows.Forms.Timer updateTimer = new Timer();

        public FloatReconnectButton()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Visible = false;
            this.ShowInTaskbar = false;

            close_connection_label.MouseDown += new MouseEventHandler(Disconnect);
            close_connection_label.MouseDown += new MouseEventHandler(OnMouseDown);
            close_connection_label.MouseUp += new MouseEventHandler(OnMouseUp);
            close_connection_label.MouseMove += new MouseEventHandler(ProcessMouseMove);

            disconnected_label.MouseDown += new MouseEventHandler(OnMouseDown);
            disconnected_label.MouseUp += new MouseEventHandler(OnMouseUp);
            disconnected_label.MouseMove += new MouseEventHandler(ProcessMouseMove);

            string toolTipString = "Click to reconnect\r\nHold right button to move this";
            new ToolTip().SetToolTip(close_connection_label, toolTipString);
            new ToolTip().SetToolTip(disconnected_label, toolTipString);

            updateTimer.Interval = 1000;
            updateTimer.Tick += new EventHandler(UpdateButtonOnTimer);
        }

        protected override CreateParams CreateParams
        {
            // remove window from task view
            get
            {
                const int WS_EX_TOOLWINDOW = 0x80;

                var Params = base.CreateParams;
                Params.ExStyle |= WS_EX_TOOLWINDOW;
                return Params;
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Disconnect(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                HsHelper.CloseConnectionsToServer();
                updateTimer.Stop();
                UpdateButtonState(true);
                updateTimer.Start();
            }
        }


        void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dragStartPoint = e.Location;
                this.dragModeActive = true;
            }
        }
        void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.dragModeActive = false;
        }

        void ProcessMouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragModeActive)
            {
                Point p = this.PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(
                    p.X - this.dragStartPoint.X,
                    p.Y - this.dragStartPoint.Y);
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (value)
            {
                UpdateButtonState(HsHelper.GetHsState().RemoteConnectionCount == 0);
                updateTimer.Start();
            }
            else
            {
                updateTimer.Stop();
            }
            base.SetVisibleCore(value);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            updateTimer.Stop();
            base.OnClosing(e);
        }

        void UpdateButtonOnTimer(object sender, EventArgs e)
        {
            UpdateButtonState(HsHelper.GetHsState().RemoteConnectionCount == 0);
        }
        void UpdateButtonState(bool disconnected)
        {
            if (disconnected)
            {
                close_connection_label.Enabled = false;
                close_connection_label.Visible = false;
                disconnected_label.Enabled = true;
                disconnected_label.Visible = true;
            }
            else
            {
                close_connection_label.Enabled = true;
                close_connection_label.Visible = true;
                disconnected_label.Enabled = false;
                disconnected_label.Visible = false;
            }
        }
    }
}
