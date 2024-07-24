using Flow.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flow.Core.DTOs.Request.Shop;


namespace Flow.Core.Interfaces.Services
{
    public interface IShopService
    {
        Task<List<Shop>> GetAllShops();

        Task<Shop> AddNewShop(ShopReqDto shopReqDto);
    }
}
