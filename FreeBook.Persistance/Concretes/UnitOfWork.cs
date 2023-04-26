namespace FreeBook.Persistance.Concretes;
public sealed class UnitOfWork : IUnitOfWork
{
    public ICategoryRepository Categories { get; private set; }
    public ILogCategoryRepository LogCategories { get; private set; }
    public ISubCategoryRepository SubCategories { get; private set; }
    public ILogSubCategoryRepository LogSubCategories { get; private set; }
    public IBookRepository Books { get; private set; }
    public ILogBookRepository LogBooks { get; private set; }

    private readonly FreeBookDbContext _context;
    public UnitOfWork(FreeBookDbContext context)
    {
        _context = context;
        Categories = new CategoryRepository(_context);
        LogCategories = new LogCategoryRepository(_context);
        SubCategories = new SubCategoryRepository(_context);
        LogSubCategories = new LogSubCategoryRepository(_context);
        Books = new BookRepository(_context);
        LogBooks = new LogBookRepository(_context);
    }
    public async ValueTask DisposeAsync() =>
        await _context.DisposeAsync();
    public async Task<int> SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
