using MedicinalPlantApp.Core.Entities;

namespace MedicinalPlantApp.Entities
{
    public class Complaint : IEntity
    {
        public string Description { get; set; }
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
