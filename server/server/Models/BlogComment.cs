using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace server.Models
{
    public class BlogComment
    {
        [Key]
        public long Id { get; set; }
        public long BlogPostId { get; set; }
        public DateTime CommentDate { get; set; }
        public long BlogUserId { get; set; }
        [MaxLength(300)]
        [Required]
        public string Comment { get; set; }
        [JsonIgnore]
        public BlogPost BlogPost { get; set; }
        public ICollection<BlogCommentLikeAndDislike> BlogCommentLikeAndDislikes { get; set; }
        public BlogUser BlogUser { get; set; }
    }
}
