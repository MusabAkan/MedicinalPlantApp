using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.Business.Concrete;
using MedicinalPlantApp.DataAccess.Concrete;
using MedicinalPlantApp.Entities;
using MedicinalPlantApp.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicinalPlantApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        readonly IPlantService _plantService = new PlantManager(new EfPlantDal());

        //GET: Plants
        [HttpGet]
        public IActionResult Index()
        {
            var result = _plantService.GetList();
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
                    CreatedDate = DateTime.Now,
                    Id = Guid.NewGuid()
                };
                _plantService.Add(plant);
               
            }
            return RedirectToAction("Index");
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
