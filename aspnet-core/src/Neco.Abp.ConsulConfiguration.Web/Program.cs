using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Winton.Extensions.Configuration.Consul;

namespace Neco.Abp.ConsulConfiguration.Web
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.Async(c => c.File("Logs/logs.txt"))
#if DEBUG
                .WriteTo.Async(c => c.Console())
#endif
                .CreateLogger();

            try
            {
                Log.Information("Starting web host.");
                CreateHostBuilder(args).Build().Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(build =>
                {
                    build.AddJsonFile("appsettings.secrets.json", optional: true);

                    var configuration = build.Build();
                    build.AddConsul("MyKey", options => ConfigureConsulConfiguration(configuration, options));
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseAutofac()
                .UseSerilog();

        private static void ConfigureConsulConfiguration(IConfigurationRoot configuration, IConsulConfigurationSource options)
        {
            options.Optional = true;
            options.PollWaitTime = TimeSpan.FromSeconds(5);
            options.ReloadOnChange = true;

            options.ConsulHttpClientOptions = clientOptions =>
            {
                var consulConfigurationAddress = configuration["RemoteConfiguration:Consul:Endpoint"];
                if (consulConfigurationAddress != null)
                {
                    clientOptions.BaseAddress = new Uri(consulConfigurationAddress);
                }
            };

            options.OnLoadException = (onLoadExceptionContext) =>
            {
                Console.WriteLine(onLoadExceptionContext.Exception);
            };

            options.OnWatchException = (onWatchExceptionContext) =>
            {
                Console.WriteLine(onWatchExceptionContext.Exception);

                return TimeSpan.FromSeconds(5);
            };
        }
    }
}
