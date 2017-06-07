using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Template.Repositories.Contracts;

namespace Template.Repositories
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> list)
        {
            throw new NotImplementedException();
        }

        public TEntity Create(TEntity newEntity)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByKeys(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> sorting, bool isDesending = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TResult> GetList<TKey, TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> sorting, bool isDesending, Expression<Func<TEntity, TResult>> selector)
        {
            throw new NotImplementedException();
        }

        public TEntity Remove(TEntity newEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> list)
        {
            throw new NotImplementedException();
        }
    }
}
