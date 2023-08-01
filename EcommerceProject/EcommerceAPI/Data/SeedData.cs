using EcommerceAPI.Models;

namespace EcommerceProject.Data
{
    public class SeedData
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ECommerceDbContext>();

            if (context.ProductModel.Any() || context.CustomerModel.Any() || context.BasketModel.Any() || context.CartItemModel.Any() || context.WishlistModel.Any())
            {
                context.ProductModel.RemoveRange(context.ProductModel);
                context.CustomerModel.RemoveRange(context.CustomerModel);
                context.BasketModel.RemoveRange(context.BasketModel);
                context.CartItemModel.RemoveRange(context.CartItemModel);
                context.WishlistModel.RemoveRange(context.WishlistModel);
                context.SaveChanges();
            }

            var beans = new Product
            {
                Name = "Beans",
                Category = "Food",
                QuantityInStock = 40,
                Price = 2,
                Description = "It's Beans"
            };
            var tshirt = new Product
            {
                Name = "Tshirt",
                Category = "Clothing",
                QuantityInStock = 100,
                Price = 15,
                Description = "It's a Tshirt"
            };
            var cap = new Product
            {
                Name = "Cap",
                Category = "Clothing",
                QuantityInStock = 16,
                Price = 8,
                Description = "It's a hat"
            };
                
            context.ProductModel.AddRange(
                beans, tshirt, cap
                );

            var mrbean = new Customer
            {
                Name = "MrBean",
                Email = "mrbean@beans.com"
            };

            var basket = new Basket
            {
                Customer = mrbean,
                CustomerId = mrbean.Id
            };

            context.CartItemModel.AddRange(
                new CartItem
                {
                    Basket = basket,
                    BasketId = basket.Id,
                    Product = beans,
                    ProductId = beans.Id,
                    OrderQuantity = 100,
                    Wishlist = null
                }) ;
            context.SaveChanges();
        }

    }
}
