namespace NewRealEstate.Models.Entities;

public class Manager : Auditable
{
    public string? ManagerId { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
}