using System.ComponentModel.DataAnnotations;
using Flow.Core.DTOs.Request.Addresses;

namespace Flow.Core.DTOs.Request.Shop
{
    public class ShopReqDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string VatNumber { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string BankAccountNumber { get; set; } = string.Empty;
        [Required]
        public AddressDto Address { get; set; } = null!;
        [Required]
        public long OwnerId { get; set; }
    }
}
