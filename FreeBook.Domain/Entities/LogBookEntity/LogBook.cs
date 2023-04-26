namespace FreeBook.Domain.Entities.LogBookEntity;

[Table(name: "LogBooks", Schema = "application")]
public class LogBook
{
    public Guid Id { get; set; }
    public string Action { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }

    [ForeignKey(name: nameof(BookId))]
    public Book Book { get; set; }
}
