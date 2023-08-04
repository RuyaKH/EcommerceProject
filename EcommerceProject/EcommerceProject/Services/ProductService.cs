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
        public async Task<IEnumerable<Product>> GetProductItemsAsync()
        {
            var httpResponse = await _httpClient.GetAsync(BasePath);

            return await httpResponse.ReadContentAsync<List<Product>>();
        }
    }
}
