namespace PingPong.Common.Networking.Communication.Abstract
{
    public interface ISender<T>
    {
        public bool TrySend(T toSend);
    }
}
