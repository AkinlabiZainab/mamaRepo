namespace NewRealEstate.Models.Entities;

public class Order : Auditable
{
    public string? Status { get; set; }
    public double MakePayment { get; set; }
    public string? ReceiptNumber { get; set; }
}