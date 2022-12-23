using API.DtoModels;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class CoffeeShopRepository : ICoffeeShopRepository
    {
        private readonly ApplicationDbContext _DbContext;

        public CoffeeShopRepository(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<List<CoffeeShopDto>> CoffeeShopListAsync()
        {
            var coffeeShops = await (from shop in _DbContext.CoffeeShops
                                     select new CoffeeShopDto()
                                     {
                                         Id = shop.Id,
                                         Address = shop.Address,
                                         Name = shop.Name,
                                         OpeningHours = shop.OpeningHours
                                     }).ToListAsync();
            return coffeeShops;
        }
    }
}
