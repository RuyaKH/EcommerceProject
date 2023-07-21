using EcommerceProject.Models;

namespace EcommerceProject.Data
{
    public class SeedData
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<CommerceDbContext>();

            if (context.ProductModel.Any())
            {
                context.ProductModel.RemoveRange(context.ProductModel);
                context.SaveChanges();
            }

            context.ProductModel.AddRange(
                new Product
                {
                    Name = "Beans",
                    Category = "Food",
                    QuantityInStock = 40,
                    Price = 2,
                    Description = "It's Beans"
                },
                new Product
                {
                    Name = "Tshirt",
                    Category = "Clothing",
                    QuantityInStock = 100,
                    Price = 15,
                    Description = "It's a Tshirt"
                },
                new Product
                {
                    Name = "Cap",
                    Category = "Clothing",
                    QuantityInStock = 16,
                    Price = 8,
                    Description = "It's a hat"
                }
                );

            context.SaveChanges();
        }

    }
}
