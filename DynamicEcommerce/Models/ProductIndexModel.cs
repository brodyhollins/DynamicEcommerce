using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicEcommerce.Models
{
    public class ProductIndexModel
    {
        public IEnumerable<Product> Products { get; set; }

        public string SearchQuery { get; set; }
    }
}
