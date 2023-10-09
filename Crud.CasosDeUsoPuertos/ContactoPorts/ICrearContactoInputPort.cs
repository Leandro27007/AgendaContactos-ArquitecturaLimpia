using DTOs;

namespace Crud.CasosDeUsoPuertos.ContactoPorts
{
    public interface ICrearContactoInputPort
    {
        Task Handle(CrearContactoDTO contacto);
    }
}
