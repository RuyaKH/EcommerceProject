using EcommerceAPI.Models;
using EcommerceProject.Models;

namespace EcommerceProject.Services
{
    public interface IProductService
    {
        Task<ServiceResponse<ProductViewModel>> GetProductItemsAsync(string searchString);

    }
}
