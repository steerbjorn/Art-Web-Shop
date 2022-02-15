using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class ArtistRow
    {
        [Key]
        public string RowId { get; set; }
        public string ProductId { get; set; }
        public string ArtistId { get; set; }
        public decimal Price { get; set; }

        public Artist Artist { get; set; }
        public Product Product { get; set; }
    }
}
