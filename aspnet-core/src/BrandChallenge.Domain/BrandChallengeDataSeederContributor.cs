using BrandChallenge.Brands;
using BrandChallenge.Challenges;
using BrandChallenge.Tricks;
using BrandChallenge.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace BrandChallenge
{
    public class BrandChallengeDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Brand, Guid> _brandRepository;
        private readonly IRepository<Challenge, Guid> _challengeRepository;
        private readonly IRepository<Trick, Guid> _trickRepository;
       

        public BrandChallengeDataSeederContributor(
            IRepository<Brand, Guid> brandRepository,
            IRepository<Challenge, Guid> challengeRepository,
            IRepository<Trick, Guid> trickRepository
          
            )
        {
            _brandRepository = brandRepository;
            _challengeRepository = challengeRepository;
            _trickRepository = trickRepository;
      
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _brandRepository.GetCountAsync() > 0)
            {
                return;
            }
                var b1=await _brandRepository.InsertAsync(
                    new Brand
                    {
                        Name = "CocaCola",
                        Type = BrandType.Beverages,
                        Description="Open Happiness"
                    },
                    autoSave: true
                );

                var b2=await _brandRepository.InsertAsync(
                    new Brand
                    {
                        Name = "Mcdonalds",
                        Type = BrandType.FoodChain,
                        Description="I am Lovin it"
                    },
                    autoSave: true
                );
            
               var c1= await _challengeRepository.InsertAsync(
                    new Challenge
                    {
                        Name = "Post a Picture",
                        Type = ChallengeType.Picture,
                        BrandId=b1.Id
                        
                    },
                    autoSave: true
                );

               var c2= await _challengeRepository.InsertAsync(
                    new Challenge
                    {
                        Name = "Post a Video",
                        Type = ChallengeType.Video,
                        BrandId=b2.Id
                    },
                    autoSave: true
                );

            var t1 = await _trickRepository.InsertAsync(
                new Trick
                {
                    Name = "Posting a Picture",
                    Type = TrickType.Picture,
                    ChallengeId = c1.Id,

                },
                autoSave: true
            );

            var t2 = await _trickRepository.InsertAsync(
                new Trick
                {
                    Name = "Posting a Video",
                    Type = TrickType.Video,
                    ChallengeId = c2.Id
                },
                autoSave: true
            );


        }
    }
}
