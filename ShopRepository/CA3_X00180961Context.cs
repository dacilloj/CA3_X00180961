using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace CA3_X00180961.ShopRepository
{
    public class CA3_X00180961Context : DbContext
    {
        public CA3_X00180961Context(DbContextOptions<CA3_X00180961Context> options)
            : base(options)
        {
        }

        public DbSet<Models.ShopA> ProductFromShopAModel { get; set; } = default!;

        public DbSet<Models.ItemModel> ItemModel { get; set; } = default!;

        public DbSet<Models.ShopB> ProductFromShopBModel { get; set; } = default!;


        public DbSet<Models.ShopModel> ShopModel { get; set; } = default!;


        //can use modelBuilder or data annotations to denote entity replationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemModel>()
                .HasOne(b => b.productFromShopAModel)
                .WithOne(i => i.Item)
                .HasForeignKey<ShopA>(b => b.ItemID);

            modelBuilder.Entity<ItemModel>()
                .HasOne(b => b.productFromShopBModel)
                .WithOne(i => i.Item)
                .HasForeignKey<ShopB>(b => b.ItemID);
        }
    }
}
