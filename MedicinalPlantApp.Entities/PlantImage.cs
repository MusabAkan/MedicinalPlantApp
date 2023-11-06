using MedicinalPlantApp.Core.Entities;

namespace MedicinalPlantApp.Entities
{
    public class PlantImage : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
    }
}
