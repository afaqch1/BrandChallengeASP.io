using AutoMapper;
using BrandChallenge.Brands;
using BrandChallenge.Challenges;
using BrandChallenge.Tricks;
using BrandChallenge.Users;
using Volo.Abp.AutoMapper;

namespace BrandChallenge
{
    public class BrandChallengeApplicationAutoMapperProfile : Profile
    {
        public BrandChallengeApplicationAutoMapperProfile()
        {
            CreateMap<Brand, BrandDto>();
            CreateMap<CreateUpdateBrandDto, Brand>();
            
            CreateMap<Challenge, ChallengeDto>();
            CreateMap<CreateUpdateChallengeDto, Challenge>();

            CreateMap<Trick, TrickDto>();
            CreateMap<CreateUpdateTrickDto, Trick>();
            CreateMap<AppUser, AppUserDto>().Ignore(x => x.ExtraProperties);

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}
