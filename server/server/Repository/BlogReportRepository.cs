using Microsoft.EntityFrameworkCore;
using server.Models;
using server.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Repository
{
    public class BlogReportRepository: IBlogReportRepository
    {
        private readonly AppDbContext appDbContext;

        public BlogReportRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Object> GetReport(TableSearchOptions tableSearchOptions)
        {
            try
            {
                var data = await appDbContext.BlogPosts
                .Include(x => x.BlogUser)
                .Include(e => e.BlogComments)
                .ThenInclude(p => p.BlogUser)
                .ThenInclude(x => x.BlogCommentLikeAndDislikes)
                .Skip(tableSearchOptions.Skip != null? (int)tableSearchOptions.Skip: 0)
                .Take(tableSearchOptions.Take != null ? (int)tableSearchOptions.Take : 3)
                .ToListAsync();
                return data;
            }
            catch(Exception e)
            {

            }
            return null;
        }
    }
}
