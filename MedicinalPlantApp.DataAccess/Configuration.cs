using Microsoft.Extensions.Configuration;

namespace MedicinalPlantApp.DataAccess
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MedicinalPlantApp.Web"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("DbContext");
            }
        }
    }
}