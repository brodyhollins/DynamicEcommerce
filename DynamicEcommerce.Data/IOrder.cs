using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEcommerce.Data
{
    public interface IOrder
    {
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetByProductCategory(int id);
        IEnumerable<Order> GetByUser(string id);
        Order GetById(int id);
        Task Add(Order order);
    }
}
