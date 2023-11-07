using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.Business.Concrete;
using MedicinalPlantApp.DataAccess.Concrete;
using MedicinalPlantApp.Entities;
using MedicinalPlantApp.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace MedicinalPlantApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        readonly IPlantService _plantService = new PlantManager(new EfPlantDal());
        readonly IPlantImageService _plantImageService = new PlantImageManager(new EfPlantImageDal());
        readonly IHostingEnvironment Environment;

        //GET: Plants
        [HttpGet]
        public IActionResult Index()
        {
            var result = _plantService.GetList();
            if (result.Success)
                return View(result.Data);
            return BadRequest(result.Message);
        }

        [HttpGet]
        public IActionResult ImageList()
        {
            var result = _plantImageService.GetList();
            if (result.Success)
                return View(result.Data);
            return BadRequest(result.Message);
        }
 

        [HttpPost]
        public IActionResult Add(PlantDto model)
        {
            if (model.Description != null && model.Name != null)
            {
                var plant = new Plant
                {
                    Name = model.Name,
                    Description = model.Description,
                    UpdatedDate = DateTime.Now,
                    Id = Guid.NewGuid()
                };
                _plantService.Add(plant);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(PlantDto model)
        {
            _plantService.Update(new Plant
            {
                Id = Guid.Parse(model.Id),
                UpdatedDate = DateTime.Now,
                Description = model.Description,
                Name = model.Name
            });
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(string id)
        {
            var result = _plantService.GetById(id);
            if (result.Success)
                return new JsonResult(result.Data);
            return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            var result = _plantService.GetById(id);
            if (result.Success)
                _plantService.Delete(result.Data);
            return RedirectToAction("Index");
        }
    }
}
