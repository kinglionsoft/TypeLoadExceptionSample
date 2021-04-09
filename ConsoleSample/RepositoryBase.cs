using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSample
{
    public abstract class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey>
    {
        public virtual Task<(int Total, IList<TEntity> Items)> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IQueryable<TEntity>> orderByCreator, int skip, int take, bool includeDetails,
            CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Single(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity? FirstOrDefault(TKey id, bool includeDetails = false)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity?> FirstOrDefaultAsync(TKey id, bool includeDetails = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> configOrderBy, bool includeDetails = false)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> configOrderBy, bool includeDetails,
            CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public virtual int Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int>> selector)
        {
            throw new NotImplementedException();
        }

        public virtual long Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, long>> selector)
        {
            throw new NotImplementedException();
        }

        public virtual float Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, float>> selector)
        {
            throw new NotImplementedException();
        }

        public virtual double Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, double>> selector)
        {
            throw new NotImplementedException();
        }

        public virtual decimal Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> selector)
        {
            throw new NotImplementedException();
        }
    }
}