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
            var shops =  _shopRepository.GetAllShops();
            return await shops.ToListAsync();
        }

        public async Task<Shop> AddNewShop(ShopReqDto shopReqDto)
        {
            // var address = await _addressService.CreateAddress(shopDto.Address);
            // Console.WriteLine(address);

            Shop shop = new Shop
            {
                Address = new Address(),
                Email = shopDto.Email,
                Name = shopDto.Name,
                AddressId = 1,
                PhoneNumber = shopDto.PhoneNumber,
                VatNumber = shopDto.VatNumber,
                BankAccountNumber = shopDto.BankAccountNumber
            };

            return shop;
        }
    }
}
