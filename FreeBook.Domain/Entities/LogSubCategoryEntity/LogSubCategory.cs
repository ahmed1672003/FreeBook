namespace FreeBook.Domain.Entities.LogSubCategoryEntity;

[Table(name: "LogSubCategories", Schema = "application")]
public class LogSubCategory
{
    public Guid Id { get; set; }
    public string Action { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public Guid SubCategoryId { get; set; }

    [ForeignKey(name: nameof(SubCategoryId))]
    public SubCategory SubCategory { get; set; }
}
