using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class Artist
    {
        [Key]
        public string ArtistId { get; set; }
        public string UserId { get; set; }

        [Display(Name ="Artistnamn")]
        public string ArtistName { get; set; }

        public List<ArtistRow> ArtistRows { get; set; }
        //public ApplicationUser User { get; set; }
    }
}
