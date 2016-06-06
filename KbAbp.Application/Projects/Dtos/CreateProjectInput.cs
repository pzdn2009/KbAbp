using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Projects.Dtos
{
    public class CreateProjectInput : IInputDto
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
