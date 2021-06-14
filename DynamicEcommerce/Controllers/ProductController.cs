using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using DynamicEcommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct productService;
        private readonly ICategory categoryService;

        public ProductController(IProduct _productService, ICategory _categoryService)
        {
            productService = _productService;
            categoryService = _categoryService;
        }

        public IActionResult Index()
        {
            var productList = productService.GetAll();
            var model = new ProductIndexModel()
            {
                Products = productList,
                SearchQuery = ""
            };

            ViewBag.Categories = categoryService.GetAll();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var product = productService.GetById(id);

            var model = new ProductDetailModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image,
                Created = product.Created,
                Category = product.Category
            };

            return View(model);
        }
    }
}
