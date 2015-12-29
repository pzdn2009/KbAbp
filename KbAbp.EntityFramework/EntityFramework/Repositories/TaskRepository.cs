using Abp.EntityFramework;
using KbAbp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KbAbp.EntityFramework.Repositories
{
    public class TaskRepository : KbAbpRepositoryBase<Task, long>, ITaskRepository
    {
        public TaskRepository(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
