using Microsoft.EntityFrameworkCore;
using Tarea3.Shared;

namespace Tarea3.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
