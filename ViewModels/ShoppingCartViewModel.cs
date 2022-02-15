using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart shoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
