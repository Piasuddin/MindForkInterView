using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace server.Models
{
    public class BlogCommentLikeAndDislike
    {
        [Key]
        public long Id { get; set; }
        public long BlogCommentId { get; set; }
        [ForeignKey("BlogUser")]
        public long UserId { get; set; }
        public bool IsLike { get; set; }
        [JsonIgnore]
        public BlogComment BlogComment { get; set; }
        [JsonIgnore]
        public BlogUser BlogUser { get; set; }
    }
}
