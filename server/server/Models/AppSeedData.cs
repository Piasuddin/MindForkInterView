using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public static class AppSeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<BlogUser>().HasData(
                new BlogUser { Id = 1, UserName = "User 1" },
                new BlogUser { Id = 2, UserName = "User 2" },
                new BlogUser { Id = 3, UserName = "User 3" },
                new BlogUser { Id = 4, UserName = "User 4" },
                new BlogUser { Id = 5, UserName = "User 5" },
                new BlogUser { Id = 6, UserName = "User 6" }
                );
            builder.Entity<BlogPost>().HasData(
                new BlogPost { Id = 1, Post = "Blog 1", BlogUserId = 3, PostDate = DateTime.Now },
                new BlogPost { Id = 2, Post = "Blog 2", BlogUserId = 1, PostDate = DateTime.Now.AddDays(-2) },
                new BlogPost { Id = 3, Post = "Blog 3", BlogUserId = 4, PostDate = DateTime.Now.AddDays(-1) },
                 new BlogPost { Id = 4, Post = "Blog 4", BlogUserId = 5, PostDate = DateTime.Now.AddDays(-1) }
                );
            builder.Entity<BlogComment>().HasData(
                new BlogComment { Id = 1, BlogPostId = 1, BlogUserId = 1, Comment = "Comment 1", CommentDate = DateTime.Now.AddDays(-1) },
                new BlogComment { Id = 2, BlogPostId= 1, BlogUserId = 2, Comment = "Comment 2" , CommentDate = DateTime.Now},
                new BlogComment { Id = 3, BlogPostId= 1, BlogUserId = 1, Comment = "Comment 3" , CommentDate = DateTime.Now.AddDays(-2) },
                new BlogComment { Id = 4, BlogPostId= 2, BlogUserId = 3, Comment = "Comment 4" , CommentDate = DateTime.Now.AddDays(-2) },
                new BlogComment { Id = 5, BlogPostId= 2, BlogUserId = 4, Comment = "Comment 5" , CommentDate = DateTime.Now},
                new BlogComment { Id = 6, BlogPostId= 3, BlogUserId = 5, Comment = "Comment 6" , CommentDate = DateTime.Now},
                new BlogComment { Id = 7, BlogPostId = 3, BlogUserId = 6, Comment = "Comment 7", CommentDate = DateTime.Now.AddDays(-1) },
                new BlogComment { Id = 8, BlogPostId = 3, BlogUserId = 4, Comment = "Comment 8", CommentDate = DateTime.Now },
                new BlogComment { Id = 9, BlogPostId = 4, BlogUserId = 6, Comment = "Comment 9", CommentDate = DateTime.Now.AddDays(-1) }
                );
            builder.Entity<BlogCommentLikeAndDislike>().HasData(
               new BlogCommentLikeAndDislike { Id = 1, BlogCommentId = 1, UserId = 1, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 2, BlogCommentId = 1, UserId = 2, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 3, BlogCommentId = 1, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 4, BlogCommentId = 1, UserId = 4, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 5, BlogCommentId = 1, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 6, BlogCommentId = 1, UserId = 6, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 7, BlogCommentId = 2, UserId = 1, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 8, BlogCommentId = 2, UserId = 2, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 9, BlogCommentId = 2, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 10, BlogCommentId = 2, UserId = 4, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 11, BlogCommentId = 2, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 12, BlogCommentId = 2, UserId = 6, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 13, BlogCommentId = 3, UserId = 1, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 14, BlogCommentId = 3, UserId = 2, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 16, BlogCommentId = 3, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 17, BlogCommentId = 3, UserId = 4, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 18, BlogCommentId = 3, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 19, BlogCommentId = 3, UserId = 6, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 20, BlogCommentId = 4, UserId = 1, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 21, BlogCommentId = 4, UserId = 2, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 22, BlogCommentId = 4, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 23, BlogCommentId = 4, UserId = 4, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 24, BlogCommentId = 4, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 25, BlogCommentId = 4, UserId = 6, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 26, BlogCommentId = 5, UserId = 1, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 27, BlogCommentId = 5, UserId = 2, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 28, BlogCommentId = 5, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 29, BlogCommentId = 5, UserId = 4, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 30, BlogCommentId = 5, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 31, BlogCommentId = 5, UserId = 6, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 32, BlogCommentId = 6, UserId = 1, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 33, BlogCommentId = 6, UserId = 2, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 34, BlogCommentId = 6, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 35, BlogCommentId = 6, UserId = 4, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 36, BlogCommentId = 6, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 37, BlogCommentId = 6, UserId = 6, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 38, BlogCommentId = 7, UserId = 1, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 39, BlogCommentId = 7, UserId = 2, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 40, BlogCommentId = 7, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 41, BlogCommentId = 7, UserId = 4, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 42, BlogCommentId = 7, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 43, BlogCommentId = 7, UserId = 6, IsLike = true },
               new BlogCommentLikeAndDislike { Id = 44, BlogCommentId = 8, UserId = 3, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 45, BlogCommentId = 8, UserId = 4, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 46, BlogCommentId = 9, UserId = 5, IsLike = false },
               new BlogCommentLikeAndDislike { Id = 47, BlogCommentId = 9, UserId = 6, IsLike = true }
               );
        }
    }
}
