﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UtilLib
{
    public class HsState
    {
        Process[] processes;
        List<iphlpapi.MIB_TCPROW_OWNER_PID> connections;

        public HsState(Process[] _processes, List<iphlpapi.MIB_TCPROW_OWNER_PID> _connections)
        {
            processes = _processes;
            connections = _connections;
        }

        public bool IsRunning
        {
            get
            {
                return processes.Length > 0;
            }
        }
        public int ProcessCount
        {
            get
            {
                return processes.Length;
            }
        }
        public int ConnectionCount
        {
            get
            {
                return connections.Count;
            }
        }
        public bool IsConnectedToServer
        {
            get
            {
                return RemoteConnectionCount > 0;
            }
        }
        int RemoteConnectionCount
        {
            get
            {
                return connections.Count(c => Util.IsRemoteConnection(c));
            }
        }
        public List<iphlpapi.MIB_TCPROW_OWNER_PID> Connections
        {
            get
            {
                return connections;
            }
        }
        public string BinaryPath
        {
            get
            {
                return processes.First().MainModule.FileName;
            }
        }
    }
}
