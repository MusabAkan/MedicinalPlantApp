using Core.Utilities.Results;
using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.DataAccess.Abstract;
using MedicinalPlantApp.Entities;

namespace MedicinalPlantApp.Business.Concrete
{
    public class PlantManager : IPlantService
    {
        readonly IPlantDal _plantDal;

        public PlantManager(IPlantDal plantDal) => _plantDal = plantDal;

        public IDataResult<Plant> GetById(string PlantId)
        {
            return new SuccessDataResult<Plant>(_plantDal.Get(p => p.Id == Guid.Parse(PlantId)));
        }

        public IDataResult<List<Plant>> GetList()
        {
            return new SuccessDataResult<List<Plant>>(_plantDal.GetList().ToList());
        }

        public IResult Add(Plant Plant)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Plant Plant)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Plant Plant)
        {
            throw new NotImplementedException();
        }
    }
}
