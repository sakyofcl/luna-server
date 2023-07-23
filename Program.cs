namespace LunaServer;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        StartLunaWebServer();
    }

    public static void StartLunaWebServer(){
        var builder = new WebHostBuilder();

        builder.UseKestrel();
        builder.UseStartup<Startup>();
        builder.UseContentRoot(Directory.GetCurrentDirectory());
        builder.ConfigureAppConfiguration((builder, config)=>{
            config.AddJsonFile("config.json",false);//Common configuration
            config.AddJsonFile($"config.{builder.HostingEnvironment.EnvironmentName}.json", true); // Environment specific configuration
        });

        var server = builder.Build();
        
        server.Run();
    }

}
