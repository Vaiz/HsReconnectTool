using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilLib
{
    public class HsHelper
    {
        private static readonly HsHelper singletonInst = new HsHelper();
        Firewall firewall;

        public static HsHelper Instance
        {
            get
            {
                return singletonInst;
            }
        }
        static Process[] ListHsProcesses()
        {
            return Process.GetProcessesByName(Constants.HsProcessName);
        }
        static List<iphlpapi.MIB_TCPROW_OWNER_PID> ListHsConnections(Process[] processes)
        {
            var pids = new HashSet<uint>();
            foreach (var p in processes)
                pids.Add((uint)p.Id);

            List<iphlpapi.MIB_TCPROW_OWNER_PID> connections = iphlpapi.GetAllTCPConnections();
            connections = connections.Where(c => pids.Contains(c.ProcessId)).ToList();

            /*
            foreach (var c in connections)
            {
                Console.WriteLine(c.ToString());
            }
            */

            return connections;
        }

        public HsState UpdateHsState()
        {
            Process[] processes = ListHsProcesses();
            List<iphlpapi.MIB_TCPROW_OWNER_PID> connections = ListHsConnections(processes);
            var state = new HsState(processes, connections);

            if (state.IsRunning && firewall == null)
            {
                firewall = Firewall.TryCreate(state.BinaryPath);
            }

            return state;
        }

        void DisconnectViaFirewall()
        {
            firewall.EnableRule();
            System.Threading.Thread.Sleep(4000);
            firewall.DisableRule();
        }
        void DisconnectViaTcpMessage(HsState state)
        {
            foreach (var c in state.Connections)
            {
                if (!Util.IsRemoteConnection(c))
                    continue;

                Console.WriteLine("Closing connection. {0}", c);
                String error = iphlpapi.CloseRemoteIP(c.ToTcpRow());
                if (null != error)
                    MessageBox.Show(String.Format("Cannot close connection {0}\r\nError: {1}", c, error));
            }
        }
        public void CloseConnectionsToServer()
        {
            HsState state = UpdateHsState();
            Console.WriteLine("Closing connections... HS running: {0}", state.IsRunning);

            if (firewall != null)
            {
                Task.Factory.StartNew(DisconnectViaFirewall);
            }
            else
            {
                DisconnectViaTcpMessage(state);
            }
        }

    }
}
