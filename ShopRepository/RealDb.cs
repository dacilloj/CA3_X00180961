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

        public void DeleteItem(int id, ItemModel item)
        {
            _db.ItemModel.Remove(item);
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

        
    }
}