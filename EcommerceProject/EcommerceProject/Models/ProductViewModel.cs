using Microsoft.AspNetCore.Mvc.Rendering;
using EcommerceAPI.Models;
namespace EcommerceProject.Models
{
    public class ProductViewModel
    {
        public List<Product>? Products { get; set; }
        public string? SearchString { get; set; }
    }
}
