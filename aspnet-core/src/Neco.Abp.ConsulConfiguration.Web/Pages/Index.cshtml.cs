using Microsoft.Extensions.Configuration;

namespace Neco.Abp.ConsulConfiguration.Web.Pages
{
    public class IndexModel : ConsulConfigurationPageModel
    {
        protected IConfiguration Configuration { get; }

        public string Main { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            Configuration = configuration;

            Main = Configuration["Main"];
        }

        public void OnGet()
        {
            
        }
    }
}