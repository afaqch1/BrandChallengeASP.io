using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BrandChallenge.Data
{
    /* This is used if database provider does't define
     * IBrandChallengeDbSchemaMigrator implementation.
     */
    public class NullBrandChallengeDbSchemaMigrator : IBrandChallengeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}