using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Crud.RepositorioEFCore
{
    public class CrudDbContextFactory : IDesignTimeDbContextFactory<CrudDbContext>
    {
        public CrudDbContext CreateDbContext(string[] args)
        {

            var optionBuilder = new DbContextOptionsBuilder<CrudDbContext>();
            optionBuilder.UseSqlServer("Server=localhost; database=CrudContactos; Integrated Security= true; TrustServerCertificate=true;");

            return new CrudDbContext(optionBuilder.Options);
        }
    }
}
