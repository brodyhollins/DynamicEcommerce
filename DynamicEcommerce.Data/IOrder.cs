using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicEcommerce.Data
{
    public interface IOrder
    {
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetByProductCategory(int id);
        IEnumerable<Order> GetByUser(int id);
        Order GetById(int id);
    }
}
