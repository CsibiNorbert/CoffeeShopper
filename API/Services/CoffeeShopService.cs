using API.DtoModels;
using API.Repositories;
using DataAccess.Data;

namespace API.Services
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ICoffeeShopRepository _coffeeShopRepo;

        public CoffeeShopService(ICoffeeShopRepository coffeeShopRepo)
        {
            _coffeeShopRepo = coffeeShopRepo;
        }

        public async Task<List<CoffeeShopDto>> CoffeeShopListAsync()
        {
            return await _coffeeShopRepo.CoffeeShopListAsync();
        }
    }
}
