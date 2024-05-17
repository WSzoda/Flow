using Flow.Services.Services;
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
        public async Task<IActionResult> GetShops()
        {
            var shops = await _shopService.GetAllShops();
            return Ok();
        }
    }
}
