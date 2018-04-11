using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.ViewModel
{
    public class CategoryViewModel
    {
        public Category category { get; set; }
        public List<Category> Categorylist { get; set; }
    }
}