using BrandChallenge.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BrandChallenge.Brands
{
    public class BrandAppService :
        CrudAppService<
            Brand, //The Brand entity
            BrandDto, //Used to show Brands
            Guid, //Primary key of the Brand entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBrandDto>, //Used to create/update a Brand
        IBrandAppService //implement the IBrandAppService
    {
        public BrandAppService(IRepository<Brand, Guid> repository)
            : base(repository)
        {
            GetPolicyName = BrandChallengePermissions.Brands.Default;
            GetListPolicyName = BrandChallengePermissions.Brands.Default;
            CreatePolicyName = BrandChallengePermissions.Brands.Create;
            UpdatePolicyName = BrandChallengePermissions.Brands.Edit;
            DeletePolicyName = BrandChallengePermissions.Brands.Delete;
        }
    }
}
