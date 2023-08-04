using EcommerceAPI.Models;
using EcommerceProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class BasketController : Controller
    {
        private readonly IService<Basket> _basketService;

        public BasketController(IService<Basket> basketService)
        {
            _basketService = basketService ?? throw new ArgumentNullException(nameof(basketService));
        }

        public async Task<IActionResult> Index()
        {
            var basket = await _basketService.GetItemsAsync();
            return View(basket);
        }
    }
}
