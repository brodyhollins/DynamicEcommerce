using DynamicEcommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicEcommerce.Models.Order
{
    public class OrderDetailModel
    {
        public int No { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }


        //public int ProductId { get; set; }
        //public string ProductName { get; set; }
        //public string CategoryId { get; set; }
        //public string CategoryName { get; set; }
        //public string ProductImage { get; set; }
    }
}
