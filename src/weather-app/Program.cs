using System;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Steeltoe.Discovery.Client;

//using Microsoft.Azure.SpringCloud.Client;
using Steeltoe.Extensions.Configuration.ConfigServer;
using Steeltoe.Management.Endpoint;

namespace Microsoft.Azure.SpringCloud.Sample.WeatherApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
          .ConfigureWebHostDefaults(webBuilder =>
          {
              webBuilder.UseStartup<Startup>();
          })
          .AddHealthActuator()
          //.AddConfigServer()
          .AddDiscoveryClient()
          //.UseAzureSpringCloudService()
          ;
  }
}
