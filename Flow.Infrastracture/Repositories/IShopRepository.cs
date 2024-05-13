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
        Task<List<Shop>> GetShopsAsync();
        Task<Shop> GetShopWithIdAsync(long shopId);
        Task AddShopAsync(Shop shopDto);
        Task DeleteShopAsync(long shopId);
        Task UpdateShopAsync(Shop shopDto);
    }
}
