using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HsReconnectTool
{
    class Util
    {
        static public bool IsRemoteConnection(iphlpapi.MIB_TCPROW_OWNER_PID connection)
        {
            if (IPAddress.IsLoopback(connection.LocalAddress) || IPAddress.IsLoopback(connection.RemoteAddress))
                return false;
            if (connection.dwLocalAddr == 0 || connection.dwRemoteAddr == 0)
                return false;

            return true;
        }
    }
}
