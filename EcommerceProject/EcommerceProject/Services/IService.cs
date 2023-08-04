using EcommerceAPI.Models;
using EcommerceProject.Models;

namespace EcommerceProject.Services
{
    public interface IService<T>
    {
        Task<IEnumerable<T>> GetItemsAsync();

    }
}
