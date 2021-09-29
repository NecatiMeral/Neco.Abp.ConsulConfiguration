using Neco.Abp.ConsulConfiguration.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Neco.Abp.ConsulConfiguration.Permissions
{
    public class ConsulConfigurationPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ConsulConfigurationPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(ConsulConfigurationPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ConsulConfigurationResource>(name);
        }
    }
}
