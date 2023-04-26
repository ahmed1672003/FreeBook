namespace FreeBook.Domain.Entities.ApplicationUserEntity;

[Table(name: "ApplicationUsers", Schema = "security")]
public class ApplicationUser : IdentityUser
{
    [Required(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.UserName))]
    [MaxLength(
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MaxLength))]
    [MinLength(3,
    ErrorMessageResourceType = typeof(ResourceData),
    ErrorMessageResourceName = nameof(ResourceData.MinLength))]
    public string Name { get; set; }
    public string ImageName { get; set; }
    public bool IsActive { get; set; }
}
