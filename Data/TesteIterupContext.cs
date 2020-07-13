using Microsoft.EntityFrameworkCore;
using TesteIterup.Models;

namespace TesteIterup.Data
{
    public class TesteIterupContext : DbContext
    {
        public TesteIterupContext (DbContextOptions<TesteIterupContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
