using DockerTestApi.Dtos;
using DockerTestApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DockerTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet(nameof(GetProducts))]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var products =await  _productService.GetProducts();
            return Ok(products);
        }
    }
}
