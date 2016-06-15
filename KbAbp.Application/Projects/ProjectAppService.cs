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

        public void CreateProject(CreateProjectInput input)
        {
            _projectRepository.Insert(new Project()
            {
                Name = input.Name,
                Description = input.Description,
                CreationTime = DateTime.Now
            });
        }

        public GetProjectOutput GetProjects(GetProjectInput input)
        {
            var projects = _projectRepository.GetAll();

            if (input != null && !string.IsNullOrEmpty(input.Keyword))
            {
                projects = projects.Where(zw => zw.Name.Contains(input.Keyword));
            }
            
            return new GetProjectOutput()
            {
                Projects = Mapper.Map<List<ProjectDto>>(projects)
            };
        }
    }
}
