using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicEcommerce.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }
        
    }
}
