namespace FreeBook.Domain.Entities.SubCategoryEntity;

[Table(name: "SubCategories", Schema = "application")]
public class SubCategory
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
    public Guid CategoryId { get; set; }

    [ForeignKey(name: nameof(CategoryId))]
    public Category Category { get; set; }
}
