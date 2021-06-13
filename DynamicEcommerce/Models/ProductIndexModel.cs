using DynamicEcommerce.Data.Models;
using System.Collections.Generic;

namespace DynamicEcommerce.Models
{
    public class ProductIndexModel
    {
        public IEnumerable<Product> Products { get; set; }

        public string SearchQuery { get; set; }
    }
}
