using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using DynamicEcommerce.Models.ApplicationUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IApplicationUser userService;
        private readonly IOrder orderService;

        public ProfileController(UserManager<ApplicationUser> _userManager, IApplicationUser _userService, SignInManager<ApplicationUser> _signInManager, IOrder _orderService)
        {
            userManager = _userManager;
            userService = _userService;
            orderService = _orderService;
            signInManager = _signInManager;
        }

        [Authorize(Roles = "Admin, Employee")]
        //[Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            var userList = userService.GetAll()
                .Select(u => new ProfileModel 
                {
                    UserId = u.Id,
                    Email = u.Email,
                    Username = u.UserName
                });
            var model = new ProfileIndexModel()
            {
                Users = userList
            };

            return View(model);
        }

        public IActionResult Detail(string id)
        {
            var user = userService.GetById(id);
            var userRoles = userManager.GetRolesAsync(user).Result;

            var orders = orderService.GetByUser(id);

            ViewBag.Orders = orders;

            Debug.WriteLine(orders);

            var model = new ProfileModel()
            {
                UserId = user.Id,
                Username = user.UserName,
                Email = user.Email,
                IsEmployee = (userRoles.Contains("Admin") || userRoles.Contains("Employee"))
            };

            return View(model);
        }
    }
}
