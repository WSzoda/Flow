using Flow.Contracts.Dtos.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Contracts.Dtos.Shop
{
    public class ShopDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string VatNumber { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string BankAccountNumber { get; set; } = string.Empty;
        public AddressDto Address { get; set; } = null!;
    }
}
