using Flow.Core.DTOs.Request.Shop;
using Flow.Core.Entities;
using Flow.Core.Interfaces.Repositories;
using Flow.Core.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Flow.Application.Services
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository;

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<List<Shop>> GetAllShops()
        {
            var shops =  _shopRepository.GetAllShops();
            return await shops.ToListAsync();
        }

        public Task<Shop> AddNewShop(ShopDto shopDto)
        {
            throw new NotImplementedException();
        }
    }
}
