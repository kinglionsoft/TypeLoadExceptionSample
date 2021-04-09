using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSample
{
    public interface IRepository<TEntity, TKey> 
    {
        #region Select/Get/Query

        Task<(int Total, IList<TEntity> Items)> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> orderByCreator,
            int skip,
            int take,
            bool includeDetails,
            CancellationToken cancellation = default);

        Task<(int Total, IList<TEntity> Items)> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> orderByCreator,
            int skip,
            int take,
            CancellationToken cancellation = default)
            => GetPagedListAsync(predicate, orderByCreator, skip, take, false, cancellation);
        

        TEntity Single(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false);

        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false, CancellationToken cancellation = default);

        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellation = default)
            => SingleAsync(predicate, false, cancellation);

        TEntity? FirstOrDefault(TKey id, bool includeDetails = false);

        Task<TEntity?> FirstOrDefaultAsync(TKey id, bool includeDetails = false, CancellationToken cancellation = default);

        Task<TEntity?> FirstOrDefaultAsync(TKey id, CancellationToken cancellation = default)
            => FirstOrDefaultAsync(id, false, cancellation);

        TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> predicate, bool includeDetails = false);

        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails, CancellationToken cancellation = default);

        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellation = default)
            => FirstOrDefaultAsync(predicate, false, cancellation);

        TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> configOrderBy, bool includeDetails = false);

        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> configOrderBy, bool includeDetails, CancellationToken cancellation = default);

        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> configOrderBy,
            CancellationToken cancellation = default)
            => FirstOrDefaultAsync(predicate, configOrderBy, false, cancellation);
        
        #endregion


        #region Aggregates
        
        int Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int>> selector);
        long Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, long>> selector);
        float Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, float>> selector);
        double Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, double>> selector);
        decimal Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> selector);
       
    
        #endregion
    }
}