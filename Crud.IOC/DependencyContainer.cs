using Crud.CasosDeUso.Interactors;
using Crud.Presenter;
using Crud.RepositorioEFCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.IOC
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddCrudDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositorioServices(configuration);
            services.AddPresentersServices();
            services.AddCasosDeUsoServices();

            return services;
        }

    }
}
