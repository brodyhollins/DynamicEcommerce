using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicEcommerce.Models
{
    public class CategoryIndexModel
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}
