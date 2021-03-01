using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BrandChallenge.Brands
{
    public class BrandDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public BrandType Type { get; set; }
        public string Description { get; set; }
    }
}
