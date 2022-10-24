using AutoMapper;
using DockerTestApi.Dtos;
using DockerTestApi.Entities;

namespace DockerTestApi.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
