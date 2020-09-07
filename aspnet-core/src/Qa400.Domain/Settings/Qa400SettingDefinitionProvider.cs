using Volo.Abp.Settings;

namespace Qa400.Settings
{
    public class Qa400SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Qa400Settings.MySetting1));
        }
    }
}
