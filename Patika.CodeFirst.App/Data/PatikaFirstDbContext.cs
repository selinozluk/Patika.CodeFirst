using Microsoft.EntityFrameworkCore;
using Patika.CodeFirst.App.Models;

namespace Patika.CodeFirst.App.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Game> Games => Set<Game>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var cs = @"Server=SELIN;Database=PatikaCodeFirstDb1;Trusted_Connection=True;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(cs);
            }
        }
    }
}
