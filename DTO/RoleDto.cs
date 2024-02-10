using NewRealEstate.Models.Entities;

namespace NewRealEstate.DTO;

public class RoleDto
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string UserId { get; set; }
    public UserDto User { get; set; }
}