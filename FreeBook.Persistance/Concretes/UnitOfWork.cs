namespace FreeBook.Persistance.Concretes;
public sealed class UnitOfWork : IUnitOfWork
{
    public ICategoryRepository Categories { get; private set; }
    private readonly FreeBookDbContext _context;
    public UnitOfWork(FreeBookDbContext context)
    {
        _context = context;
        Categories = new CategoryRepository(_context);
    }
    public async ValueTask DisposeAsync() =>
        await _context.DisposeAsync();
    public async Task<int> SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
