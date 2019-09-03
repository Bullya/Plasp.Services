using BaseDomainContract.ServerContract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BaseDomain
{
    public class BaseRepository<TContext, TEntity> : IRepository<TEntity> where TContext : DbContext where TEntity : class
    {
        public readonly TContext Db;
        protected readonly DbSet<TEntity> DbSet;
        public BaseRepository(TContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Create(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            DbSet.Remove(DbSet.Find(where));
        }

        public virtual IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> where)
        {
            return DbSet;
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
