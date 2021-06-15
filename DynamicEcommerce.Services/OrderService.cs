using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEcommerce.Services
{
    public class OrderService : IOrder
    {
        private readonly DynamicEcommerceDbContext context;
        public OrderService(DynamicEcommerceDbContext _context)
        {
            context = _context;
        }

        public async Task Add(Order order)
        {
            context.Add(order);
            await context.SaveChangesAsync();
        }

        public IEnumerable<Order> GetAll()
        {
            return context.Orders
                .Include(product => product.Product)
                .Include(user => user.User);
        }

        public Order GetById(int id)
        {
            return context.Orders.Find(id);
        }

        public IEnumerable<Order> GetByProductCategory(int id)
        {
            return GetAll()
                .Where(i => i.Product.Category.Id == id);
        }

        public IEnumerable<Order> GetByUser(string id)
        {
            return GetAll().Where(x => x.User.Id == id);
        }
    }
}
