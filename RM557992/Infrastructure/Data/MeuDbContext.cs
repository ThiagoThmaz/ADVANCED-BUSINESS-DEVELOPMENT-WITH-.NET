using Microsoft.EntityFrameworkCore;
using RM557992.Domain.Entities;
using RM557992.Infrastructure.Mappings;
using RM557992.Infrastructure.Mappings.SeuProjeto.Infrastructure.Mappings;

namespace RM557992.Infrastructure.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carro> Carros { get; set; }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new CarroMap());
        }
    }
}
