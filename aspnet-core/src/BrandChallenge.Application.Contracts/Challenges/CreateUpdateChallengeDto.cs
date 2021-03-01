using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BrandChallenge.Challenges
{
    public class CreateUpdateChallengeDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public ChallengeType Type { get; set; } = ChallengeType.Undefined;
    }
}
