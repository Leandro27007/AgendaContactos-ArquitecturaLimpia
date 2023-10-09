using Crud.CasosDeUsoPuertos.ContactoPorts;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.Presenter
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddPresentersServices(this IServiceCollection services)
        {
            services.AddScoped<ICrearContactoOutputPort, CrearContactoPrensenter>();
            services.AddScoped<IListarContactosOutputPort, ListarContactosPresenter>();
            services.AddScoped<IEliminarContactoOutputPort, EliminarContactoPresenter>();
            services.AddScoped<IEditarContactoOutputPort, EditarContactoPresenter>();

            return services;
        }


    }
}
