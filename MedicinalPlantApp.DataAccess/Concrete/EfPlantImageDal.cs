using MedicinalPlantApp.Core.DataAccess.EntityFramework;
using MedicinalPlantApp.DataAccess.Abstract;
using MedicinalPlantApp.DataAccess.Contexts;
using MedicinalPlantApp.Entities;

namespace MedicinalPlantApp.DataAccess.Concrete
{
    public class EfPlantImageDal : EfEntityRepositoryBase<PlantImage, ApplicationDbContext>, IPlantImageDal { }
}
