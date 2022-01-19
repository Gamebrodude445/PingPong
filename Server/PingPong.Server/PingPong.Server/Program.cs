using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace PingPong.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(
                Dns.GetHostEntry(Dns.GetHostName()).AddressList[0],
                1025));
            while (true) { 
                socket.Listen();
                Thread newThread = new Thread(() =>
                    {
                        var socket1 = socket;
                        var newSocket = socket1.Accept();
                        var bytes = new Byte[1024];
                        int numByte = newSocket.Receive(bytes);
                        string data = null;
                        data += Encoding.ASCII.GetString(bytes, 0, numByte);
                        newSocket.Send(Encoding.ASCII.GetBytes(data));
                    }
                );
                newThread.Start();
            }
        }
    }
}
