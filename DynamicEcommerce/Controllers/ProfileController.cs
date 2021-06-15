using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using DynamicEcommerce.Models.ApplicationUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicEcommerce.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IApplicationUser userService;

        public ProfileController(UserManager<ApplicationUser> _userManager, IApplicationUser _userService, SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            userService = _userService;
            signInManager = _signInManager;
        }

        public IActionResult Detail(string id)
        {
            var user = userService.GetById(id);
            var userRoles = userManager.GetRolesAsync(user).Result;
            var model = new ProfileModel()
            {
                UserId = user.Id,
                Username = user.UserName,
                Email = user.Email,
                IsEmployee = userRoles.Contains("Employee")
            };

            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction(nameof(ProductController.Index), "Product");
        //}
    }
}
