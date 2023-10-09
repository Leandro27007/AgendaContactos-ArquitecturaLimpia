using Crud.Entities.POCOs;

namespace Crud.Entities.Interfacers
{
    public interface IContactoRepositorio
    {
        void GuardarContacto(Persona contacto);
        void EditarContacto(Persona contacto);
        Persona? BuscarContacto(int IdContacto);
        void EliminarContacto(int IdContacto);
        IEnumerable<Persona> ListarContactos();
    }
}
