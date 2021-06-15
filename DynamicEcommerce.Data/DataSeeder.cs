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
            
            var adminUser = new ApplicationUser
            {
                UserName = "admin@dynamic.com",
                NormalizedUserName = "ADMIN@DYNAMIC.COM",
                Email = "admin@dynamic.com",
                NormalizedEmail = "ADMIN@DYNAMIC.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var employee = new ApplicationUser
            {
                UserName = "john@dynamic.com",
                NormalizedUserName = "JOHN@DYNAMIC.COM",
                Email = "john@dynamic.com",
                NormalizedEmail = "JOHN@DYNAMIC.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var customer1 = new ApplicationUser
            {
                UserName = "josh@gmail.com",
                NormalizedUserName = "JOSH@GMAIL.COM",
                Email = "josh@gmail.com",
                NormalizedEmail = "JOSH@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var customer2 = new ApplicationUser
            {
                UserName = "brody@gmail.com",
                NormalizedUserName = "BRODY@GMAIL.COM",
                Email = "brody@gmail.com",
                NormalizedEmail = "BRODY@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var customer3 = new ApplicationUser
            {
                UserName = "bob@gmail.com",
                NormalizedUserName = "BOB@GMAIL.COM",
                Email = "bob@gmail.com",
                NormalizedEmail = "BOB@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var passwordHashed = passwordHasher.HashPassword(adminUser, "Dynam1c1337*");
            var sampleUserHashed = passwordHasher.HashPassword(adminUser, "Password1*");

            adminUser.PasswordHash = passwordHashed;
            employee.PasswordHash = sampleUserHashed;
            customer1.PasswordHash = sampleUserHashed;
            customer2.PasswordHash = sampleUserHashed;
            customer3.PasswordHash = sampleUserHashed;

            var roleStore = new RoleStore<IdentityRole>(context);
            var userStore = new UserStore<ApplicationUser>(context);

            var hasAdminRole = context.Roles.Any(roles => roles.Name == "Admin");
            var hasEmployeeRole = context.Roles.Any(roles => roles.Name == "Employee");
            var hasCustomerRole = context.Roles.Any(roles => roles.Name == "Customer");

            if (!hasAdminRole)
            {
                await roleStore.
                    CreateAsync(new IdentityRole {Name="Admin", NormalizedName="admin"});
            }
            if (!hasEmployeeRole)
            {
                await roleStore.
                    CreateAsync(new IdentityRole { Name = "Employee", NormalizedName = "employee" });
            }
            if (!hasCustomerRole)
            {
                await roleStore.
                    CreateAsync(new IdentityRole { Name = "Customer", NormalizedName = "customer" });
            }


            var hasAdminUser = context.Users.Any(x => x.UserName == adminUser.UserName);
            var hasEmployee = context.Users.Any(x => x.UserName == employee.UserName);
            var hasCustomer1 = context.Users.Any(x => x.UserName == customer1.UserName);
            var hasCustomer2 = context.Users.Any(x => x.UserName == customer2.UserName);
            var hasCustomer3 = context.Users.Any(x => x.UserName == customer3.UserName);

            if (!hasAdminUser)
            {
                await userStore.CreateAsync(adminUser);
                await userStore.AddToRoleAsync(adminUser,  "Admin");
            }
            if (!hasEmployee)
            {
                await userStore.CreateAsync(employee);
                await userStore.AddToRoleAsync(employee, "Employee");
            }

            if (!hasCustomer1)
            {
                await userStore.CreateAsync(customer1);
                await userStore.AddToRoleAsync(customer1, "Customer");
            }

            if (!hasCustomer2)
            {
                await userStore.CreateAsync(customer2);
                await userStore.AddToRoleAsync(customer2, "Customer");
            }

            if (!hasCustomer3)
            {
                await userStore.CreateAsync(customer3);
                await userStore.AddToRoleAsync(customer3, "Customer");
            }

            await context.SaveChangesAsync();
        }
    }
}
