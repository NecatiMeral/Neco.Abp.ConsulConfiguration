using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Neco.Abp.ConsulConfiguration.Data;
using Volo.Abp.DependencyInjection;

namespace Neco.Abp.ConsulConfiguration.EntityFrameworkCore
{
    public class EntityFrameworkCoreConsulConfigurationDbSchemaMigrator
        : IConsulConfigurationDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreConsulConfigurationDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ConsulConfigurationDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ConsulConfigurationDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
