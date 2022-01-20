namespace PingPong.Common.Sockets.Abstractions
{
    public interface ISocketWrapper<T> : ISender<T>, IReceiver<T>
    {
        public void Connect();
        public ISocketWrapper<T> Listen();
    }
}
