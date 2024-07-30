using System.ComponentModel.DataAnnotations;

namespace Flow.Core.DTOs.Response;

public class ShopDto
{
    public long Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public required AddressDto Address {get;set;}
}