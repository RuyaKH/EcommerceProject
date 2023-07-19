using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }

        public List<CartItem> ProductList { get; set; }


    }
}
