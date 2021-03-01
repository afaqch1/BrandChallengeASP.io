using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BrandChallenge
{
    [Dependency(ReplaceServices = true)]
    public class BrandChallengeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BrandChallenge";
    }
}
