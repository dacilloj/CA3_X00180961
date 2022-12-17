﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    public class ItemModel
    {
        //Primary Attributes
        [Required]
        [Key]
        [Display(Name = "ID")]
        [JsonIgnore]
        public int ItemId { get; set; }

        [Required]
        [Display (Name = "Name")]
        public string ItemName { get; set; } = "";


        public string Description { get; set; } = "";

        public string ItemType { get; set;  } = "";


        //foreign attributes. Don't think I need this
        //[InverseProperty("ProductFromShopAModel")]
        
       public  virtual ProductFromShopAModel? ProductsA { get; set; }

        public virtual ProductFromShopBModel? ProductsB { get; set; } 

        
    }
}