using Crud.CasosDeUsoPuertos.ContactoPorts;
using DTOs;

namespace Crud.Presenter
{
    public class ListarContactosPresenter : IListarContactosOutputPort, IPresenter<IEnumerable<ContactoDTO>>
    {
        public IEnumerable<ContactoDTO> Content { get; private set; }

        public Task Handle(IEnumerable<ContactoDTO> contatos)
        {
            Content = contatos;

            return Task.CompletedTask;
        }
    }
}
