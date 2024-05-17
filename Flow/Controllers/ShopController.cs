using Flow.Core.DTOs.Request.Shop;
using Flow.Core.DTOs.Response;
using Flow.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Flow.Controllers
{
    [ApiController]
    [Route("shops")]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetShops()
        {
            var shops = await _shopService.GetAllShops();
            return Ok(new ApiResponse {IsSuccessful = true, Data = shops});
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> AddShop([FromBody] ShopDto shopDto)
        {
            try
            {
                var response = await _shopService.AddNewShop(shopDto);
                return Ok(new ApiResponse { IsSuccessful = true, Data = response});
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse {IsSuccessful = false, Data = ex.Message});
            }
        }
    }
}
