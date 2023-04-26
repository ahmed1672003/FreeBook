namespace FreeBook.Persistance.Contracts;

public interface IUnitOfWork : IAsyncDisposable
{
    ICategoryRepository Categories { get; }
    Task<int> SaveChangesAsync();
}
