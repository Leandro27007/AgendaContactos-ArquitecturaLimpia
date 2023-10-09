using Crud.CasosDeUso.Interactors.Contacto;
using Crud.CasosDeUsoPuertos.ContactoPorts;
using Microsoft.Extensions.DependencyInjection;


namespace Crud.CasosDeUso.Interactors
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddCasosDeUsoServices(this IServiceCollection service)
        {

            service.AddTransient<ICrearContactoInputPort, CrearContactoInteractor>();
            service.AddTransient<IListarContactosInputPort, ListarContactoInteractor>();
            service.AddTransient<IEliminarContactoInputPort, EliminarContactoInteractor>();
            service.AddTransient<IEditarContactoInputPort, EditarContactoInteractor>();

            return service;
        }

    }
}
