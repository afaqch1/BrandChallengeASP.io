using Volo.Abp.Settings;

namespace BrandChallenge.Settings
{
    public class BrandChallengeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BrandChallengeSettings.MySetting1));
        }
    }
}
