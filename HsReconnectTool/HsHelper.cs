using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HsReconnectTool
{
    class HsHelper
    {
        static Process[] GetHsProcesses()
        {
            return Process.GetProcessesByName(Constants.HsProcessName);
        }
        static List<iphlpapi.MIB_TCPROW_OWNER_PID> GetHsConnections(Process[] processes)
        {
            var pids = new HashSet<uint>();
            foreach (var p in processes)
                pids.Add((uint)p.Id);

            List<iphlpapi.MIB_TCPROW_OWNER_PID> connections = iphlpapi.GetAllTCPConnections();
            connections = connections.Where(c => pids.Contains(c.ProcessId)).ToList();

            foreach (var c in connections)
            {
                Console.WriteLine(c.ToString());
            }

            return connections;
        }

        public static HsState GetHsState()
        {
            Process[] processes = GetHsProcesses();
            List<iphlpapi.MIB_TCPROW_OWNER_PID> connections = GetHsConnections(processes);
            return new HsState(processes, connections);
        }
        public static void CloseConnectionsToServer()
        {
            HsState state = GetHsState();
            foreach(var c in state.Connections)
            {
                if (IPAddress.IsLoopback(c.LocalAddress) || IPAddress.IsLoopback(c.RemoteAddress))
                    continue;
                if (c.dwLocalAddr == 0 || c.dwRemoteAddr == 0)
                    continue;


                Console.WriteLine("Closing connection. {0}", c);
                String error = iphlpapi.CloseRemoteIP(c.ToTcpRow());
                if (null != error)
                    MessageBox.Show(String.Format("Cannot close connection {0}\r\nError: {1}", c, error));
            }
        }

    }
}
