using Crud.CasosDeUsoPuertos.ContactoPorts;
using Crud.Entities.Interfacers;
using Crud.Entities.POCOs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.CasosDeUso.Interactors.Contacto
{
    public class EditarContactoInteractor : IEditarContactoInputPort
    {

        private readonly IContactoRepositorio _contactoRepositorio;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEditarContactoOutputPort _editarContactoOutputPort;
        public EditarContactoInteractor(
            IContactoRepositorio contactoRepositorio,
            IUnitOfWork unitOfWork,
            IEditarContactoOutputPort editarContactoInputPort
            )
        {
            this._contactoRepositorio = contactoRepositorio;
            this._unitOfWork = unitOfWork;
            this._editarContactoOutputPort = editarContactoInputPort;
        }
        public async Task Handle(EditarContactoDTO contacto)
        {

            _contactoRepositorio.EditarContacto(new Persona()
            {
                Id = contacto.Id,
                Nombre = contacto.NombreContacto,
                Nacimiento = contacto.FechaNacimiento,
                Sexo = contacto.Sexo,
                InformacionDeContacto =
                new InformacionDeContacto()
                {
                    Email = contacto.Correo,
                    Telefono = contacto.Telefono
                }
            });
            await _unitOfWork.GuardarCambiosAsync();

            await _editarContactoOutputPort.Handle(true);
        }
    }
}
