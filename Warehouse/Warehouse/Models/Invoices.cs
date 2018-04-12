using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class Invoices
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<In_orders> Orders { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
