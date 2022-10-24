using DockerTestApp.Extensions;
using DockerTestApp.Models;

namespace DockerTestApp.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }


        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            var response = await _client.GetAsync("Product/GetProducts");
            return await response.ReadContentAs<List<ProductModel>>();
        }
    }
}
