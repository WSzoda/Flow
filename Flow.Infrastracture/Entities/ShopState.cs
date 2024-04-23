using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Infrastracture.Entities
{
    public class ShopState
    {
        public long Id { get; set; }
        public string StateName { get; set; } = string.Empty;
        public ICollection<Shop> Shops { get; } = new List<Shop>();
    }
}
