using Crud.CasosDeUsoPuertos.ContactoPorts;
using Crud.Entities.Interfacers;
using Crud.Entities.POCOs;
using DTOs;

namespace Crud.CasosDeUso.Interactors.Contacto
{
    public class CrearContactoInteractor : ICrearContactoInputPort
    {

        private readonly IContactoRepositorio _repositorio;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICrearContactoOutputPort _outputPort;
        public CrearContactoInteractor(IContactoRepositorio repositorio, IUnitOfWork unitOfWork, ICrearContactoOutputPort outputPort)
        {
            this._repositorio = repositorio;
            this._outputPort = outputPort;
            this._unitOfWork = unitOfWork;
        }

        public async Task Handle(CrearContactoDTO contactoDTO)
        {


            var contacto = new Persona()
            {
                Nombre = contactoDTO.NombreContacto,
                Nacimiento = contactoDTO.FechaNacimiento,
                Sexo = contactoDTO.Sexo,
                InformacionDeContacto = new InformacionDeContacto()
                {
                    Email = contactoDTO.Correo,
                    Telefono = contactoDTO.Telefono
                }
            };

            _repositorio.GuardarContacto(contacto);
            await _unitOfWork.GuardarCambiosAsync();

            await _outputPort.Handle(new ContactoDTO()
            {
                Id = contacto.Id,
                Nombre = contacto.Nombre,
                Nacimiento = contacto.Nacimiento,
                Correo = contacto.InformacionDeContacto.Email,
                Telefono = contacto.InformacionDeContacto.Telefono
            });

        }
    }
}
