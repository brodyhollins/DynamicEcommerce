using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProductIndexModel()
            {

            };
            return View(model);
        }
    }
}
