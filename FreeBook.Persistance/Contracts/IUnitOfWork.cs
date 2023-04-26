namespace FreeBook.Persistance.Contracts;
public interface IUnitOfWork : IAsyncDisposable
{
    ICategoryRepository Categories { get; }
    ILogCategoryRepository LogCategories { get; }
    ISubCategoryRepository SubCategories { get; }
    ILogSubCategoryRepository LogSubCategories { get; }
    IBookRepository Books { get; }
    ILogBookRepository LogBooks { get; }
    Task<int> SaveChangesAsync();
}
