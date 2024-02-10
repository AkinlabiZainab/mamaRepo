using NewRealEstate.Models.Entities;
using NewRealEstate.Models.Enum;

namespace NewRealEstate.DTO;

public class UserDto
{
    
    public string Id { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public int Age { get; set; }
    public Gender Sex { get; set; }
    public string? Number { get; set; }
    public string? Street { get; set; }
    public string? LgArea { get; set; }
    public string? State { get; set; }
    public string? RoleName { get; set; }
    public string? RoleDescription { get; set; }

}

public class UserRequestModel
{
   
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    public ProfileRequestModel Profile { get; set; }
    public string? RoleName { get; set; }
    public string? RoleDescription { get; set; }
}

