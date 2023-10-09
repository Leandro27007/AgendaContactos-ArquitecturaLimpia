using DTOs;

namespace Crud.CasosDeUsoPuertos.ContactoPorts
{
    public interface ICrearContactoOutputPort
    {

        Task Handle(ContactoDTO contacto);
    }
}
