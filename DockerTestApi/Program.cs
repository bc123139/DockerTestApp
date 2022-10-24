using DockerTestApi.Data;
using DockerTestApi.Extensions;

namespace DockerTestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
               .Build()
               .MigrateDatabase<ProductContext>((context, services) =>
               {
                   ProductContextSeed
                       .SeedAsync(context)
                       .Wait();
               })
               .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}