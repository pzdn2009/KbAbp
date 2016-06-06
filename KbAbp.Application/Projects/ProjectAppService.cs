using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KbAbp.Projects.Dtos;
using AutoMapper;
using KbAbp.Projects;

namespace KbAbp.Projects
{
    public class ProjectAppService : ApplicationService, IProjectAppService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectAppService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public GetProjectOutput GetProjects(GetProjectInput input)
        {
            var projects = _projectRepository.GetAll();

            if (input != null && !string.IsNullOrEmpty(input.Keyword))
            {
                projects = projects.Where(zw => zw.Name.Contains(input.Keyword));
            }

            Mapper.CreateMap<Project, ProjectDto>();
            return new GetProjectOutput()
            {
                Projects = Mapper.Map<List<ProjectDto>>(projects)
            };
        }
    }
}
