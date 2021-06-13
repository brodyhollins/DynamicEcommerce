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

        public ProductController(IProduct _productService)
        {
            productService = _productService;
        }

        public IActionResult Index()
        {
            var productList = productService.GetAll();
            var model = new ProductIndexModel()
            {
                Products = productList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}
