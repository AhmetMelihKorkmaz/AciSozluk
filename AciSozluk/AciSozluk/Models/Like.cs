using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AciSozluk.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        public string AciSozlukUserId { get; set; }
        public AciSozlukUser AciSozlukUser { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
