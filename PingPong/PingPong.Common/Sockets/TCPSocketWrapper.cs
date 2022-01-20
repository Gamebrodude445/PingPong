using PingPong.Common.Sockets.Abstractions;

namespace PingPong.Common.Sockets
{
    public class TCPSocketWrapper<T> : ISocketWrapper<T>
    {
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
