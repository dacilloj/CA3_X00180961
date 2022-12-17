using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace CA3_X00180961.ShopRepository
{
    public class CA3_X00180961Context : DbContext
    {
        public CA3_X00180961Context (DbContextOptions<CA3_X00180961Context> options)
            : base(options)
        {
        }

        public DbSet<Models.ProductFromShopAModel> ProductFromShopAModel { get; set; } = default!;

        public DbSet<Models.ItemModel> ItemModel { get; set; } = default!;

        public DbSet<Models.ProductFromShopBModel> ProductFromShopBModel { get; set; } = default!;


        public DbSet<Models.ShopModel> ShopModel { get; set; } = default!;


        //can use modelBuilder or data annotations to denote entity replationships

        
    }
}
