using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.ViewModel
{
    public class BrandViewModel
    {
        public Brand brand { get; set; }
        public List<Brand> Brandlist { get; set; }
    }
}