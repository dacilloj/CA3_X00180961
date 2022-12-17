using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository.Repository
{
    //non generic at the moment. need to become generic
    public interface IShopRepo
    {
        //for Items
        public IEnumerable<ItemModel> GetItemModels();
        void CreateItem(ItemModel item);
        void UpdateItem(int id, ItemModel item);
        void DeleteItem(int id);

        public ItemModel GetByID(int id);

        //for products
        void UpdateProductA(int id, ProductFromShopAModel product);

        void UpdateProduct(int id, ProductFromShopBModel product);   

    }
}
