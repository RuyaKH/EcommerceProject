using EcommerceAPI.Models;
using EcommerceProject.Data;
using EcommerceProject.Helpers;
using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceProject.Services
{
    public class CartItemService : IService<CartItem>
    {
        private readonly HttpClient _httpClient;
        public const string BasePath = "/api/CartItems";

        public CartItemService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<CartItem>> GetItemsAsync()
        {
            var httpResponse = await _httpClient.GetAsync(BasePath);

            return await httpResponse.ReadContentAsync<List<CartItem>>();
        }
    }
}
