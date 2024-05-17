using Flow.Contracts.Dtos.Shop;
using Flow.Contracts.Interfaces;
using Flow.Infrastracture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Services.Services
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository;

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<List<ShopDto>> GetAllShops()
        {
            var shops = await _shopRepository.GetShopsAsync();
            return shops;
        }
    }
}
