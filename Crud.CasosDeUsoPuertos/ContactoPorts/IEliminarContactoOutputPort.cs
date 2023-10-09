namespace Crud.CasosDeUsoPuertos.ContactoPorts
{
    public interface IEliminarContactoOutputPort
    {
        Task Handle(bool contactoEliminado);
    }
}
