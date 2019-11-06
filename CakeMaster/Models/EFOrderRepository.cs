using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMaster.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        public EFOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            else
            {
                Order dbEntry = context.Orders
                .FirstOrDefault(o => o.OrderID == order.OrderID);
                if (dbEntry != null)
                {
                    dbEntry.Name = order.Name;
                    dbEntry.Phone = order.Phone;
                    dbEntry.CarryOut = order.CarryOut;
                    dbEntry.CarryOutDate = order.CarryOutDate;

                    dbEntry.Delivery = order.Delivery;
                    dbEntry.DeliveryDate = order.DeliveryDate;
                    dbEntry.Line1 = order.Line1;
                    dbEntry.Line2 = order.Line2;
                    dbEntry.Line3 = order.Line3;
                    dbEntry.City = order.City;
                    dbEntry.State = order.State;
                    dbEntry.Zip = order.Zip;
                    dbEntry.Country = order.Country;

                    dbEntry.Shipped = order.Shipped;
                    dbEntry.Status = order.Status;
                }
            }
            context.SaveChanges();
        }
        public void AdminSaveOrder(Order order)
        {
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            else
            {
                Order dbEntry = context.Orders
                .FirstOrDefault(o => o.OrderID == order.OrderID);
                if (dbEntry != null)
                {

                    dbEntry.Name = order.Name;
                    dbEntry.Phone = order.Phone;
                    dbEntry.CarryOut = order.CarryOut;
                    dbEntry.CarryOutDate = order.CarryOutDate;

                    dbEntry.Delivery = order.Delivery;
                    dbEntry.DeliveryDate = order.DeliveryDate;
                    dbEntry.Line1 = order.Line1;
                    dbEntry.Line2 = order.Line2;
                    dbEntry.Line3 = order.Line3;
                    dbEntry.City = order.City;
                    dbEntry.State = order.State;
                    dbEntry.Zip = order.Zip;
                    dbEntry.Country = order.Country;

                    dbEntry.Shipped = order.Shipped;
                    dbEntry.Status = order.Status;

                }
            }
            context.SaveChanges();
        }
    }
}