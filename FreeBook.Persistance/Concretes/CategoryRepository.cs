namespace FreeBook.Persistance.Concretes;

public sealed class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(FreeBookDbContext context) : base(context)
    {
    }
}
