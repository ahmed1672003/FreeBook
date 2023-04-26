namespace FreeBook.Persistance.Concretes;
public class LogSubCategoryRepository : BaseRepository<LogSubCategory>, ILogSubCategoryRepository
{
    public LogSubCategoryRepository(FreeBookDbContext context) : base(context)
    {
    }
}
