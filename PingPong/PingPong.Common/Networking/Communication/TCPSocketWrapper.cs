using PingPong.Common.Networking.Communication.Abstract;
using System.Net.Sockets;

namespace PingPong.Common.Networking.Communication
{
    public class TCPSocketWrapper : DualCommunicationBase<string>
    {
        private string _ip { get; init; }
        private int _port { get; init; }

        public TCPSocketWrapper(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public override string Receive()
        {
            return default;
        }

        public override bool TrySend(string toSend)
        {
            return default;
        }
    }
}
