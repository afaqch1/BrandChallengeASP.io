using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BrandChallenge.Data;
using Volo.Abp.DependencyInjection;

namespace BrandChallenge.EntityFrameworkCore
{
    public class EntityFrameworkCoreBrandChallengeDbSchemaMigrator
        : IBrandChallengeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBrandChallengeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BrandChallengeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BrandChallengeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}