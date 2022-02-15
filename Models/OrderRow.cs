using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class OrderRow
    {
        [Key]
        public string RowId { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
