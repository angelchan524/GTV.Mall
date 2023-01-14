using GTV.Mall.Repository.Data;
using GTV.Mall.Repository.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Repository.Repositories
{

    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        protected ApplicationDbContext dbContext;

        protected DbSet<TEntity> dbSet;

        public Repository(ApplicationDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            dbContext = context;
            dbSet = dbContext.Set<TEntity>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                    dbContext = null;
                }
            }
        }

        public virtual TEntity Get(TKey id)
        {
            return dbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet.AsNoTracking().AsQueryable();
        }

        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter)
        {
            return dbSet.AsNoTracking().Where(filter);
        }

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
            var instance = dbSet.FirstOrDefault(filter);
            if (instance != null)
            {
                dbContext.Entry(instance).Reload();
            }
            return instance;
        }

        public virtual TResult Max<TResult>(Func<TEntity, TResult> selector)
        {
            return dbSet.AsNoTracking().Max(selector);
        }

        public virtual void Create(TEntity instance)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));
            dbSet.Add(instance);
        }

        public virtual void Detached(TEntity instance)
        {
            dbContext.Entry(instance).State = EntityState.Detached;
        }

        public virtual void Update(TEntity instance, params object[] keyValues)
        {
            Update<TEntity>(instance, keyValues);
        }

        protected T Update<T>(T instance, params object[] keyValues) where T : class
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            var entry = dbContext.Entry(instance);
            if (entry.State == EntityState.Detached)
            {
                if (keyValues != null && keyValues.Any())
                {
                    var set = dbContext.Set<T>();
                    T attachedEntity = set.Find(keyValues);
                    if (attachedEntity != null)
                    {
                        var attachedEntry = dbContext.Entry(attachedEntity);
                        attachedEntry.CurrentValues.SetValues(instance);
                        return attachedEntity;
                    }
                }
            }

            entry.State = EntityState.Modified;
            return instance;
        }

        public virtual void Delete(TKey id)
        {
            var item = dbSet.Find(id);
            if (item != null)
                dbSet.Remove(item);
        }

        public virtual void Delete(TEntity item)
        {
            if (item != null)
            {
                if (!dbSet.Local.Contains(item))
                {
                    dbSet.Attach(item);
                }
                dbSet.Remove(item);
            }
        }

        public bool Exists(TKey id)
        {
            return (dbSet.Find(id) != null);
        }

        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            return (dbSet.Any(filter));
        }
    }
}
