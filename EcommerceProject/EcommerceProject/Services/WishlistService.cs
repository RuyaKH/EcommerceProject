using EcommerceAPI.Models;
using EcommerceProject.Data;
using EcommerceProject.Helpers;
using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceProject.Services
{
    public class WishlistService : IService<Wishlist>
    {
        private readonly HttpClient _httpClient;
        public const string BasePath = "/api/Wishlist";

        public WishlistService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Wishlist>> GetItemsAsync()
        {
            var httpResponse = await _httpClient.GetAsync(BasePath);

            return await httpResponse.ReadContentAsync<List<Wishlist>>();
        }
    }
}
