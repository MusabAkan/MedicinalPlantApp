using MedicinalPlantApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicinalPlantApp.DataAccess.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public ApplicationDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        public DbSet<PlantImage> PlantImages { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
    }
}
