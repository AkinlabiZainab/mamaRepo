using NewRealEstate.Models.Enum;

namespace NewRealEstate.Models.Entities;

public class LandedProperties : Auditable
{
    public string? Plots { get; set; }
    public string AddressId { get; set; }
    public Address Address { get; set; }
    public double Price { get; set; }
    public TransactionType Type { get; set; }

}