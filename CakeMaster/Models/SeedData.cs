using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CakeMaster.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context =
            services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "10 inch Birthday Cake",
                    Description = "The prefect cake for any " +
                    "birthday party of any age. Ready to sever 15 people",
                    Category = "Cakes",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12 inch Cake",
                    Description = "A 12 inche Cake ready to serve 20 people",
                    Category = "Cakes",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Cakes",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray Cake",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Cakes",
                    Price = 115.95m
                });
                context.SaveChanges();
            }
        }
    }
}