using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MTK.JanitorHelper.EntityFramework.Repositories
{
    public abstract class JanitorHelperRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<JanitorHelperDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected JanitorHelperRepositoryBase(IDbContextProvider<JanitorHelperDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class JanitorHelperRepositoryBase<TEntity> : JanitorHelperRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected JanitorHelperRepositoryBase(IDbContextProvider<JanitorHelperDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
