using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flow.Core.Entities;

namespace Flow.Core.Interfaces.Repositories
{
    public interface IShopRepository
    {
        IQueryable<Shop> GetAllShops();
        Task<Shop> GetShopWithIdAsync(long shopId);
        Task AddShopAsync(Shop shopDto);
        Task DeleteShopAsync(long shopId);
        Task UpdateShopAsync(Shop shopDto);
    }
}
