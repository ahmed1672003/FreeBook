namespace FreeBook.Persistance.Concretes
{
    public class LogCategoryRepository : BaseRepository<LogCategory>, ILogCategoryRepository
    {
        public LogCategoryRepository(FreeBookDbContext context) : base(context)
        {
        }
    }
}
