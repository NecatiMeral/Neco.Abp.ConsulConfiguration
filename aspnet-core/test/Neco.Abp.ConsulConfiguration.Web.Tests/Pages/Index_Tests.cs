using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Neco.Abp.ConsulConfiguration.Pages
{
    public class Index_Tests : ConsulConfigurationWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
