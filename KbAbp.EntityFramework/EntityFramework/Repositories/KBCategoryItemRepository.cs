using Abp.EntityFramework;
using KbAbp.Kbs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.EntityFramework.Repositories
{
    public class KbCategoryItemRepository : KbAbpRepositoryBase<KbCategoryItem, long>, IKbCategoryItemRepository
    {
        public KbCategoryItemRepository(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
