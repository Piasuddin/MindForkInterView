using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace server.Models
{
    public class BlogUser
    {
        [Key]
        public long Id { get; set; }
        [Column(TypeName ="nvarchar(200)")]
        public string UserName { get; set; }
        public ICollection<BlogCommentLikeAndDislike> BlogCommentLikeAndDislikes { get; set; }
        [JsonIgnore]
        public List<BlogComment> BlogComments { get; set; }
    }
}
