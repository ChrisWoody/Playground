using System.Threading.Tasks;

namespace Playground.Core
{
    public interface IStorageProvider
    {
        Task PushMessageToQueue(object message);
    }
}