using System.Security.Claims;
using AutoMapper;
using Flow.Core.DTOs.Request.Shop;
using Flow.Core.DTOs.Response;
using Flow.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Flow.Controllers
{
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
                string id = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)!;
                var response = await _shopService.AddNewShop(id, shopDto);
                return Ok(
                    new ApiResponse { IsSuccessful = true, Data = _mapper.Map<ShopDto>(response) }
                );
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse { IsSuccessful = false, Data = ex.Message });
            }
        }

        [HttpGet]
        [Route("user")]
        public async Task<ActionResult> GetShopsForLoggedUser() {
            try {
                string id = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)!;
                var response = await _shopService.GetShopsByUserId(id);

                return  Ok(
                    new ApiResponse{IsSuccessful = true, Data = _mapper.Map<List<ShopDto>>(response)}
                );
            } catch (Exception ex) {
                return BadRequest(new ApiResponse { IsSuccessful = false, Data = ex.Message });
            }
        }

        [HttpGet]
        [Route("user/{id}")]
        public async Task<ActionResult> GetShopsForUser(string id) {
            try {
                var response = await _shopService.GetShopsByUserId(id);

                return  Ok(
                    new ApiResponse{IsSuccessful = true, Data = _mapper.Map<List<ShopDto>>(response)}
                );
            } catch (Exception ex) {
                return BadRequest(new ApiResponse { IsSuccessful = false, Data = ex.Message });
            }
        }

    }
}
