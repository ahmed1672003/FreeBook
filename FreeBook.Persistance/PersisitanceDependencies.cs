using Microsoft.AspNetCore.Identity;

namespace FreeBook.Persistance;
public static class PersisitanceDependencies
{
    public static IServiceCollection AddPersisitanceDependencies
        (this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<FreeBookDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("FreeBookConnection"));
        });


        services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
        return services;
    }
}
