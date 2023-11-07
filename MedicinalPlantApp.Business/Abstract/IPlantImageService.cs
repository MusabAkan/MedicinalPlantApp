using Core.Utilities.Results;
using MedicinalPlantApp.Entities;

namespace MedicinalPlantApp.Business.Abstract
{
    public interface IPlantImageService
    {
        IDataResult<PlantImage> GetById(string PlantImageId);
        IDataResult<List<PlantImage>> GetList();
    }
}
