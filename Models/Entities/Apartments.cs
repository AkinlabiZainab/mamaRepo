using NewRealEstate.Models.Enum;

namespace NewRealEstate.Models.Entities;

public class Apartments : Auditable
{
    public double Size { get; set; }
    public string? Colour { get; set; }
    public double Price { get; set; }
    public string? AddressId { get; set; }
    public Address Address { get; set; }
    public string? Image { get; set; }
    public TransactionType Type { get; set; }
}