using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Tasks.Dtos
{
    public class GetTasksInput : IInputDto
    {
        public long? Id { get; set; }
        public TaskState? State { get; set; }
    }
}
