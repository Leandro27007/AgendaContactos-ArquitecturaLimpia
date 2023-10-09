using Crud.Entities.Interfacers;

namespace Crud.RepositorioEFCore.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CrudDbContext _crudDbContext;
        public UnitOfWork(CrudDbContext crudDbContext)
        {
            this._crudDbContext = crudDbContext;
        }

        public async Task<int> GuardarCambiosAsync()
        {
            return await _crudDbContext.SaveChangesAsync();
        }
    }
}
