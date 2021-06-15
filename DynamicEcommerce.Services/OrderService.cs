using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicEcommerce.Services
{
    public class OrderService : IOrder
    {
        private readonly DynamicEcommerceDbContext context;
        public OrderService(DynamicEcommerceDbContext _context)
        {
            context = _context;
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetByProductCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetByUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
