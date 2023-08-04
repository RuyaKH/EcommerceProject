using EcommerceAPI.Models;
using EcommerceProject.Data;
using EcommerceProject.Helpers;
using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceProject.Services
{
    public class BasketService : IService<Basket>
    {
        private readonly HttpClient _httpClient;
        public const string BasePath = "/api/Baskets";

        public BasketService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Basket>> GetItemsAsync()
        {
            var httpResponse = await _httpClient.GetAsync(BasePath);

            return await httpResponse.ReadContentAsync<List<Basket>>();
        }
    }
}
