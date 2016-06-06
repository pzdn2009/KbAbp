using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Tasks.Dtos
{
    /// <summary>
    /// 任务Dto(具有主键)
    /// </summary>
    public class TaskDto : EntityDto<long>
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        public long ? ProjectID { get; set; }
        /// <summary>
        /// 项目
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public byte State { get; set; }
    }
}
