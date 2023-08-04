using Microsoft.AspNetCore.Mvc;
using EcommerceProject.Services;
using EcommerceAPI.Models;

namespace EcommerceProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IService<Product> _productService;

        public ProductController(IService<Product> productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetItemsAsync();
            return View(products);
        }
    }
}
