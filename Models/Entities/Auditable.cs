namespace NewRealEstate.Models.Entities;

public class Auditable
{
    public string? Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime DateCreated { get; set; }
    public bool IsDeleted { get; set; }
}