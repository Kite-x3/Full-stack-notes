using Infrastracture.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Infrastracture
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<INoteRepository, NoteRepository>();

            var connectionString = configuration.GetConnectionString("Database");

            serviceCollection.AddDbContext<Infrastracture.Data.AppContext>(x =>
            {
                x.UseNpgsql(connectionString);
            });
            return serviceCollection;
        }
    }
}
