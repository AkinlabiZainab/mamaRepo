using NewRealEstate.Models.Enum;

namespace NewRealEstate.Models.Entities;

public class Profile : Auditable
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public int Age { get; set; }
    public Gender Sex { get; set; }
    public string AddressId { get; set; }
    public Address Address { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
}