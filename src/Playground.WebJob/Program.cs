using Microsoft.Azure.WebJobs;

namespace Playground.WebJob
{
    public class Program
    {
        public static void Main()
        {
            var config = new JobHostConfiguration();

            if (config.IsDevelopment)
                config.UseDevelopmentSettings();

            var host = new JobHost(config);
            host.RunAndBlock();
        }
    }
}
