using BrandChallenge.Brands;
using BrandChallenge.Tricks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BrandChallenge.Challenges
{
    public class Challenge : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public ChallengeType Type { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Trick> Tricks { get; set; }
    }
}
