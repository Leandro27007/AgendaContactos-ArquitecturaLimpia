using Crud.Entities.Interfacers;
using Crud.RepositorioEFCore.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.RepositorioEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositorioServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<IContactoRepositorio, ContactoRepositorio>();

            service.AddDbContext<CrudDbContext>(opciones =>
                opciones.UseSqlServer(configuration.GetConnectionString("Crud")));

            return service;
        }
    }
}
