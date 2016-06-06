using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Tasks.Dtos
{
    /// <summary>
    /// 更新Dto，带验证
    /// </summary>
    public class UpdateTaskInput : IInputDto, ICustomValidate
    {
        [Range(1, long.MaxValue)] //Data annotation attributes work as expected.
        public long TaskId { get; set; }

        public long? ProjectID { get; set; }

        public string Remark { get; set; }

        public TaskState? State { get; set; }

        public void AddValidationErrors(List<ValidationResult> results)
        {
            if (State == null)
            {
                results.Add(new ValidationResult("状态不能为空", new[] { "State" }));
            }
        }
    }
}
