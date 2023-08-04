using EcommerceAPI.Models;
using EcommerceProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IService<Customer> _customerService;

        public CustomerController(IService<Customer> customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _customerService.GetItemsAsync();
            return View(customer);
        }
    }
}
