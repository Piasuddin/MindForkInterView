using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class BlogPost
    {
        [Key]
        public long Id { get; set; }
        public long BlogUserId { get; set; }
        [MaxLength(500)]
        [Required]
        public string Post { get; set; }
        public DateTime PostDate { get; set; }
        public ICollection<BlogComment> BlogComments { get; set; }
        public BlogUser BlogUser { get; set; }
    }
}
