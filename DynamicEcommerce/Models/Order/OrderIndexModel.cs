using System;
using System.Collections.Generic;
using DynamicEcommerce.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicEcommerce.Models.Order
{
    public class OrderIndexModel
    {
        public IEnumerable<OrderDetailModel> Orders { get; set; }
    }
}
