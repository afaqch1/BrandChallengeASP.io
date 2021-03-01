using BrandChallenge.Brands;
using BrandChallenge.Challenges;
using BrandChallenge.Tricks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace BrandChallenge.EntityFrameworkCore
{
    public static class BrandChallengeDbContextModelCreatingExtensions
    {
        public static void ConfigureBrandChallenge(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BrandChallengeConsts.DbTablePrefix + "YourEntities", BrandChallengeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Brand>(b =>
            {
                b.ToTable(BrandChallengeConsts.DbTablePrefix + "Brands",
                          BrandChallengeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
               
            });

            builder.Entity<Challenge>(b =>
            {
                b.ToTable(BrandChallengeConsts.DbTablePrefix + "Challenges",
                          BrandChallengeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.HasOne<Brand>().WithMany().HasForeignKey(x => x.BrandId).IsRequired();
            });

            builder.Entity<Trick>(b =>
            {
                b.ToTable(BrandChallengeConsts.DbTablePrefix + "Tricks",
                          BrandChallengeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.HasOne<Challenge>().WithMany().HasForeignKey(x => x.ChallengeId).IsRequired();
            });
        }
    }
}