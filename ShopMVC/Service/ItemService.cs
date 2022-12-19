using Microsoft.AspNetCore.Mvc;
using Models;
using ShopMVC.Helpers;
using System.IO;

namespace ShopMVC.Service
{
    public class ItemService : IItemService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/Items/";

        public ItemService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ItemModel>> Find()
        {
            string path = BasePath + "All";
            var response = await _client.GetAsync(path);

            return await response.ReadContentAsync<List<ItemModel>>();
        }


        public void Delete(int id)
        {
            
            string path = BasePath + "Delete/";

            //HTTP DELETE
            var deleteTask = _client.DeleteAsync(path + id.ToString());

        }

        public  Task<IEnumerable<ItemModel>> CreateItem(ItemModel item)
        {
            string path = BasePath + "Create";
            var postItem = _client.PostAsJsonAsync<ItemModel>(path, item);
            return Find();
        }
    }
}
