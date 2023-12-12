using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AciSozluk.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

        public string AciSozlukUserId { get; set; }

        public string AciSozlukUserName { get; set; }
        public AciSozlukUser AciSozlukUser { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public virtual IList<Like> Likes { get; set; }
    }
}
