namespace FreeBook.Domain.Entities.LogCategoryEntity;

[Table(name: "LogCategories", Schema = "application")]
public class LogCategory
{
    public Guid Id { get; set; }
    public string Action { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }

    [ForeignKey(name: nameof(CategoryId))]
    public Category Category { get; set; }
}
