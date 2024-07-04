using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Core.Entities
{
    public class Shop
    {
        public long Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string VatNumber {  get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string BankAccountNumber { get; set; } = string.Empty;
        
        [ForeignKey("Address")]
        public long AddressId { get; set; }
        public Address Address { get; set; } = null!;
        
        [ForeignKey(("ShopState"))]
        public long ShopStateId { get; set; }
        public ShopState ShopState { get; set; } = null!;

        [ForeignKey("Owner")] public string OwnerId { get; set; } = string.Empty;
        public IdentityUser Owner { get; set; } = null!;
        
        public List<IdentityUser> Workers { get; set; } = new List<IdentityUser>();
    }
}
