using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BrandChallenge.Tricks
{
    public interface ITrickAppService :
        ICrudAppService< //Defines CRUD methods
            TrickDto, //Used to show tricks
            Guid, //Primary key of the trick entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTrickDto> //Used to create/update a trick
    {
        public bool MatchStrings(TrickType type);
       
    }
}
