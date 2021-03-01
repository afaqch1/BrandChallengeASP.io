using BrandChallenge.Challenges;
using BrandChallenge.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BrandChallenge.Tricks
{
    public class Trick : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public TrickType Type { get; set; }
        public Guid ChallengeId { get; set; }
        public Challenge Challenge { get; set; }
    }
}
