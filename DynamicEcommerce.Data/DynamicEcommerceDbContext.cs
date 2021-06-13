using DynamicEcommerce.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DynamicEcommerce.Data
{
    public class DynamicEcommerceDbContext : DbContext
    {
        public DynamicEcommerceDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
