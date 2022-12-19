using Models;

namespace ShopMVC.Service
{
    public interface IItemService
    {
        Task<IEnumerable<ItemModel>> Find();
        void Delete(int id);
    }
}
