using System.ComponentModel.DataAnnotations;

namespace Flow.Core.DTOs.Request.Addresses
{
    public class AddressDto
    {
        [Required]
        public string AddressLine1 { get; set; } = string.Empty;
        [Required]
        public string AddressLine2 { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string State { get; set; } = string.Empty;
        [Required]
        public string PostalCode { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; } = string.Empty;
    }
}
