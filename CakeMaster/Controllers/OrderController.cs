using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CakeMaster.Models;
using Microsoft.AspNetCore.Authorization;

namespace CakeMaster.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        //The Controllers for ordering CarryOut and Delivery Orders
        public ViewResult PlaceOrder() => View(new Order());
        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(OrderPlaced));
            }
            else
            {
                return View(order);
            }
        }
        public ViewResult PlaceCarryOutOrder() => View(new Order());
        [HttpPost]
        public IActionResult PlaceCarryOutOrder(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Add products to place your order.");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(OrderPlaced));
            }
            else
            {
                return View(order);
            }
        }
        public ViewResult PlaceDeliveryOrder() => View(new Order());
        [HttpPost]
        public IActionResult PlaceDeliveryOrder(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Add products to place your order.");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(OrderPlaced));
            }
            else
            {
                return View(order);
            }
        }

        public ViewResult OrderPlaced()
        {
            cart.Clear();
            return View();
        }

        //Customer/Order View
        public ViewResult CustomerOrders() => View(repository.Orders.Where(o => !o.Shipped));


        //Admin/Order View
        public ViewResult EditOrder(int orderId) =>
            View(repository.Orders.FirstOrDefault(p => p.OrderID == orderId));
        [HttpPost]
        public IActionResult EditOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOrder(order);
                TempData["message"] = $"{order.Name} has been saved";
                return RedirectToAction("List");
            }
            else
            {
                // there is something wrong with the data values
                return View(order);
            }
        }

        [Authorize]
        public ViewResult List() => View(repository.Orders.Where(o => !o.Shipped));
        [Authorize]
        public ViewResult DeliveryInfo() => View(repository.Orders.Where(o => !o.Shipped));

        [HttpPost]
        [Authorize]
        public IActionResult MarkCompleted(int orderID)
        {
            Order order = repository.Orders
            .FirstOrDefault(o => o.OrderID == orderID);
            if (order != null)
            {
                order.Shipped = true;
                repository.SaveOrder(order);
            }
            return RedirectToAction(nameof(List));
        }
    }
}