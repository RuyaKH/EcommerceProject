using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }

        public IEnumerable<CartItem>? ProductList { get; set; }


    }
}
