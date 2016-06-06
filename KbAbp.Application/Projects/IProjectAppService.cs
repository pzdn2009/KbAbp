using Abp.Application.Services;
using KbAbp.Projects.Dtos;
using KbAbp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Projects
{
    public interface IProjectAppService
    {
        GetProjectOutput GetProjects(GetProjectInput input);

        void CreateProject(CreateProjectInput input);
    }
}
