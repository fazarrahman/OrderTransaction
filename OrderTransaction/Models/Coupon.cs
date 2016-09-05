using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderTransaction.Models
{
    public class Coupon : ModelBase
    {
        public int CouponId { get; set; }
        public string Name { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string DiscountType { get; set; }
        public decimal Discount { get; set; }
        public decimal Quantity { get; set; }
    }
}