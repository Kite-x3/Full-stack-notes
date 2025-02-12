using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Application.Services;


namespace Application
{
    public static class Extensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<INoteService, NoteService>();
            return serviceCollection;
        }
    }
}
