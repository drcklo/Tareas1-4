using Microsoft.EntityFrameworkCore;
using Tarea2.Shared;

namespace Tarea2.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
    }
}
