using Crud.Entities.Interfacers;
using Crud.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace Crud.RepositorioEFCore.Repositorio
{
    public class ContactoRepositorio : IContactoRepositorio
    {
        private readonly CrudDbContext _crudDbContext;
        public ContactoRepositorio(CrudDbContext crudDbContext)
        {
            this._crudDbContext = crudDbContext;
        }

        public Persona? BuscarContacto(int IdContacto)
        {
            return _crudDbContext.persona.Where(p => p.Id == IdContacto).FirstOrDefault();
        }

        public void EditarContacto(Persona contacto)
        {
            _crudDbContext.Update(contacto);
        }

        public void EliminarContacto(int IdContacto)
        {
            Persona persona = new() { Id = IdContacto };
            _crudDbContext.Attach(persona);
            _crudDbContext.Remove(persona);
        }

        public void GuardarContacto(Persona contacto)
        {
            _crudDbContext.Add(contacto);
        }

        public IEnumerable<Persona> ListarContactos()
        {
            return _crudDbContext.persona.Include(p => p.InformacionDeContacto);
        }
    }
}
