using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Core.Entities
{
    public class ShopState
    {
        public long Id { get; set; }
        [MaxLength(256)]
        public string StateName { get; set; } = string.Empty;
        public ICollection<Shop> Shops { get; } = new List<Shop>();
    }
}
