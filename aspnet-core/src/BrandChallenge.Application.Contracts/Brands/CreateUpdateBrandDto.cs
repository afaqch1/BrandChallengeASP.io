using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BrandChallenge.Brands
{
    public class CreateUpdateBrandDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BrandType Type { get; set; } = BrandType.Undefined;
        [Required]
        public string Description { get; set; }
    }
}
