using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flow.Contracts.Dtos.Shop;


namespace Flow.Contracts.Interfaces
{
    public interface IShopService
    {
        Task<IEnumerable<ShopDto>> GetAllShops();
    }
}
