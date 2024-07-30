using System.Diagnostics;
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
        private readonly IAddressService _addressService;

        public ShopService(IShopRepository shopRepository, IAddressService addressService)
        {
            _shopRepository = shopRepository;
            _addressService = addressService;
        }

        public async Task<List<Shop>> GetAllShops()
        {
            var shops = _shopRepository.GetAllShops();
            return await shops.ToListAsync();
        }

        public async Task<List<Shop>> GetShopsByUserId(string userId) {
            var shops = _shopRepository.GetAllShops();
            var userShops = shops.Where(u => u.OwnerId == userId);
            return await userShops.ToListAsync();
        }

        public async Task<Shop> AddNewShop(string userId, ShopReqDto shopReqDto)
        {
            try
            {
                var address = await _addressService.CreateAddress(shopReqDto.Address);

                Shop shop = new Shop
                {
                    BankAccountNumber = shopReqDto.BankAccountNumber,
                    CompanyName = shopReqDto.CompanyName,
                    PhoneNumber = shopReqDto.PhoneNumber,
                    VatNumber = shopReqDto.VatNumber,
                    Email = shopReqDto.Email,
                    AddressId = address.Id,
                    OwnerId = userId,
                    ShopStateId = 2,
                };

                await _shopRepository.AddShopAsync(shop);

                return shop;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
