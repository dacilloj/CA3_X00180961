using Models;
using ShopMVC.Helpers;

namespace ShopMVC.Service
{
    public class ShopAService : IShopAService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/ShopA/All";

        public ShopAService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ShopA>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<ShopA>>();
        }
    }
}
