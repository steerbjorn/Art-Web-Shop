using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [PersonalData]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }
        
        [Required]
        [PersonalData]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Gata")]
        public string BillingStreetName { get; set; }
        
        [Required]
        [PersonalData]
        [Display(Name = "Postnummer")]
        public string BillingPostalCode { get; set; }
        
        [Required]
        [PersonalData]
        [Display(Name = "Stad")]
        public string BillingCity { get; set; }
        
        [PersonalData]
        [Display(Name = "Stad")]
        public string BillingCountry { get; set; }

        [PersonalData]
        [Display(Name = "Leverans Gata")]
        public string DeliveryStreetName { get; set; }
        
        [PersonalData]
        [Display(Name = "Leverans Postnummer")]
        public string DeliveryPostalCode { get; set; }
        
        [PersonalData]
        [Display(Name = "Leverans Stad")]        
        public string DeliveryCity { get; set; }
        
        [PersonalData]
        [Display(Name = "Leverans Land")]        
        public string DeliveryCountry { get; set; }
    }
}
