using DynamicEcommerce.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEcommerce.Data
{
    public class DataSeeder
    {
        private readonly DynamicEcommerceDbContext context;
        public DataSeeder(DynamicEcommerceDbContext _context)
        {
            context = _context;
        }
        //Creating an Admin so we always have an Admin lvl user on a fresh application
        public async Task SeedAdmin()
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            
            var user = new ApplicationUser
            {
                UserName = "admin@dynamic.com",
                NormalizedUserName = "ADMIN@DYNAMIC.COM",
                Email = "admin@dynamic.com",
                NormalizedEmail = "ADMIN@DYNAMIC.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var passwordHashed = passwordHasher.HashPassword(user, "Dynam1c1337*");
            user.PasswordHash = passwordHashed;

            var roleStore = new RoleStore<IdentityRole>(context);
            var userStore = new UserStore<ApplicationUser>(context);

            var hasAdminRole = context.Roles.Any(roles => roles.Name == "Admin");

            if (!hasAdminRole)
            {
                await roleStore.
                    CreateAsync(new IdentityRole {Name="Admin", NormalizedName="admin"});
            }

            var hasAdminUser = context.Users.Any(x => x.UserName == user.UserName);
            if (!hasAdminUser)
            {
                await userStore.CreateAsync(user);
                await userStore.AddToRoleAsync(user,  "Admin");
            }

            await context.SaveChangesAsync();
        }
    }
}
