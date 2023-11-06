using MedicinalPlantApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicinalPlantApp.DataAccess.Concrete
{
    public class ApplicationDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("@Server=(localdb)\\MSSQLLocalDB;Database=MedicinalPlantDb");
        }
        public DbSet<PlantImage> PlantImages { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
    }
}
