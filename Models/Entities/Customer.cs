namespace NewRealEstate.Models.Entities;

public class Customer : Auditable
{
    public string? TagNumber { get; set; }
    public double  Wallet { get; set; }
    public string? UserId { get; set; }
    public User User { get; set; }
    public string OrderId { get; set; }
    public Order Order { get; set; }

}