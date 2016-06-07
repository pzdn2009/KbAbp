using Abp.EntityFramework;
using KbAbp.Kbs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.EntityFramework.Repositories
{
    public class KBCategoryRepository : KbAbpRepositoryBase<KBCategory, long>, IKBCategoryRepository
    {
        public KBCategoryRepository(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
