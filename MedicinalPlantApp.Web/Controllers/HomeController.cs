using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.Business.Concrete;
using MedicinalPlantApp.DataAccess.Concrete;
using MedicinalPlantApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MedicinalPlantApp.Web.Controllers
{
    public class HomeController : Controller
    {
        readonly IPlantService _plantService = new PlantManager(new EfPlantDal());

        public IActionResult Index()
        {
            var result = _plantService.GetList();
            if (result.Success)
                return View(result.Data);
            return BadRequest(result.Message);          
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}