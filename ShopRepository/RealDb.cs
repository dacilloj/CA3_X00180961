using CA3_X00180961.ShopRepository;
using Microsoft.EntityFrameworkCore;
using Models;
using ShopRepository.Repository;
using System.Net;

namespace ShopRepository
{
    public class RealDb : IShopRepo
    {
        CA3_X00180961Context _db;

        public RealDb(CA3_X00180961Context db)
        {
            _db = db;
        }

        public void CreateItem(ItemModel item)
        {
            _db.ItemModel.Add(item);
            _db.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var to_delete = _db.ItemModel.FirstOrDefault( x => x.ItemId == id);  
            _db.ItemModel.Remove(to_delete);
            _db.SaveChanges();

        }

        public ItemModel? GetItemByID(int id)
        {
            var ret = _db.ItemModel.FirstOrDefault(x => x.ItemId== id);
            return ret;
        }

        public IEnumerable<ItemModel> GetItemModels()
        {
            var ret = _db.ItemModel.Include(nameof(ItemModel.productFromShopAModel)) //caused a cycle
                                          .Include(nameof(ItemModel.productFromShopBModel));
            return ret;
        }

        public void UpdateItem(int id, ItemModel item)
        {
           
            _db.Entry(item).State = EntityState.Modified;
            
        }

        //Shop A
        public IEnumerable<ShopA> GetProductModelsFromA()
        {
            return _db.ProductFromShopAModel.Include(nameof(Models.ShopA.Item)) //caused a cyle
                                                .Include(nameof(Models.ShopA.Shop));
                                  
        }
        public void CreateProductA(ShopA item)
        {
            _db.ProductFromShopAModel.Add(item);
            _db.SaveChanges();
        }
       

        public void UpdateProductA(int id, ShopA product)
        {
            _db.Entry(product).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //shop b
        public void CreateProductB(ShopB item)
        {
            _db.ProductFromShopBModel.Add(item);
            _db.SaveChanges();
        }

        public void UpdateProductB(int id, ShopB product)
        {
            _db.Entry(product).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public IEnumerable<ShopB> GetProductModelsFromB()
        {
            return _db.ProductFromShopBModel.Include(nameof(Models.ShopB.Item)) //caused a cyle
                                                .Include(nameof(Models.ShopB.Shop));
                                
        }

        public ShopB? GetShopBByID(int id)
        {
            var ret = _db.ProductFromShopBModel.FirstOrDefault(x => x.ProductId == id);
            return ret;
        }

        public IEnumerable<ShopModel> GetShopModels()
        {
            return _db.ShopModel;
        }

        public void CreateShop(ShopModel item)
        {
            _db.ShopModel.Add(item);
            _db.SaveChanges();
        }
    }
}