using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Category Required")]
        public string Category { get; set; }

        [Range(0,99999)]
        public int QuantityInStock { get; set; }

        [Range(0,Double.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string ImageUrl { get; set; }
    }
}
