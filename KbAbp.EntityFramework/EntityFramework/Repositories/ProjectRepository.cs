using Abp.EntityFramework;
using KbAbp.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.EntityFramework.Repositories
{
    public class ProjectRepository : KbAbpRepositoryBase<Project, long>, IProjectRepository
    {
        public ProjectRepository(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
