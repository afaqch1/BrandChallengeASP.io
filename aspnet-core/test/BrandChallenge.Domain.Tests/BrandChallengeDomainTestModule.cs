using BrandChallenge.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BrandChallenge
{
    [DependsOn(
        typeof(BrandChallengeEntityFrameworkCoreTestModule)
        )]
    public class BrandChallengeDomainTestModule : AbpModule
    {

    }
}