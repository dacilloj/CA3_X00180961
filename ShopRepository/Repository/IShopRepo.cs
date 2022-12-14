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

        public ItemModel? GetItemByID(int id);

        //for products A
        public IEnumerable<ShopA> GetProductModelsFromA();
        void UpdateProductA(int id, ShopA product);

        void UpdateProductB(int id, ShopB product);
        void DeleteFromShopA(int id);
        public ShopA? GetProductAByID(int id);

        public void CreateProductA(ShopA item);
        //for products B
        public void CreateProductB(ShopB item);
        public IEnumerable<ShopB> GetProductModelsFromB();
        public ShopB? GetProductBByID(int id);

        //for shops
        public IEnumerable<ShopModel> GetShopModels();
        void CreateShop(ShopModel item);
        void DeleteFromShop(int id);


    }
}
