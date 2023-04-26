namespace FreeBook.Persistance.Concretes;
public class BookRepository : BaseRepository<Book>, IBookRepository
{
    public BookRepository(FreeBookDbContext context) : base(context)
    {
    }
}
