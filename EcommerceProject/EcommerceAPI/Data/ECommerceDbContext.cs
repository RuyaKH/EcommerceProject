using EcommerceAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Data
{
    public class ECommerceDbContext : IdentityDbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Basket> BasketModel { get; set; }
        public DbSet<CartItem> CartItemModel { get; set; }
        public DbSet<Customer> CustomerModel { get; set; }
        public DbSet<Product> ProductModel { get; set; }
        public DbSet<Wishlist> WishlistModel { get; set; }


    }
}