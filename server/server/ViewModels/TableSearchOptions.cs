using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.ViewModels
{
    public class TableSearchOptions
    {
        public int? Take { get; set; }
        public int? Skip { get; set; }
        public string FilterValue { get; set; }
    }
}
