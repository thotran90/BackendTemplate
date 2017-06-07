using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Template.Repositories.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetList();
        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> sorting, bool isDesending = false);
        IQueryable<TResult> GetList<TKey, TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> sorting, bool isDesending
            , Expression<Func<TEntity, TResult>> selector);
        TEntity Create(TEntity newEntity);
        TEntity Remove(TEntity newEntity);
        IEnumerable<TEntity> AddRange(IEnumerable<TEntity> list);
        IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> list);
        TEntity GetByKeys(params object[] keys);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter);
    }
}
