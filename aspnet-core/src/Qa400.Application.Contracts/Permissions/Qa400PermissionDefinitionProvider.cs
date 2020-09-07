using Qa400.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa400.Permissions
{
    public class Qa400PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Qa400Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(Qa400Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Qa400Resource>(name);
        }
    }
}
