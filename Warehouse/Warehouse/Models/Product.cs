using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Vat { get; set; }
        public float Netto_price { get; set; }
        public int Count { get; set; }
        public int Category_id { get; set; }
        public int Supplier_id { get; set; }
        public string Description { get; set; }

    }
}
