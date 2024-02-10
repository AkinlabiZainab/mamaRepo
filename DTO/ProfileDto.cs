using NewRealEstate.Models.Entities;
using NewRealEstate.Models.Enum;

namespace NewRealEstate.DTO;

public class ProfileDto
{
    public string Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public int Age { get; set; }
    public Gender Sex { get; set; }
    public Address Address { get; set; }
    
}

public class ProfileRequestModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public int Age { get; set; }
    public Gender Sex { get; set; }
    public AddressRequestModel Address { get; set; }
}