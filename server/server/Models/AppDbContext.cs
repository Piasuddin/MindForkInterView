using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<BlogCommentLikeAndDislike>()
                            .HasOne(c => c.BlogUser).WithMany(e => e.BlogCommentLikeAndDislikes)
                            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<BlogComment>()
                            .HasOne(c => c.BlogUser).WithMany(e => e.BlogComments)
                            .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<BlogUser> BlogUsers { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogCommentLikeAndDislike> BlogCommentLikeAndDislikes { get; set; }
    }
}
