using System;
using System.Linq;
using System.Linq.Expressions;

namespace BaseDomainContract.ServerContract
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Create(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        void Update(TEntity entity);
        IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> where);
        int SaveChanges();
    }
}
