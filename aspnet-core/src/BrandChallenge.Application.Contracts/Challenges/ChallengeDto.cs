using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BrandChallenge.Challenges
{
    public class ChallengeDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public ChallengeType Type { get; set; }
    }
}
