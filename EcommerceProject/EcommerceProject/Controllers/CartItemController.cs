using EcommerceAPI.Models;
using EcommerceProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class CartItemController : Controller
    {
        private readonly IService<CartItem> _cartItemService;

        public CartItemController(IService<CartItem> cartItemService)
        {
            _cartItemService = cartItemService ?? throw new ArgumentNullException(nameof(cartItemService));
        }

        public async Task<IActionResult> Index()
        {
            var cartItems = await _cartItemService.GetItemsAsync();
            return View(cartItems);
        }
    }
}
