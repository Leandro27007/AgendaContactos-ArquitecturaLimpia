using Crud.CasosDeUsoPuertos.ContactoPorts;

namespace Crud.Presenter
{
    public class EditarContactoPresenter : IEditarContactoOutputPort, IPresenter<bool>
    {
        public bool Content { get; private set; }

        public Task Handle(bool contactoEditado)
        {
            Content = contactoEditado;

            return Task.CompletedTask;
        }
    }
}
