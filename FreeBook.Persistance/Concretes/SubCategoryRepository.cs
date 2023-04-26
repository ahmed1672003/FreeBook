namespace FreeBook.Persistance.Concretes;
public sealed class SubCategoryRepository : BaseRepository<SubCategory>, ISubCategoryRepository
{
    public SubCategoryRepository(FreeBookDbContext context) : base(context)
    {
    }
}
