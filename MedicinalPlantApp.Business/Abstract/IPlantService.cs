using Core.Utilities.Results;
using MedicinalPlantApp.Entities;

namespace MedicinalPlantApp.Business.Abstract
{
    public interface IPlantService
    {
        IDataResult<Plant> GetById(string PlantId);
        IDataResult<List<Plant>> GetList(); 
        IResult Add(Plant Plant);
        IResult Delete(Plant Plant);
        IResult Update(Plant Plant);
    }
}
