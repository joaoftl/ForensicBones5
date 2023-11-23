using Microsoft.EntityFrameworkCore;

namespace ForensicBones5.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Usuario> Relatorios { get; set; }

        public DbSet<Usuario> MarcadoresCranio { get; set; }

        public DbSet<Usuario> InventariosCranio { get; set; }

        public DbSet<Usuario> InventarioEsqueleto { get; set; }
    }
}
