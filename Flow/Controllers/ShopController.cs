using System.Security.Claims;
using AutoMapper;
using Flow.Core.DTOs.Request.Shop;
using Flow.Core.DTOs.Response;
using Flow.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Flow.Controllers
{
    [Authorize]
    [ApiController]
    [Route("shops")]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;
        private readonly IMapper _mapper;

        public ShopController(IShopService shopService, IMapper mapper)
        {
            _shopService = shopService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetShops()
        {
            var shops = await _shopService.GetAllShops();
            return Ok(
                new ApiResponse { IsSuccessful = true, Data = _mapper.Map<List<ShopDto>>(shops) }
            );
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> AddShop([FromBody] ShopReqDto shopDto)
        {
            try
            {
                string id = HttpContext.User.FindFirstValue("Id")!;
                var response = await _shopService.AddNewShop(shopDto);
                return Ok(
                    new ApiResponse { IsSuccessful = true, Data = _mapper.Map<ShopDto>(response) }
                );
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse { IsSuccessful = false, Data = ex.Message });
            }
        }
    }
}
