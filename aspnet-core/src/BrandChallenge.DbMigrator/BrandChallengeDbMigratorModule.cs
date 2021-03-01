using BrandChallenge.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BrandChallenge.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BrandChallengeEntityFrameworkCoreDbMigrationsModule),
        typeof(BrandChallengeApplicationContractsModule)
        )]
    public class BrandChallengeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
