using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Tasks.Dtos
{
    /// <summary>
    /// 创建任务 Dto
    /// </summary>
    public class CreateTaskInput : IInputDto
    {
        /// <summary>
        /// 任务描述(Required)
        /// </summary>
        [Required]
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("[CreateTaskInput > Description = {0}]", Description);
        }
    }
}
