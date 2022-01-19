namespace PingPong.Common.Networking.Communication.Abstract
{
    public abstract class DualCommunicationBase<T> : IReciever<T>, ISender<T>
    {
        public abstract T Receive();
        public abstract bool TrySend(T toSend);
    }
}
