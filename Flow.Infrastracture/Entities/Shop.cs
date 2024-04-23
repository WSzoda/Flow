using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Infrastracture.Entities
{
    public class Shop
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string VatNumber {  get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string BankAccountNumber { get; set; } = string.Empty;
        public Address? Address { get; set; }
    }
}
