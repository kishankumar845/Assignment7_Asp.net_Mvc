using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment4_ASP.NET_MVC.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public IEnumerable<Products> GetProducts()
        {
            return new List<Products>()
            {
                new Products(){ProductId=1,ProductName="Head Phone",Price=900.00},
                new Products(){ProductId=2,ProductName="Television",Price=75000.00},
                new Products() {ProductId=3,ProductName="Apple Watch",Price=25000.00},
                new Products() {ProductId=4,ProductName="Mobile",Price = 80000},
                new Products(){ProductId=5,ProductName="PS4",Price=31000}
            };
        }
    }
}