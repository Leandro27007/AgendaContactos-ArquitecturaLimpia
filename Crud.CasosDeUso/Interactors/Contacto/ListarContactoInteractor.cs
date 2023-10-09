using Crud.CasosDeUsoPuertos.ContactoPorts;
using Crud.Entities.Interfacers;
using DTOs;

namespace Crud.CasosDeUso.Interactors.Contacto
{
    public class ListarContactoInteractor : IListarContactosInputPort
    {

        private readonly IContactoRepositorio _repositorio;

        private readonly IListarContactosOutputPort _outputPort;
        public ListarContactoInteractor(IContactoRepositorio repositorio, IListarContactosOutputPort outputPort)
        {
            this._repositorio = repositorio;
            this._outputPort = outputPort;
        }

        public async Task Handle()
        {
            var personas = _repositorio.ListarContactos().Select(p =>
             new ContactoDTO()
             {
                 Id = p.Id,
                 Nombre = p.Nombre,
                 Correo = p.InformacionDeContacto.Email,
                 Telefono = p.InformacionDeContacto.Telefono,
                 Nacimiento = p.Nacimiento
             });

           await _outputPort.Handle(personas);
        }
    }
}
