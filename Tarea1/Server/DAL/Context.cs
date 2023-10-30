using Microsoft.EntityFrameworkCore;
using Tarea1.Shared;

namespace Tarea1.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }
        public DbSet<Prioridades> Prioridades { get; set; }
    }
}
