using System.Threading.Tasks;

namespace PingPong.Common.Networking.Communication.Abstract
{
    public interface IReciever<T>
    {
        public T Receive();
    }
}
