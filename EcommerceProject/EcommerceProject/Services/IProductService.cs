using EcommerceAPI.Models;
using EcommerceProject.Models;

namespace EcommerceProject.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductItemsAsync();

    }
}
