

using System.Linq.Expressions;
using Entities.Contracts;
using Microsoft.EntityFrameworkCore;
using Repositories.Common;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
    where TEntity : class, IEntity, new()
    {
        protected readonly RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }
        public void Create(TEntity entity) 
        => _context.Set<TEntity>().Add(entity);

        public void Delete(TEntity entity)
        => _context.Set<TEntity>().Remove(entity);

        public IQueryable<TEntity> FindAll(bool tracking)
        {
            return tracking ? _context.Set<TEntity>() : _context.Set<TEntity>().AsNoTracking();
        }

        public TEntity? FindByCondition(Expression<Func<TEntity, bool>> expression, bool tracking)
        {
             return tracking 
             ? _context.Set<TEntity>().Where(expression).SingleOrDefault() 
             : _context.Set<TEntity>().Where(expression).AsNoTracking().SingleOrDefault();
        }

        public void Update(TEntity entity)
        => _context.Set<TEntity>().Update(entity);
    }
}