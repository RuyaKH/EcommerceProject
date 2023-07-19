using EcommerceProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Data
{
    public class CommerceDbContext : IdentityDbContext
    {
        public CommerceDbContext(DbContextOptions<CommerceDbContext> options)
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