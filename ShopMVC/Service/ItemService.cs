using Models;
using ShopMVC.Helpers;

namespace ShopMVC.Service
{
    public class ItemService : IItemService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/Items";

        public ItemService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ItemModel>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<ItemModel>>();
        }
    }
}
