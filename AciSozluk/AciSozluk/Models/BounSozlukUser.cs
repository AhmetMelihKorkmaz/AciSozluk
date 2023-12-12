using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AciSozluk.Models
{
    public class AciSozlukUser : IdentityUser
    {
        [StringLength(300)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Surname { get; set; }

        [StringLength(300)]
        public string PhotoUrl { get; set; }

        public virtual IList<Post> Posts { get; set; }

        public virtual IList<Like> Likes { get; set; }
    }
}
