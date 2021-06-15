using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicEcommerce.Models.ApplicationUser
{
    public class ProfileModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
        public bool IsEmployee { get; set; }
    }
}
