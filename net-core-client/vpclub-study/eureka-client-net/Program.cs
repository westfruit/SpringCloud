
using System;
using Pivotal.Discovery.Client;
namespace vpclub.study
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new IWebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .UseUrls("http://*:8010")
                .Build();

            host.Run();
        }
    }
}