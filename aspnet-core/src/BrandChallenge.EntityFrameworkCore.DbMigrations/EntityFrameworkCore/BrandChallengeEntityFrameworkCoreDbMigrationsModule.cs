using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace BrandChallenge.EntityFrameworkCore
{
    [DependsOn(
        typeof(BrandChallengeEntityFrameworkCoreModule)
        )]
    public class BrandChallengeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BrandChallengeMigrationsDbContext>();
        }
    }
}
