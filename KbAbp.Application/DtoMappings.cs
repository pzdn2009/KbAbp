using AutoMapper;
using KbAbp.Kbs;
using KbAbp.Kbs.Dtos;
using KbAbp.Projects;
using KbAbp.Projects.Dtos;
using KbAbp.Tasks;
using KbAbp.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KbAbp
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            Mapper.CreateMap<Task, TaskDto>().ForMember(dest => dest.ProjectName, option => option.MapFrom(
                 src => src.Project != null ? src.Project.Name : string.Empty));

            Mapper.CreateMap<Project, ProjectDto>();

            Mapper.CreateMap<KbQueue, KbQueueDto>();

            Mapper.CreateMap<KbCategory, KbCategoryDto>();
        }
    }
}
