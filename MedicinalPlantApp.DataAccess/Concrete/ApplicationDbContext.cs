using Microsoft.EntityFrameworkCore;

namespace MedicinalPlantApp.DataAccess.Concrete
{
    public class ApplicationDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("@server")
        }
    }
}
