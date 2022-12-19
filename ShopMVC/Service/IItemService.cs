using Models;

namespace ShopMVC.Service
{
    public interface IItemService
    {
        Task<IEnumerable<ItemModel>> Find();
    }
}
