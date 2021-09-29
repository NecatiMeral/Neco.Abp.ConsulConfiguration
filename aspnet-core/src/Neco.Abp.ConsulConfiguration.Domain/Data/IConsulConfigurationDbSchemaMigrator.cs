using System.Threading.Tasks;

namespace Neco.Abp.ConsulConfiguration.Data
{
    public interface IConsulConfigurationDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
