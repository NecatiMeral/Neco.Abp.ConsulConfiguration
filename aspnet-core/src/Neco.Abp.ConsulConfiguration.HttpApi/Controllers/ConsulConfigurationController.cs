using Neco.Abp.ConsulConfiguration.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Neco.Abp.ConsulConfiguration.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ConsulConfigurationController : AbpController
    {
        protected ConsulConfigurationController()
        {
            LocalizationResource = typeof(ConsulConfigurationResource);
        }
    }
}