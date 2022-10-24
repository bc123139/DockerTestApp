using DockerTestApi.Dtos;

namespace DockerTestApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
