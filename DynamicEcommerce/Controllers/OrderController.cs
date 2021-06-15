using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using DynamicEcommerce.Models.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrder orderService;
        private readonly IProduct productService;
        private readonly ICategory categoryService;
        private readonly UserManager<ApplicationUser> userManager;

        public OrderController(UserManager<ApplicationUser> _userManager, IProduct _productService, IOrder _orderService, ICategory _categoryService)
        {
            productService = _productService;
            orderService = _orderService;
            userManager = _userManager;
            categoryService = _categoryService;
        }

        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Index()
        {
            var orderList = orderService.GetAll()
                .Select(x => new OrderDetailModel
                {
                    No = x.Id,
                    Product = x.Product,
                    UserId  = x.User.Id,
                    UserEmail =  x.User.Email,
                    Quantity = x.Quantity,
                    Total = x.Total,
                    Created = x.Created

                });

            var model = new OrderIndexModel()
            {
                Orders = orderList
            };

            ViewBag.Categories = categoryService.GetAll();
            ViewBag.Category = 0;

            return View(model);
        }

        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Category(int id)
        {
            var orderList = orderService.GetByProductCategory(id)
                .Select(x => new OrderDetailModel
                {
                    No = x.Id,
                    Product = x.Product,
                    UserId = x.User.Id,
                    UserEmail = x.User.Email,
                    Quantity = x.Quantity,
                    Total = x.Total,
                    Created = x.Created

                });

            var model = new OrderIndexModel()
            {
                Orders = orderList
            };

            ViewBag.Categories = categoryService.GetAll();
            ViewBag.Category = id;

            return View("Index", model);
        }

        [HttpPost]
        public async Task<IActionResult> Place(OrderModel model)
        {
            var userId = userManager.GetUserId(User);
            var user = userManager.FindByIdAsync(userId).Result;
            

            var order = BuildOrder(model, user);

            await orderService.Add(order);

            return RedirectToAction("Detail", "Profile", new { id = userId });
        }

        private Order BuildOrder(OrderModel model, ApplicationUser user)
        {
            var product = productService.GetById(model.ProductId);
            return new Order
            {
                Product = product,
                User = user,
                Total  = model.ProductPrice,
                Quantity = model.Quantity,
                Created = DateTime.Now,
            };
        }

        public IActionResult Create(int id)
        {
            var product = productService.GetById(id);

            var model = new OrderModel()
            {
                ProductId = product.Id,
                ProductName = product.Name,
                ProductPrice = product.Price,
                ProductImage = product.Image,
                Quantity = 1,
            };

            return View(model);
        }

    }
}
