using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.ViewModel
{
    public class ProductViewModel
    {
        public Product product { get; set; }
        public IEnumerable<Product> Productlist { get; set; }
    }
}