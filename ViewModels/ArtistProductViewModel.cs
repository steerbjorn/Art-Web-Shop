using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.ViewModels
{
    public class ArtistProductViewModel
    {
        public List<Artist> Artist { get; set; }
        public List<Product> Product { get; set; }
    }
}