namespace PingPong.Common.Networking.Communication.Abstract
{
    public abstract class SocketBase<T> : IReciever<T>, ISender<T>
    {
        public abstract T Receive();
        public abstract bool TrySend(T toSend);
    }
}
