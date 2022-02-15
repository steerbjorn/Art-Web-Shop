using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class Coupon
    {
        [Key]
        public string CouponId { get; set; }
        public string Code { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercent { get; set; }
        public string Description { get; set; }
        public bool IsCampaign { get; set; }
        public int MyProperty { get; set; }
    }
}
