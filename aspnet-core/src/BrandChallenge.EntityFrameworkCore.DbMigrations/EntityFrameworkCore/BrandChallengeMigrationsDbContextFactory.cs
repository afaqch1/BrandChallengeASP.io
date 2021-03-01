using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BrandChallenge.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BrandChallengeMigrationsDbContextFactory : IDesignTimeDbContextFactory<BrandChallengeMigrationsDbContext>
    {
        public BrandChallengeMigrationsDbContext CreateDbContext(string[] args)
        {
            BrandChallengeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BrandChallengeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BrandChallengeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BrandChallenge.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
