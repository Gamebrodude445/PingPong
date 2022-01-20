namespace PingPong.Common.Sockets.Abstractions
{
    public interface IReceiver<T>
    {
        public T Receive();
    }
}
