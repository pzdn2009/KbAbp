using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace KbAbp.EntityFramework.Repositories
{
    public abstract class KbAbpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<KbAbpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected KbAbpRepositoryBase(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class KbAbpRepositoryBase<TEntity> : KbAbpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected KbAbpRepositoryBase(IDbContextProvider<KbAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
