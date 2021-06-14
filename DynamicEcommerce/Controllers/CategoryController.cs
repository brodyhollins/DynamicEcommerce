using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Data;
using DynamicEcommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory categoryService;
        public CategoryController(ICategory _categoryService)
        {
            categoryService = _categoryService;
        }
        public IActionResult Index()
        {
            var categoryList = categoryService.GetAll();
            var model = new CategoryIndexModel()
            {
                Categories = categoryList
            };

            return View("CategoriesSidebarPartial", model);
        }
    }
}
