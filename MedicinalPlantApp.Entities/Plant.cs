using MedicinalPlantApp.Core.Entities;

namespace MedicinalPlantApp.Entities
{
    public class Plant : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Complaint Complaint { get; set; }
        public Guid ComplaintId { get; set; }
        public Image? Image { get; set; }
        public Guid? ImageId { get; set; }
      
    }
}
