using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P225Allup.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(maximumLength:255)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 255)]
        public string SurName { get; set; }
        [Required]
        [StringLength(maximumLength: 255)]
        public string FatherName { get; set; }
        [Required]
        public byte Age { get; set; }
    }
}
