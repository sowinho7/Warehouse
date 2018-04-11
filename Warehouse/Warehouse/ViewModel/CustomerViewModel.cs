using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.ViewModel
{
    public class CustomerViewModel
    {
        public Customers customer { get; set; }
        public List<Customers> Customerslist { get; set; }
    }
}