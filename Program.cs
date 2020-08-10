using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace reactCrud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); //to build web host with pre-configured defaults
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//The WebHost is a static class which can be used for creating an instance 
//of IWebHost and IWebHostBuilder with pre-configured defaults. 

//The CreateDefaultBuilder() method creates a new instance of WebHostBuilder 
//with pre-configured defaults.

//Internally, it configures Kestrel, IISIntegration and other configurations.

//Kestrel is an open-source, cross-platform web server for ASP.NET Core. 
//It is designed to be used behind proxy because it has not yet matured to be exposed as 
//a full-fledge web server.