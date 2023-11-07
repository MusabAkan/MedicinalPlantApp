using Core.Utilities.Results;
using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.DataAccess.Abstract;
using MedicinalPlantApp.Entities;

namespace MedicinalPlantApp.Business.Concrete
{
    public class PlantImageManager : IPlantImageService
    {
        readonly IPlantImageDal _plantImageDal;

        public PlantImageManager(IPlantImageDal plantImageDal) => _plantImageDal = plantImageDal;
        public IDataResult<PlantImage> GetById(string PlantImageId)
        {
            return new ResponseDataResult<PlantImage>(_plantImageDal.Get(p => p.Id == Guid.Parse(PlantImageId)));
        }
        public IDataResult<List<PlantImage>> GetList()
        {
            return new ResponseDataResult<List<PlantImage>>(_plantImageDal.GetList().ToList());
        }
        public IResult Delete(PlantImage plantImage)
        {
            string pathCombine = Path.Combine(Directory.GetCurrentDirectory(), $@"wwwroot\{plantImage.Path}");
            if (File.Exists(pathCombine))
                File.Delete(pathCombine);
            return new ResponseResult(_plantImageDal.Delete(plantImage));
        }
    }
}
