using System.Threading.Tasks;

namespace BrandChallenge.Data
{
    public interface IBrandChallengeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
