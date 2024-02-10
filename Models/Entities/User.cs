namespace NewRealEstate.Models.Entities;

public class User : Auditable
{
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    //public string ProfileID { get; set; }
    public Profile Profile { get; set; }
    public Role RoleId { get; set; }
    public Role Role { get; set; }
}