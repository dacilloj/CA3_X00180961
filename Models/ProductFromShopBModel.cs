﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductFromShopBModel
    {
        [Required]
        [Key]
        public int ProductId { get; set; }

        [Required]
        public double ProductPrice { get; set; }

        //foreign relationships
        public int ShopID { get; set; } = 2

        [Required]
        public int? ItemID { get; set; }


        //may not need the below
        public ItemModel Item { get; set; } = default!;

        public ShopModel Shop { get; set; } = default!;

    }
}