using Crud.CasosDeUsoPuertos.ContactoPorts;
using Crud.Entities.Interfacers;

namespace Crud.CasosDeUso.Interactors.Contacto
{
    public class EliminarContactoInteractor : IEliminarContactoInputPort
    {
        private readonly IContactoRepositorio _contactoRepositorio;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEliminarContactoOutputPort _outputPort;
        public EliminarContactoInteractor(
            IContactoRepositorio contactoRepositorio,
            IUnitOfWork unitOfWork,
            IEliminarContactoOutputPort outputPort)
        {
            this._contactoRepositorio = contactoRepositorio;
            this._unitOfWork = unitOfWork;
            this._outputPort = outputPort;
        }

        public async Task Handle(int id)
        {
            _contactoRepositorio.EliminarContacto(id);
            await _unitOfWork.GuardarCambiosAsync();

            await _outputPort.Handle(true);
        }
    }
}
