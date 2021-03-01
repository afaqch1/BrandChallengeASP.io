using Volo.Abp.Modularity;

namespace BrandChallenge
{
    [DependsOn(
        typeof(BrandChallengeApplicationModule),
        typeof(BrandChallengeDomainTestModule)
        )]
    public class BrandChallengeApplicationTestModule : AbpModule
    {

    }
}