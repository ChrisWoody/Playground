using System.IO;
using Microsoft.Azure.WebJobs;
using Playground.Core.Messages;

namespace Playground.WebJob
{
    public class Functions
    {
        public static void TextToUpperCase([QueueTrigger("testqueue")] TextToUpperCaseMessage message, [Queue("testhandled")] out string response, TextWriter log)
        {
            response = message.Text.ToUpper();
        }
    }
}
