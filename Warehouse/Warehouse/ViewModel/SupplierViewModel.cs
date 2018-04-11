using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.ViewModel
{
    public class SupplierViewModel
    {
        public Suppliers Supplier { get; set; }
        public List<Suppliers> Supplierslist { get; set; }
    }
}