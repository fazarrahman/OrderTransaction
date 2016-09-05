using OrderTransaction.Models;
using OrderTransaction.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace OrderTransaction.Repository.Concrete
{
    public class CouponRepository : ICouponRepository
    {
        private Collection<Coupon> coupons = new Collection<Coupon>()
        {
            new Coupon { CouponId = 1, Name = "End Of Year Discount", ExpiredDate = new DateTime(2017,1,1), DiscountType = "D", Discount = 10, Quantity = 3 },
            new Coupon { CouponId = 2, Name = "Weekdays Discount", ExpiredDate = new DateTime(2017,1,1), DiscountType = "A", Discount = 20000, Quantity = 1 }
        };

        public Collection<Coupon> GetAllCoupon()
        {
            return coupons;
        }

        public Coupon GetCouponById(int couponId)
        {
            Coupon coupon = coupons.Where(c => c.CouponId == couponId).FirstOrDefault();

            return coupon;
        }
    }
}