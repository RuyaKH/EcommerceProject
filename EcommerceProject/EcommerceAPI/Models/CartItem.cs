using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public Basket Basket { get; set; }

        [ForeignKey("Basket")]
        public int BasketId { get; set; }

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Required.")]
        public Product Product { get; set; }

        [Range(0,99999, ErrorMessage = "Product quantity out of range.")]
        public int OrderQuantity { get; set; }

        public int? WishlistId { get; set; }
        public Wishlist? Wishlist { get; set;}
    }
}
