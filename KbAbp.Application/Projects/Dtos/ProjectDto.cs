﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Projects.Dtos
{
    public class ProjectDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
