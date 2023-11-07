using MedicinalPlantApp.Core.Entities;

namespace MedicinalPlantApp.Entities
{
    public class Plant : IEntity
    {
        public Guid Id { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PlantImage? PlantImage { get; set; }
        public Guid? PlantImageId { get; set; }
    }
}
