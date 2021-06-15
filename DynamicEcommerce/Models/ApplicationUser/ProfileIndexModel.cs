using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicEcommerce.Models.ApplicationUser
{
    public class ProfileIndexModel
    {
        public IEnumerable<ProfileModel> Users { get; set; }
    }
}
