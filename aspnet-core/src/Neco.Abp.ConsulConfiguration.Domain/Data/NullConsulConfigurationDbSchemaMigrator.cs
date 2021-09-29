using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Neco.Abp.ConsulConfiguration.Data
{
    /* This is used if database provider does't define
     * IConsulConfigurationDbSchemaMigrator implementation.
     */
    public class NullConsulConfigurationDbSchemaMigrator : IConsulConfigurationDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}