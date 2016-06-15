using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp
{
    /// <summary>
    /// 分页表格的条件
    /// </summary>
    public class PagingGridInputBase : IInputDto
    {
        /// <summary>
        /// 页的大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 页数，从1开始计数
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 排序：asc desc
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// 搜索文本
        /// </summary>
        public string SearchText { get; set; }
    }
}
