using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ItemModel
    {
        //Primary Attributes
        [Required]
        [Key]
        [Display(Name = "ID")]
        public int ItemId { get; set; }

        [Required]
        [Display (Name = "Item")]
        public string ItemName { get; set; } = "";


        public string Description { get; set; } = "";

        public string ItemType { get; set;  } = "";


        //foreign attributes
        public ICollection<ProductModel> Products { get; set; } = default!;

        
    }
}