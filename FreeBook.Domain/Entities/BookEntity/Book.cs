namespace FreeBook.Domain.Entities.BookEntity;
[Table(name: "Books", Schema = "application")]
public class Book
{
    public Guid Id { get; set; }
    [Required(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.BookName))]
    [MaxLength(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MaxLength))]
    [MinLength(3,
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MinLength))]
    public string Name { get; set; }
    [Required(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.AuthorName))]
    [MaxLength(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MaxLength))]
    [MinLength(3,
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MinLength))]
    public string AuthorName { get; set; }
    public string ImageName { get; set; }
    public string FileName { get; set; }
    public int CurrentStatues { get; set; }
    public bool IsPublish { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SubCategoryId { get; set; }

    [ForeignKey(name: nameof(CategoryId))]
    public Category Category { get; set; }

    [ForeignKey(name: nameof(SubCategoryId))]
    public SubCategory SubCategory { get; set; }
}
