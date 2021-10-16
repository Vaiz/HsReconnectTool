using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Net;
using System.Linq;

// http://pinvoke.net/default.aspx/iphlpapi/GetExtendedTcpTable.html

namespace UtilLib
{
    public class iphlpapi
    {
        public enum TCP_TABLE_CLASS
        {
            TCP_TABLE_BASIC_LISTENER,
            TCP_TABLE_BASIC_CONNECTIONS,
            TCP_TABLE_BASIC_ALL,
            TCP_TABLE_OWNER_PID_LISTENER,
            TCP_TABLE_OWNER_PID_CONNECTIONS,
            TCP_TABLE_OWNER_PID_ALL,
            TCP_TABLE_OWNER_MODULE_LISTENER,
            TCP_TABLE_OWNER_MODULE_CONNECTIONS,
            TCP_TABLE_OWNER_MODULE_ALL
        }
        public enum MIB_TCP_STATE
        {
            MIB_TCP_STATE_CLOSED = 1,
            MIB_TCP_STATE_LISTEN = 2,
            MIB_TCP_STATE_SYN_SENT = 3,
            MIB_TCP_STATE_SYN_RCVD = 4,
            MIB_TCP_STATE_ESTAB = 5,
            MIB_TCP_STATE_FIN_WAIT1 = 6,
            MIB_TCP_STATE_FIN_WAIT2 = 7,
            MIB_TCP_STATE_CLOSE_WAIT = 8,
            MIB_TCP_STATE_CLOSING = 9,
            MIB_TCP_STATE_LAST_ACK = 10,
            MIB_TCP_STATE_TIME_WAIT = 11,
            MIB_TCP_STATE_DELETE_TCB = 12
        }
        public enum SetTcpEntryErrors
        {
            ERROR_SUCCESS = 0,
            ERROR_ACCESS_DENIED = 5,
            ERROR_NOT_SUPPORTED = 50,
            ERROR_INVALID_PARAMETER = 87,
            ERROR_APPLICATION_NOT_ELEVATED = 317,
        }



        public const int AF_INET = 2;    // IP_v4 = System.Net.Sockets.AddressFamily.InterNetwork
        public const int AF_INET6 = 23;  // IP_v6 = System.Net.Sockets.AddressFamily.InterNetworkV6


        [StructLayout(LayoutKind.Sequential)]
        public struct MIB_TCPROW
        {
            public uint dwState;
            public uint dwLocalAddr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] dwLocalPort;
            public uint dwRemoteAddr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] dwRemotePort;
        }

        public struct MIB_TCPROW_OWNER_PID
        {
            public uint dwState;
            public uint dwLocalAddr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] dwLocalPort;
            public uint dwRemoteAddr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] dwRemotePort;
            public uint dwOwningPid;

            public uint ProcessId
            {
                get { return dwOwningPid; }
            }

            public IPAddress LocalAddress
            {
                get { return new IPAddress(dwLocalAddr); }
            }

            public ushort LocalPort
            {
                get
                {
                    return BitConverter.ToUInt16(new byte[2] { dwLocalPort[1], dwLocalPort[0] }, 0);
                }
            }

            public IPAddress RemoteAddress
            {
                get { return new IPAddress(dwRemoteAddr); }
            }

            public ushort RemotePort
            {
                get
                {
                    return BitConverter.ToUInt16(new byte[2] { dwRemotePort[1], dwRemotePort[0] }, 0);
                }
            }

            public MIB_TCP_STATE State
            {
                get { return (MIB_TCP_STATE)dwState; }
            }

            public MIB_TCPROW ToTcpRow()
            {
                var row = new MIB_TCPROW();
                row.dwState = dwState;
                row.dwLocalAddr = dwLocalAddr;
                row.dwLocalPort = dwLocalPort;
                row.dwRemoteAddr = dwRemoteAddr;
                row.dwRemotePort = dwRemotePort;
                return row;
            }
            public override String ToString()
            {
                return String.Format("PID {0}, State: {1}, {2}:{3} <-> {4}:{5}",
                    dwOwningPid, dwState, LocalAddress, LocalPort, RemoteAddress, RemotePort);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MIB_TCPTABLE_OWNER_PID
        {
            public uint dwNumEntries;
            [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 1)]
            public MIB_TCPROW_OWNER_PID[] table;
        }



        [DllImport("iphlpapi.dll", SetLastError = true)]
        static extern uint GetExtendedTcpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, TCP_TABLE_CLASS tblClass, uint reserved = 0);

        public static List<MIB_TCPROW_OWNER_PID> GetAllTCPConnections()
        {
            return GetTCPConnections<MIB_TCPROW_OWNER_PID, MIB_TCPTABLE_OWNER_PID>(AF_INET);
        }
        private static List<IPR> GetTCPConnections<IPR, IPT>(int ipVersion)//IPR = Row Type, IPT = Table Type
        {
            IPR[] tableRows;
            int buffSize = 0;

            var dwNumEntriesField = typeof(IPT).GetField("dwNumEntries");

            // how much memory do we need?
            uint ret = GetExtendedTcpTable(IntPtr.Zero, ref buffSize, true, ipVersion, TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL);
            IntPtr tcpTablePtr = Marshal.AllocHGlobal(buffSize);

            try
            {
                ret = GetExtendedTcpTable(tcpTablePtr, ref buffSize, true, ipVersion, TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL);
                if (ret != 0)
                    return new List<IPR>();

                // get the number of entries in the table
                IPT table = (IPT)Marshal.PtrToStructure(tcpTablePtr, typeof(IPT));
                int rowStructSize = Marshal.SizeOf(typeof(IPR));
                uint numEntries = (uint)dwNumEntriesField.GetValue(table);

                // buffer we will be returning
                tableRows = new IPR[numEntries];

                IntPtr rowPtr = (IntPtr)((long)tcpTablePtr + 4);
                for (int i = 0; i < numEntries; i++)
                {
                    IPR tcpRow = (IPR)Marshal.PtrToStructure(rowPtr, typeof(IPR));
                    tableRows[i] = tcpRow;
                    rowPtr = (IntPtr)((long)rowPtr + rowStructSize);   // next entry
                }
            }
            finally
            {
                // Free the Memory
                Marshal.FreeHGlobal(tcpTablePtr);
            }
            return tableRows != null ? tableRows.ToList() : new List<IPR>();
        }



        [DllImport("iphlpapi.dll", SetLastError = true)]
        static extern int SetTcpEntry(IntPtr pTcprow);

        public static String CloseRemoteIP(MIB_TCPROW tcpRow) // return error string or Null
        {
            tcpRow.dwState = (uint)MIB_TCP_STATE.MIB_TCP_STATE_DELETE_TCB;

            IntPtr ptr = Marshal.AllocHGlobal(System.Runtime.InteropServices.Marshal.SizeOf(typeof(MIB_TCPROW)));
            Marshal.StructureToPtr(tcpRow, ptr, false);
            var ret = (SetTcpEntryErrors)SetTcpEntry(ptr);

            switch (ret)
            {
                case SetTcpEntryErrors.ERROR_SUCCESS:
                    return null;
                case SetTcpEntryErrors.ERROR_ACCESS_DENIED:
                    return "Access denied";
                case SetTcpEntryErrors.ERROR_NOT_SUPPORTED:
                    return "Not supported";
                case SetTcpEntryErrors.ERROR_INVALID_PARAMETER:
                    return "Invalid parameter";
                case SetTcpEntryErrors.ERROR_APPLICATION_NOT_ELEVATED:
                    return "Application not elevated";
                default:
                    return String.Format("Unknown error {0}", ret);
            }
        }
    }
}
