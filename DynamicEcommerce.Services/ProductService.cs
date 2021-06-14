using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicEcommerce.Services
{
    public class ProductService : IProduct
    {
        private readonly DynamicEcommerceDbContext context;
        public ProductService(DynamicEcommerceDbContext _context)
        {
            context = _context;
        }
        public IEnumerable<Product> GetAll()
        {
            return context.Products
                .Include(category => category.Category);
        }
        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetByCategory(int id)
        {
            return GetAll()
                .Where(
                category => category.Category.Id.Equals(id)
                );
        }

        public IEnumerable<Product> GetWithQuery(string query)
        {
            return context.Products
                .Include(category => category.Category)
                .Where(
                product => product.Name.Contains(query)
                );
        }
    }
}
