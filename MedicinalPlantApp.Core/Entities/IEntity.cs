namespace MedicinalPlantApp.Core.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
