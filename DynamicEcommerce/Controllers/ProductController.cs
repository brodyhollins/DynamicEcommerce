using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Data.Models;
using DynamicEcommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var equipmentCategory = new Category()
            {
                Id = 1,
                Name = "Equipment"
            };

            var apparelCategory = new Category()
            {
                Id = 2,
                Name = "Apparel"
            };

            var productList = new List<Product>() 
            { 
                new Product()
                {
                    Name = "White Gold Chalk",
                    Description = "Fine chalk for your climbing needs",
                    Price = 350,
                    Image = "https://cdn.shopify.com/s/files/1/3101/0910/products/BD-white-gold-chalk_1_1000x.jpg?v=1566922863",
                    Created = DateTime.Now,
                    Category = equipmentCategory,
                },
                new Product()
                {
                    Name = "Madrock Shoes",
                    Description = "Perfect shoes for beginners",
                    Price = 1000,
                    Image = "https://cdn.shopify.com/s/files/1/3101/0910/products/Drone_HV_1000x.jpg?v=1566927275",
                    Created = DateTime.Now,
                    Category = equipmentCategory,
                },
                new Product()
                {
                    Name = "Rugne Shirt",
                    Description = "Clean design",
                    Price = 400,
                    Image = "https://cdn.shopify.com/s/files/1/0253/6711/7908/products/DSC08437_750x.jpg?v=1613771876",
                    Created = DateTime.Now,
                    Category = apparelCategory,
                },
            };

            var model = new ProductIndexModel()
            {
                Products = productList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}
