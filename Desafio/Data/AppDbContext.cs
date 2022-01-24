using Desafio.Model;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Morador> Moradores { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Despesa>().HasKey(m => m.idDespesa);
            base.OnModelCreating(builder);

            builder.Entity<Inquilino>().HasKey(m => m.idInquilino);
            base.OnModelCreating(builder);

            builder.Entity<Unidade>().HasKey(m => m.idUnidade);
            base.OnModelCreating(builder);
        }
    }
}
