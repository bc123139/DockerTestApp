using DockerTestApp.Models;
using DockerTestApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DockerTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        public IEnumerable<ProductModel> ProductList { get; set; } = new List<ProductModel>();

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public async Task<ActionResult<IEnumerable<ProductModel>>> Index()
        {
            ProductList = await _productService.GetProducts();
            return View(ProductList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}