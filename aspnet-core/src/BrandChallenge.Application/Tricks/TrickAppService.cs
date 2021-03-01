using BrandChallenge.Challenges;
using BrandChallenge.Permissions;
using BrandChallenge.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BrandChallenge.Tricks
{
    public class TrickAppService :
        CrudAppService<
            Trick, //The Trick entity
            TrickDto, //Used to show Tricks
            Guid, //Primary key of the Challenge entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTrickDto>, //Used to create/update a Trick
        ITrickAppService //implement the ITrickAppService
    {
        public TrickAppService(IRepository<Trick, Guid> repository)
            : base(repository)
        {
            GetPolicyName = BrandChallengePermissions.Tricks.Default;
            GetListPolicyName = BrandChallengePermissions.Tricks.Default;
            CreatePolicyName = BrandChallengePermissions.Tricks.Create;
            UpdatePolicyName = BrandChallengePermissions.Tricks.Edit;
            DeletePolicyName = BrandChallengePermissions.Tricks.Delete;
        }

        public bool MatchStrings(TrickType type)
        {
            Challenge c = new Challenge();
            if (c.Type.Equals(type))
                return true;
            return false;
        }  
    }
}
