using Core.Utilities.Results;
using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.Business.Concrete;
using MedicinalPlantApp.DataAccess.Concrete;
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
            return View();
        }
    }
}
