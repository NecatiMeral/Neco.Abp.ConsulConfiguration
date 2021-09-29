using Volo.Abp.Settings;

namespace Neco.Abp.ConsulConfiguration.Settings
{
    public class ConsulConfigurationSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ConsulConfigurationSettings.MySetting1));
        }
    }
}
