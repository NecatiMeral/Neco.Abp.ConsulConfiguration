using Neco.Abp.ConsulConfiguration.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Neco.Abp.ConsulConfiguration
{
    [DependsOn(
        typeof(ConsulConfigurationEntityFrameworkCoreTestModule)
        )]
    public class ConsulConfigurationDomainTestModule : AbpModule
    {

    }
}