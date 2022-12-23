using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ICoffeeShopService _coffeeShopService;
        public CoffeeShopController(ICoffeeShopService coffeeShopService)
        {
            this._coffeeShopService = coffeeShopService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCoffeeShopList()
        {
            var coffeeShops = await _coffeeShopService.CoffeeShopListAsync();
            return Ok(coffeeShops);
        }
    }
}
