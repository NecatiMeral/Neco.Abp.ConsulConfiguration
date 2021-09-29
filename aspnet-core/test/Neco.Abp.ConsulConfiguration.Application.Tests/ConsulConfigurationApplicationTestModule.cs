using Volo.Abp.Modularity;

namespace Neco.Abp.ConsulConfiguration
{
    [DependsOn(
        typeof(ConsulConfigurationApplicationModule),
        typeof(ConsulConfigurationDomainTestModule)
        )]
    public class ConsulConfigurationApplicationTestModule : AbpModule
    {

    }
}