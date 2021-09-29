using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Neco.Abp.ConsulConfiguration.Web
{
    [Dependency(ReplaceServices = true)]
    public class ConsulConfigurationBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ConsulConfiguration";
    }
}
