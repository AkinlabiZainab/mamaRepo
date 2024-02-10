namespace NewRealEstate.Models.Entities;

public class Address : Auditable
{
    public string? Number { get; set; }
    public string? Street { get; set; }
    public string? LgArea { get; set; }
    public string? State { get; set; }
}