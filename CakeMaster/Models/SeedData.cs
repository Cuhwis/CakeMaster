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
                    Name = "10Inch Cake - Mocha",
                    Description = "A 10 inch cake ready to sever 15 people",
                    Category = "Other",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Mocha",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Other",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Mocha",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Other",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray - Cake Mocha",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Other",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Chocolate",
                    Description = "Ready to sever 15 people",
                    Category = "Other",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Chocolate",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Other",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Chocolate",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Other",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray Cake - Chocolate",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Other",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Vanilla",
                    Description = "Ready to sever 15 people",
                    Category = "Other",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12Inch Cake - Vanilla",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Other",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Vanilla",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Other",
                },
                new Product
                {
                    Name = "Full Tray Cake - Vanilla",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Other",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Mocha",
                    Description = "A 10 inch cake ready to sever 15 people",
                    Category = "Graduation",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Mocha",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Graduation",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Mocha",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Graduation",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray - Cake Mocha",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Graduation",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Chocolate",
                    Description = "Ready to sever 15 people",
                    Category = "Graduation",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Chocolate",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Graduation",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Chocolate",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Graduation",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray Cake - Chocolate",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Graduation",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Vanilla",
                    Description = "Ready to sever 15 people",
                    Category = "Graduation",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12Inch Cake - Vanilla",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Graduation",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Vanilla",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Graduation",
                },
                new Product
                {
                    Name = "Full Tray Cake - Vanilla",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Graduation",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Mocha",
                    Description = "A 10 inch cake ready to sever 15 people",
                    Category = "Wedding",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Mocha",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Wedding",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Mocha",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Wedding",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray - Cake Mocha",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Wedding",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Chocolate",
                    Description = "Ready to sever 15 people",
                    Category = "Wedding",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Chocolate",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Wedding",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Chocolate",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Wedding",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray Cake - Chocolate",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Wedding",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Vanilla",
                    Description = "Ready to sever 15 people",
                    Category = "Wedding",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12Inch Cake - Vanilla",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Wedding",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Vanilla",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Wedding",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray Cake - Vanilla",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Wedding",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Mocha",
                    Description = "Ready to sever 15 people",
                    Category = "Birthday",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Mocha",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Birthday",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Mocha",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Birthday",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray - Mocha",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Birthday",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Chocolate",
                    Description = "Ready to sever 15 people",
                    Category = "Birthday",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12inch Cake - Chocolate",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Birthday",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Chocolate",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Birthday",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray Cake - Chocolate",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Birthday",
                    Price = 115.95m
                },
                new Product
                {
                    Name = "10Inch Cake - Vanilla",
                    Description = "The prefect cake for any " +
                    "birthday party of any age. Ready to sever 15 people",
                    Category = "Birthday",
                    Price = 39.95m
                },
                new Product
                {
                    Name = "12Inch Cake - Vanilla",
                    Description = "A 12 inch Cake ready to serve 20 people",
                    Category = "Birthday",
                    Price = 49.95m,
                },
                new Product
                {
                    Name = "Half Cake Tray - Vanilla",
                    Description = "A half tray of cake. Ready to serve 30 people.",
                    Category = "Birthday",
                    Price = 69.95m
                },
                new Product
                {
                    Name = "Full Tray Cake - Vanilla",
                    Description = "Full tray cake for those big parties. Ready to Serve 60 people",
                    Category = "Birthday",
                    Price = 115.95m
                });
                context.SaveChanges();
            }
        }
    }
}