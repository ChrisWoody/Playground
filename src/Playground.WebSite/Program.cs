using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Playground.Core;

namespace Playground.WebSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildConfig();

            BuildWebHost(args).Run();
        }

        private static void BuildConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();
            Settings.StorageAccountKey = config["StorageAccountKey"];
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
