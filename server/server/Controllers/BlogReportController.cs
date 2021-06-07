using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Repository;
using server.ViewModels;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogReportController : ControllerBase
    {
        private readonly IBlogReportRepository blogReportRepository;

        public BlogReportController(IBlogReportRepository blogReportRepository)
        {
            this.blogReportRepository = blogReportRepository;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Object))]
        public async Task<IActionResult> GetReport(TableSearchOptions tableSearchOptions)
        {
            return Ok(await blogReportRepository.GetReport(tableSearchOptions));
        }
    }
}