using iglesia.Models;
using Microsoft.EntityFrameworkCore;

namespace iglesia.Data
{
    public class TuDbContext : DbContext
    {
        // ...
        public TuDbContext(DbContextOptions<TuDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar la clave primaria
            modelBuilder.Entity<EventoModel>().HasKey(e => e.ID_evento);
        }
         public DbSet<EventoModel> EventosLiturgicos { get; set; }
         
    }
}
