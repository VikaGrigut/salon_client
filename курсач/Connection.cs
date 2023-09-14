using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    static class Connection
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static void Connect()
        {
            socket.ConnectAsync("192.168.144.228", 8888);
        }
        public static Socket GetSocket()
        {
            return socket;
        } 
        
    }
}
