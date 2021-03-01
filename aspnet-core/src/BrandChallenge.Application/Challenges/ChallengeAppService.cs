using BrandChallenge.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BrandChallenge.Challenges
{
    public class ChallengeAppService :
        CrudAppService<
            Challenge, //The Challenge entity
            ChallengeDto, //Used to show Challenges
            Guid, //Primary key of the Challenge entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateChallengeDto>, //Used to create/update a Challenge
        IChallengeAppService //implement the IChallengeAppService
    {
        public ChallengeAppService(IRepository<Challenge, Guid> repository)
            : base(repository)
        {
            GetPolicyName = BrandChallengePermissions.Challenges.Default;
            GetListPolicyName = BrandChallengePermissions.Challenges.Default;
            CreatePolicyName = BrandChallengePermissions.Challenges.Create;
            UpdatePolicyName = BrandChallengePermissions.Challenges.Edit;
            DeletePolicyName = BrandChallengePermissions.Challenges.Delete;

        }
    }
}
