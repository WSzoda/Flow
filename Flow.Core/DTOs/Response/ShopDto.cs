namespace Flow.Core.DTOs.Response;

public class ShopDto
{
    public long Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
    public string Latitude { get; set; } = string.Empty;
}