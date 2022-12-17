using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

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


       
       //[JsonIgnore]
        public ProductFromShopAModel? productFromShopAModel { get; set; }

        //[JsonIgnore]
        public ProductFromShopBModel? productFromShopBModel { get; set; }
      
        
    }
}