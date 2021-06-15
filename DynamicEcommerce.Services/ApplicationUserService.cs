using DynamicEcommerce.Data;
using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicEcommerce.Services
{
    public class ApplicationUserService : IApplicationUser
    {
        private readonly DynamicEcommerceDbContext context;
        public ApplicationUserService(DynamicEcommerceDbContext _context)
        {
            context = _context;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return context.ApplicationUsers;
        }

        public ApplicationUser GetById(string id)
        {
            return GetAll().FirstOrDefault(user => user.Id == id);
        }
    }
}
