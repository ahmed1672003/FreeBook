namespace FreeBook.Persistance.Contexts;
public class FreeBookDbContext : IdentityDbContext<ApplicationUser>
{
    public FreeBookDbContext(DbContextOptions<FreeBookDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ApplicationUser>().ToTable("ApplicationUsers", "security");
        builder.Entity<IdentityRole>().ToTable("Roles", "security");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");

        builder.Entity<Category>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NewId()");


        builder.Entity<LogCategory>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NewId()");

        builder.Entity<Book>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NewId()");

        builder.Entity<LogBook>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NewId()");

        builder.Entity<SubCategory>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NewId()");

        builder.Entity<LogSubCategory>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NewId()");
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<LogCategory> LogCategories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<LogBook> LogBooks { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<LogSubCategory> LogSubCategories { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
}
