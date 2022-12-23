using API.DtoModels;

namespace API.Services
{
    public interface ICoffeeShopService
    {
        Task<List<CoffeeShopDto>> CoffeeShopListAsync();
    }
}
