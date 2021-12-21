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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(disconnectMin, "Minimal diconnect time in seconds");
            new ToolTip().SetToolTip(disconnectMax, "Maximum diconnect time in seconds");
            new ToolTip().SetToolTip(reconnectIntervalLabel, "if game crashes try to adjust those intervals");
        }
    }
}
