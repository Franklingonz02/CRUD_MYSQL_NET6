using Microsoft.EntityFrameworkCore;

namespace ApiCoreRestsv.models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext()
        {
        }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Comentario> Comentario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }

    }
}
