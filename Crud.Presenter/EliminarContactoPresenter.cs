using Crud.CasosDeUsoPuertos.ContactoPorts;

namespace Crud.Presenter
{
    public class EliminarContactoPresenter : IEliminarContactoOutputPort, IPresenter<bool>
    {
        public bool Content { get; private set; }

        public Task Handle(bool contactoEliminado)
        {
            Content = contactoEliminado;

            return Task.CompletedTask;
        }
    }
}
