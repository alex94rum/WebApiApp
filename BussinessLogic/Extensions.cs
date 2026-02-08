using Microsoft.Extensions.DependencyInjection;

namespace BussinessLogic;

public static class Extensions
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection servicesCollection)
    {
        servicesCollection.AddScoped<INoteService, NoteService>();
        return servicesCollection;
    }
}
