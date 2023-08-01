using EcommerceAPI.Models;

namespace EcommerceAPI.Endpoints
{
    public class LocationEndpointsConfig
    {
        public static void AddEndPoints(WebApplication app)
        {

            app.MapGet("api/find", () =>
            {
                var rng = new Random();
                var product = Enumerable.Range(1,3).Select(index => new Product
                {
                    Name = "Mugs",
                    Category = "Cermaics",
                    QuantityInStock = rng.Next(0,999),
                    Price = 7,
                    Description = "A mr bean mug!"

                }).ToArray();

                return Results.Ok(product);
            });
        }
    }
}
