using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CakeMaster.Models;
using Microsoft.AspNetCore.Authorization;

namespace CakeMaster.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository repository;
        //private IOrderRepository orderRepository;
        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View();
        public ViewResult AllProducts() => View(repository.Products);
        public ViewResult EditProduct(int productId) => 
            View(repository.Products.FirstOrDefault(p => p.ProductID == productId));
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction("AllProducts");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }
        public ViewResult CreateProduct() => View("EditProduct", new Product());
        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return RedirectToAction("AllProducts");
        }
        [HttpPost]
        public IActionResult SeedDatabase()
        {
            SeedData.EnsurePopulated(HttpContext.RequestServices);
            return RedirectToAction(nameof(AllProducts));
        }
    }

}