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

        public Shop AddNewShop(ShopDto shopDto)
        {
            var address = _addressService.CreateAddress(shopDto.Address);

            var shop = new Shop
            {
                Address = address,
                AddressId = address.Id,
                Email = shopDto.Email,
                OwnerId = shopDto.OwnerId,
                Name = shopDto.Name,
                VatNumber = shopDto.VatNumber,
                ShopStateId = 0,
                PhoneNumber = shopDto.PhoneNumber,
                BankAccountNumber = shopDto.BankAccountNumber
            };

            return shop;
        }
    }
}
