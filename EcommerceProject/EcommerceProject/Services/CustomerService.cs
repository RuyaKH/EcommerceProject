using EcommerceAPI.Models;
using EcommerceProject.Data;
using EcommerceProject.Helpers;
using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceProject.Services
{
    public class CustomerService : IService<Customer>
    {
        private readonly HttpClient _httpClient;
        public const string BasePath = "/api/Customers";

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<IEnumerable<Customer>> GetItemsAsync()
        {
            var httpResponse = await _httpClient.GetAsync(BasePath);

            return await httpResponse.ReadContentAsync<List<Customer>>();
        }
    }
}
