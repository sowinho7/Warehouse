﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class In_orders
    {
        [Key]
        public int Id { get; set; }
        public DateTime Order_date { get; set; }
        public int Product_id { get; set; }
        public int Customer_id { get; set; }
        public int Count { get; set; }
    }
}