using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository.Repository
{
    public interface IShopRepo
    {
        public IEnumerable<ItemModel> GetItemModels();
        void CreateItem(ItemModel item);
        void UpdateItem(int id, ItemModel item);
        void DeleteItem(int id);

        public ItemModel GetByID(int id);
    }
}
