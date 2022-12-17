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

        }

        public ItemModel? GetByID(int id)
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

        public void UpdateProduct(int id, ProductFromShopBModel product)
        {
           _db.Entry(product).State = EntityState.Modified;
        }

        public void UpdateProductA(int id, ProductFromShopAModel product)
        {
            throw new NotImplementedException();
        }
    }
}