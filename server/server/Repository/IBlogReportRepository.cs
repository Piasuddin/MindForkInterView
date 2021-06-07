using server.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Repository
{
    public interface IBlogReportRepository
    {
        Task<Object> GetReport(TableSearchOptions tableSearchOptions);
    }
}
