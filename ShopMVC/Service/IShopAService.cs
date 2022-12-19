using Models;

namespace ShopMVC.Service
{
    public interface IShopAService
    {
        Task<IEnumerable<ShopA>> Find();
    }
}
