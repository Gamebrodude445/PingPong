namespace PingPong.Common.Sockets.Abstractions
{
    public interface ISender<T>
    {
        public void Send(T toSend);
    }
}
