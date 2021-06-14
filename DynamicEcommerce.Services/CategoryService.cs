using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicEcommerce.Services
{
    public class CategoryService : ICategory
    {
        private readonly DynamicEcommerceDbContext context;
        public CategoryService(DynamicEcommerceDbContext _context)
        {
            context = _context;
        }
        public IEnumerable<Category> GetAll()
        {
            return context.Categories;
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);
        }
    }
}
