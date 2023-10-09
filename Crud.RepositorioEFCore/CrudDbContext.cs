using Crud.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace Crud.RepositorioEFCore
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> opciones) : base(opciones)
        { }

        public DbSet<Persona> persona { get; set; }
        public DbSet<InformacionDeContacto> informacionDeContacto { get; set; }

    }
}
