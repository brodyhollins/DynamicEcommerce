using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicEcommerce.Data
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetByCategory(int id);
        IEnumerable<Product> GetWithQuery(string query);
        Product GetById(int id);
    }
}
