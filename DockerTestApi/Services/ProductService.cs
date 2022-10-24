using AutoMapper;
using AutoMapper.QueryableExtensions;
using DockerTestApi.Data;
using DockerTestApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DockerTestApi.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _databaseContext;
        private readonly IMapper _mapper;

        public ProductService(ProductContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var products=await _databaseContext.Products.ProjectTo<ProductDto>(_mapper.ConfigurationProvider).ToListAsync();
            return products;
        }
    }
}
