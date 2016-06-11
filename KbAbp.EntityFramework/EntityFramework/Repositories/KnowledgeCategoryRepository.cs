using Abp.EntityFramework;
using KbAbp.Kbs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.EntityFramework.Repositories
{
    public class KnowledgeCategoryRepository : KbAbpRepositoryBase<KnowledgeCategory, long>, IKnowledgeCategoryRepository
    {
        public KnowledgeCategoryRepository(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
