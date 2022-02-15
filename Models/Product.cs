using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        [Required]
        [Display(Name = "Namn")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Bredd")]
        public int Width { get; set; }
        [Required]
        [Display(Name = "Höjd")]
        public int Height { get; set; }
        [Required]
        [Display(Name ="Sammanfattning")]
        public string ShortDescription { get; set; }
        [Display(Name = "Beskrivning")]
        public string LongDescription { get; set; }
        [Required]
        [Display(Name ="Kategori")]
        public string Category { get; set; }
        [Display(Name ="Stil")]
        public string Style { get; set; }
        [Display(Name = "Skapad")]
        public DateTime CreationDate { get; set; }
        [Required]
        [Display(Name ="Pris")]
        public decimal Price { get; set; }
        
        public string PictureLink { get; set; }
        public string ThumbnailLink { get; set; }
        
        public string ArtistId { get; set; }
        public bool IsPaintingOfTheWeek { get; set; }
        public int Stock { get; set; }
        
        public List<OrderRow> OrderRows { get; set; }
        public Artist Artist { get; set; }
        public List<ArtistRow> ArtistRows { get; set; }


    }
}
