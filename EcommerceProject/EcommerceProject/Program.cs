using EcommerceAPI.Models;
using EcommerceProject.Data;
using EcommerceProject.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EcommerceProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ECommerceDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ECommerceDbContext>();
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpClient<IService<Product>, ProductService>
                (c => c.BaseAddress = new Uri("https://localhost:7000/"));
            builder.Services.AddHttpClient<IService<CartItem>, CartItemService>
                (c => c.BaseAddress = new Uri("https://localhost:7000/"));
            builder.Services.AddHttpClient<IService<Basket>, BasketService>
                (c => c.BaseAddress = new Uri("https://localhost:7000/"));

            //builder.Services.AddControllers().AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error"); ;
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}