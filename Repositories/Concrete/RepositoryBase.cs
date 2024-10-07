

using System.Linq.Expressions;
using Entities.Contracts;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
    where TEntity : class, IEntity, new()
    {
        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindAll(bool tracking)
        {
            throw new NotImplementedException();
        }

        public TEntity? FindByCondition(Expression<Func<TEntity, bool>> expression, bool tracking)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}