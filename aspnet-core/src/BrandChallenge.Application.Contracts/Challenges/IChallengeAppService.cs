using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BrandChallenge.Challenges
{
    public interface IChallengeAppService :
        ICrudAppService< //Defines CRUD methods
            ChallengeDto, //Used to show challenges
            Guid, //Primary key of the challenge entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateChallengeDto> //Used to create/update a challenge
    {
    }
}
