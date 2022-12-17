using Models;

namespace ShopViewClient.Services.IServices
{
    public interface IItemService
    {
        Task<IEnumerable<ItemModel>> Find();
    }
}
