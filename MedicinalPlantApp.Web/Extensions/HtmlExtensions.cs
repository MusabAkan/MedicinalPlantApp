using MedicinalPlantApp.Business.Abstract;
using MedicinalPlantApp.Business.Concrete;
using MedicinalPlantApp.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedicinalPlantApp.Web.Extensions;

public static class HtmlExtensions
{

    public static string GetPlantImagePath(this IHtmlHelper htmlHelper, string id)
    {
        string path = @"PlantImage\default.jpg";
        if (string.IsNullOrEmpty(id)) return path;
        IPlantImageService plantImageService = new PlantImageManager(new EfPlantImageDal());
        return plantImageService.GetById(id).Data.Path ?? path;
    }
    public static string GetPlantImageFileName(this IHtmlHelper htmlHelper, string id)
    {
        string fileName = "default";
        if (string.IsNullOrEmpty(id)) return fileName;
        IPlantImageService plantImageService = new PlantImageManager(new EfPlantImageDal());
        return plantImageService.GetById(id).Data.FileName ?? fileName;
    }
}