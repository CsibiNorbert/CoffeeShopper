using API.DtoModels;

namespace API.Repositories
{
    public interface ICoffeeShopRepository
    {
        Task<List<CoffeeShopDto>> CoffeeShopListAsync();
    }
}
