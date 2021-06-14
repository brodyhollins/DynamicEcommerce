using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicEcommerce.Data
{
    public interface ICategory
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
    }
}
