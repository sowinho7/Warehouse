using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.ViewModel
{
    public class InvoiceViewModel
    {
        public Invoices invoice { get; set; }
        public List<Invoices> Invoicelist { get; set; }
    }
}