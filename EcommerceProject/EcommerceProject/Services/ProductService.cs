using EcommerceProject.Helpers;
using EcommerceProject.Models;

namespace EcommerceProject.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public const string BasePath = "/api/find";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Product>> Find()
        {
            var response = await _httpClient.GetAsync(BasePath);

            return await response.ReadContentAsync<List<Product>>();
        }
    }
}
