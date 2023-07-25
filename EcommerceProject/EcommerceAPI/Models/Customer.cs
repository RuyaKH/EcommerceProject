using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is a required field.")]
        [StringLength(50)]
        public string Name { get; set; }

        public string Email { get; set; }



    }
}
