using Microsoft.WindowsAzure.Storage;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;

namespace Playground.Core
{
    public class StorageProvider : IStorageProvider
    {
        public async Task PushMessageToQueue(object message)
        {
            var client = CloudStorageAccount.Parse(Settings.StorageAccountKey);
            var queueClient = client.CreateCloudQueueClient();
            var queue = queueClient.GetQueueReference("testqueue");
            await queue.CreateIfNotExistsAsync();

            await queue.AddMessageAsync(new CloudQueueMessage(JsonConvert.SerializeObject(message)));
        }
    }
}