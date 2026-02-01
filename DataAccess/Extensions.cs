using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class Extensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection servicesCollection)
    {
        servicesCollection.AddDbContext<AppContext>(options =>
        {
            options.UseNpgsql("Host=localhost;Port=5432;Database=WebApiApp_Postgres;Username=postgres;Password=1234");
        });
        return servicesCollection;
    }
}
