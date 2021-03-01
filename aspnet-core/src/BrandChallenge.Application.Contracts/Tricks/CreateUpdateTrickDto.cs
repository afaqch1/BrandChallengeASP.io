using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BrandChallenge.Tricks
{
    public class CreateUpdateTrickDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public TrickType Type { get; set; } = TrickType.Undefined;
    }
}
