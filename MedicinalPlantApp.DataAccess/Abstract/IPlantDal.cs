using MedicinalPlantApp.Core.DataAccess;
using MedicinalPlantApp.Entities;

namespace MedicinalPlantApp.DataAccess.Abstract
{
    public interface IPlantDal : IEntityRepository<Plant>
    {
    }
}
