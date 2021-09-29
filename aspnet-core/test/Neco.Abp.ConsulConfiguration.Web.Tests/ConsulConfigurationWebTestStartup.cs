using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Neco.Abp.ConsulConfiguration
{
    public class ConsulConfigurationWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<ConsulConfigurationWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}