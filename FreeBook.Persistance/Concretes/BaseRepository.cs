namespace FreeBook.Persistance.Concretes;
public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly FreeBookDbContext _context;
    protected readonly DbSet<TEntity> _entities;
    public BaseRepository(FreeBookDbContext context)
    {
        _context = context;
        _entities = _context.Set<TEntity>();
    }
    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        await _entities.AddAsync(entity);

        return await Task.FromResult(entity);
    }
    public virtual async Task<TEntity> DeleteAsync(TEntity entity)
    {
        _entities.Remove(entity);
        return await Task.FromResult(entity);
    }
    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        _entities.Update(entity);

        return await Task.FromResult(entity);
    }
    public virtual async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await _entities.AddRangeAsync(entities);
        return await Task.FromResult(entities);
    }
    public virtual async Task<IEnumerable<TEntity>> DeleteRangeAsync(IEnumerable<TEntity> entities)
    {
        _entities.RemoveRange(entities);
        return await Task.FromResult(entities);
    }
    public virtual async Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities)
    {
        _entities.UpdateRange(entities);
        return await Task.FromResult(entities);
    }
    public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> criteria = null)
    {
        if (criteria is null)
            return await _entities.CountAsync();
        else
            return await _entities.CountAsync(criteria);
    }
    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> criteria, string[] includes = null)
    {
        IQueryable<TEntity> entities = _entities.AsNoTracking().Where(criteria);

        if (includes is not null)
            foreach (var include in includes)
                entities = entities.Include(include);

        return await entities.FirstOrDefaultAsync(criteria);
    }

    public virtual async Task<IQueryable<TEntity>>
        GetAllAsync(
        Expression<Func<TEntity, bool>> criteria = null,
        string[] includes = null,
        int? take = null,
        int? skip = null,
        Expression<Func<TEntity, object>> orderBy = null,
        string orderByDirection = null
        )
    {
        IQueryable<TEntity> entities = _entities.AsNoTracking();

        if (criteria is not null)
            entities = entities.Where(criteria);

        if (includes is not null)
            foreach (var include in includes)
                entities = entities.Include(include);

        if (take.HasValue)
            entities = entities.Take(take.Value);

        if (skip.HasValue)
            entities = entities.Skip(skip.Value);

        if (orderBy is not null)
        {
            if (orderByDirection.Equals(OrderBy.Descending))
                entities = entities.OrderByDescending(orderBy);
            else
                entities = entities.OrderBy(orderBy);
        }
        return await Task.FromResult(entities);
    }
}
