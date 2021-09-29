using Neco.Abp.ConsulConfiguration.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Neco.Abp.ConsulConfiguration.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ConsulConfigurationPageModel : AbpPageModel
    {
        protected ConsulConfigurationPageModel()
        {
            LocalizationResourceType = typeof(ConsulConfigurationResource);
        }
    }
}