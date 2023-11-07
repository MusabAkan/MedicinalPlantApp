using Core.Utilities.Results;
using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.DataAccess.Abstract;
using MedicinalPlantApp.DataAccess.Concrete;
using MedicinalPlantApp.Entities;

namespace MedicinalPlantApp.Business.Concrete
{
    public class PlantManager : IPlantService
    {
        readonly IPlantDal _plantDal;
        readonly IPlantImageService _plantImageService;

        public PlantManager(IPlantDal plantDal)
        {
            _plantImageService = new PlantImageManager(new EfPlantImageDal());
            _plantDal = plantDal;
        }

        public IDataResult<Plant> GetById(string PlantId)
        {
            return new ResponseDataResult<Plant>(_plantDal.Get(p => p.Id == Guid.Parse(PlantId)));
        }

        public IDataResult<List<Plant>> GetList()
        {
            return new ResponseDataResult<List<Plant>>(_plantDal.GetList().ToList());
        }

        public IResult Add(Plant Plant)
        {
            return new ResponseResult(_plantDal.Add(Plant));
        }

        public IResult Delete(Plant plant)
        {
            var backupData = plant;
            _plantDal.Delete(plant);
            if (backupData.PlantImageId != null)
            {
                var result = _plantImageService.GetById(backupData.PlantImageId.ToString());
                if (result != null)
                    _plantImageService.Delete(result.Data);
            }
            return new ResponseResult(true);

        }

        public IResult Update(Plant Plant)
        {
            return new ResponseResult(_plantDal.Update(Plant));
        }
    }
}
