using EcommerceAPI.Models;
using EcommerceProject.Data;
using EcommerceProject.Helpers;
using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceProject.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly ECommerceDbContext _context;
        public const string BasePath = "/api/Products";

        public ProductService(HttpClient httpClient, ECommerceDbContext context)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _context = context;
        }
        public async Task<ServiceResponse<ProductViewModel>> GetProductItemsAsync(string searchString)
        {
            var httpResponse = await _httpClient.GetAsync(BasePath);

            var response = new ServiceResponse<ProductViewModel>();
            bool isNull = _context.ProductModel.IsNullOrEmpty();
            if (isNull) 
            { 
                response.Success = false;
                response.Message = "Context is empty";
                return response;
            }

            var products = from p in _context.ProductModel
                           select p;

            if(!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name!.Contains(searchString));
            }

            response.Data = new ProductViewModel
            {
                Products = await httpResponse.ReadContentAsync<List<Product>>()
            };
            return response;
        }
    }
}
