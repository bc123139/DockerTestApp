using DockerTestApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DockerTestApi.Data
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
