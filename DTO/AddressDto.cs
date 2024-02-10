namespace NewRealEstate.DTO;

public class AddressDto
{
    public string Id { get; set; }
    public string? Number { get; set; }
    public string? Street { get; set; }
    public string? LgArea { get; set; }
    public string? State { get; set; }
}

public class AddressRequestModel
{
   
    public string? Number { get; set; }
    public string? Street { get; set; }
    public string? LgArea { get; set; }
    public string? State { get; set; }
}