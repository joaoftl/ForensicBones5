using Microsoft.EntityFrameworkCore;
using ForensicBones5.Models;

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

        public DbSet<ForensicBones5.Models.InventarioCranio> InventarioCranio { get; set; }

        public DbSet<ForensicBones5.Models.InventarioEsqueleto> InventarioEsqueleto_1 { get; set; }

        public DbSet<ForensicBones5.Models.MarcadoresCranio> MarcadoresCranio_1 { get; set; }

        public DbSet<ForensicBones5.Models.Relatorio> Relatorio { get; set; }
    }
}
