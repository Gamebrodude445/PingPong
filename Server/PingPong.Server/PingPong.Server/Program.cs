using System;
using System.Net.Sockets;
using System.Threading;

namespace PingPong.Server
{
    class Program
    {
        public static void Main(string[] args)
        {
            var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Listen();
            Thread newThread = new Thread(() =>
                {
                    var socket1 = socket;
                    var newSocket = socket1.Accept();
                }
            );
        }
    }
}
