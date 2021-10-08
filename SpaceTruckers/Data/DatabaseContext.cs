using Microsoft.EntityFrameworkCore;
using SpaceTruckers.Models;

namespace SpaceTruckers.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<GalaxyMap> GalaxyMaps { get; set; }
        public DbSet<Connection> Connections { get; set; }
    }
}
