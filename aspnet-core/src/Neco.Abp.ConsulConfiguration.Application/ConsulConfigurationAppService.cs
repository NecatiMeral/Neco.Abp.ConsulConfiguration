using System;
using System.Collections.Generic;
using System.Text;
using Neco.Abp.ConsulConfiguration.Localization;
using Volo.Abp.Application.Services;

namespace Neco.Abp.ConsulConfiguration
{
    /* Inherit your application services from this class.
     */
    public abstract class ConsulConfigurationAppService : ApplicationService
    {
        protected ConsulConfigurationAppService()
        {
            LocalizationResource = typeof(ConsulConfigurationResource);
        }
    }
}
