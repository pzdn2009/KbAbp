using Abp.EntityFramework;
using KbAbp.Kbs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.EntityFramework.Repositories
{
    public class KnowledgeRepository : KbAbpRepositoryBase<Knowledge, long>, IKnowledgeRepository
    {
        public KnowledgeRepository(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
