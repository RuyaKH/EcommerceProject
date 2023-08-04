using EcommerceAPI.Models;
using EcommerceProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class WishlistController : Controller
    {
        private readonly IService<Wishlist> _wishlistService;

        public WishlistController(IService<Wishlist> wishlistService)
        {
            _wishlistService = wishlistService ?? throw new ArgumentNullException(nameof(wishlistService));
        }

        public async Task<IActionResult> Index()
        {
            var wishlist = await _wishlistService.GetItemsAsync();
            return View(wishlist);
        }
    }
}
