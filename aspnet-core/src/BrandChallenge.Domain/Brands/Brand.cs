using BrandChallenge.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BrandChallenge.Brands
{
    public class Brand : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public BrandType Type { get; set; }

        public string Description { get; set; }
        public ICollection<Challenge> Challenges { get; set; }

    }
}
