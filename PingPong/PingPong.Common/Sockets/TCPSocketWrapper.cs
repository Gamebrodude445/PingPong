using PingPong.Common.Sockets.Abstractions;
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
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Listen()
        {
            throw new NotImplementedException();
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
