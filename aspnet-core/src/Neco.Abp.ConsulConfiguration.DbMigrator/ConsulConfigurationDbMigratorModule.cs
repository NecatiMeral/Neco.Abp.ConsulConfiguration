using Neco.Abp.ConsulConfiguration.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Neco.Abp.ConsulConfiguration.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ConsulConfigurationEntityFrameworkCoreModule),
        typeof(ConsulConfigurationApplicationContractsModule)
        )]
    public class ConsulConfigurationDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
