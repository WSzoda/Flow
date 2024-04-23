using Flow.Contracts.Dtos.Shop;
using Flow.Infrastracture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Infrastracture.Repositories
{
    public interface IShopRepository
    {
        Task<IEnumerable<Shop>> GetShops();
        Task<Shop> GetShopWithId(long shopId);
        Task AddShop(AddShopDto shopDto);
    }
}
