using OrderTransaction.Models;
using OrderTransaction.Repository.Abstract;
using OrderTransaction.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderTransaction.Controllers
{
    public class CouponController : ApiController
    {
        ICouponRepository _couponRepository;

        public IEnumerable<Coupon> GetAllCoupon()
        {
            _couponRepository = new CouponRepository();

            Collection<Coupon> coupons = _couponRepository.GetAllCoupon();

            return coupons;
        }

        public IHttpActionResult GetCoupon(int id)
        {
            _couponRepository = new CouponRepository();

            var coupon = _couponRepository.GetCouponById(id);
            if (coupon == null)
            {
                coupon.SetMessage("Coupon tidak ditemukan");
            }
            return Ok(coupon);
        }
    }
}