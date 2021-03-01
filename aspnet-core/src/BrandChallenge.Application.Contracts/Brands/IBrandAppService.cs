using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BrandChallenge.Brands
{
    public interface IBrandAppService :
         ICrudAppService< //Defines CRUD methods
            BrandDto, //Used to show brands
            Guid, //Primary key of the brand entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBrandDto> //Used to create/update a brand
    {

    }
}
