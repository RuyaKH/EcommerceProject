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

        public async Task<IActionResult> ProductIndex()
        {
            var products = await _productService.GetProductItemsAsync();
            return View(products);
        }
    }
}
