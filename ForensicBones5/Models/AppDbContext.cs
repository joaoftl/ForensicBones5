using Microsoft.EntityFrameworkCore;

namespace ForensicBones5.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<InventarioEsqueleto> InventariosEsqueleto { get; set; }
        public DbSet<InventarioCranio> InventariosCranio { get; set; }
        public DbSet<MarcadoresCranio> MarcadoresCranios { get; set; }
    }
}
