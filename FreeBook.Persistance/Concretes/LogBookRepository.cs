namespace FreeBook.Persistance.Concretes;
public class LogBookRepository : BaseRepository<LogBook>, ILogBookRepository
{
    public LogBookRepository(FreeBookDbContext context) : base(context)
    {
    }
}
