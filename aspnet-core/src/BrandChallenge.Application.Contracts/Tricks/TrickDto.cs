using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BrandChallenge.Tricks
{
    public class TrickDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public TrickType Type { get; set; }
    }
}
