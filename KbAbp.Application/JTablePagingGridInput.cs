using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp
{
    public class JTablePagingGridInput : IInputDto
    {
        public int JtStartIndex { get; set; }
        public int JtPageSize { get; set; }
        public string JtSorting { get; set; }
    }
}
