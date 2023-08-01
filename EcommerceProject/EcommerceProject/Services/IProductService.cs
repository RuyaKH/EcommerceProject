using EcommerceProject.Models;

namespace EcommerceProject.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> Find();
    }
}
