using DockerTestApp.Models;

namespace DockerTestApp.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetProducts();
    }
}
