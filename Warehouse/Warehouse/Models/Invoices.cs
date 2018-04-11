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
        public int Client_id { get; set; }
        public int Invoice_no { get; set; }
        public DateTime Invoice_date { get; set; }
        public ICollection<In_orders> Orders { get; set; }
        public DateTime Payment_date { get; set; }

    }
}
