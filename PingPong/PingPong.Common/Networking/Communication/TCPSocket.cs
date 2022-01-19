using PingPong.Common.Networking.Communication.Abstract;

namespace PingPong.Common.Networking.Communication
{
    public class TCPSocket : DualCommunicationBase<string>
    {
        public override string Receive()
        {
            throw new System.NotImplementedException();
        }

        public override bool TrySend(string toSend)
        {
            throw new System.NotImplementedException();
        }
    }
}
