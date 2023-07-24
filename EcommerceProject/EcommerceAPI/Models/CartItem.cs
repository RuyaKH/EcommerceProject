using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Required.")]
        public Product Product { get; set; }

        [Range(0,99999, ErrorMessage = "Product quantity out of range.")]
        public int OrderQuantity { get; set; }
    }
}
