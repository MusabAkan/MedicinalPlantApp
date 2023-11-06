using MedicinalPlantApp.DataAccess.Abstract;
using MedicinalPlantApp.DataAccess.Concrete;
using MedicinalPlantApp.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MedicinalPlantApp.DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IPlantDal, EfPlantDal>();
            services.AddScoped<IPlantImageDal, EfPlantImageDal>();
            services.AddScoped<IComplaintDal, EfComplaintDal>();
        }
    }

}
