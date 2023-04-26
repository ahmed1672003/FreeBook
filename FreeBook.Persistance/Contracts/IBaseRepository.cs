namespace FreeBook.Persistance.Contracts;
public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
    Task<IEnumerable<TEntity>> DeleteRangeAsync(IEnumerable<TEntity> entities);
    Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities);

    Task<IQueryable<TEntity>>
        GetAllAsync
        (Expression<Func<TEntity, bool>> criteria = null,
        string[] includes = null,
        int? take = null,
        int? skip = null,
        Expression<Func<TEntity, object>> orderBy = null,
        string orderByDirection = null);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> criteria, string[] includes = null);
    Task<int> CountAsync(Expression<Func<TEntity, bool>> criteria = null);
}
