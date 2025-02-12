using Infrastracture.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastracture
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<INoteRepository, NoteRepository>();

            serviceCollection.AddDbContext<Infrastracture.Data.AppContext>(x =>
            {
                x.UseNpgsql("Host=localhost;Database=NoteDb;Username=postgres;Password=1234");
            });
            return serviceCollection;
        }
    }
}
