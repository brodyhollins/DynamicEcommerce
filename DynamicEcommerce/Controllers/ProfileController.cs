using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IApplicationUser userService;

        public ProfileController(UserManager<ApplicationUser> _userManager, IApplicationUser _userService)
        {
            userManager = _userManager;
            userService = _userService;
        }

        public IActionResult Detail(string id)
        {


            return View();
        }
    }
}
