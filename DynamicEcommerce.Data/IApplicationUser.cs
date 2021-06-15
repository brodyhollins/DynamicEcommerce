using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicEcommerce.Data
{
    public interface IApplicationUser
    {
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser GetById(string id);
    }
}
