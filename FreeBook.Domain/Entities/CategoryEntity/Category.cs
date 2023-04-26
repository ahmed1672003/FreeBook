namespace FreeBook.Domain.Entities.CategoryEntity;

[Table(name: "Categories", Schema = "application")]
public class Category
{
    public Guid Id { get; set; }

    [Required(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.SubCategoryName))]
    [MaxLength(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MaxLength))]
    [MinLength(3,
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MinLength))]
    public string Name { get; set; }
    public string? Description { get; set; }
    public int CurrentStatus { get; set; }
}
