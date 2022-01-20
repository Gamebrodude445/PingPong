using PingPong.Common.Sockets.Abstractions;
using System.Net;
using System.Net.Sockets;

namespace PingPong.Common.Sockets
{
    public class TCPSocketWrapper<T> : ISocketWrapper<T>
    {
        private Socket TCPSocket { get; set; }
        private string _ip { get; set; }
        private uint _port { get; set; }

        public TCPSocketWrapper(string ip, uint port)
        {
            TCPSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            _ip = ip;
            _port = port;
        }

        public TCPSocketWrapper(Socket socket,string ip, uint port) : this (ip, port)
        {
            TCPSocket = socket;
        }
        public void Connect()
        {
            TCPSocket.Connect(_ip, (int)_port);
        }

        public ISocketWrapper<T> Listen()
        {
            IPAddress ip = IPAddress.Parse(_ip);
            var endPoint = new IPEndPoint(ip, (int)_port);
            TCPSocket.Bind(endPoint);
            TCPSocket.Listen();
            var otherSocket = TCPSocket.Accept();
            return new TCPSocketWrapper<T>(otherSocket, _ip, _port);
        }

        public T Receive()
        {
            throw new NotImplementedException();
        }

        public void Send(T toSend)
        {
            throw new NotImplementedException();
        }
    }
}
