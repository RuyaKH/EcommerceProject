using Microsoft.AspNetCore.Mvc;
using EcommerceProject.Services;

namespace EcommerceProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProductIndex(string searchString)
        {
            var products = await _productService.GetProductItemsAsync(searchString);
            return View(products);
        }
    }
}
