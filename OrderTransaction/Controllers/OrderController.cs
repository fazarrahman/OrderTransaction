using OrderTransaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderTransaction.Controllers
{
    public class OrderController : ApiController
    {
        public void Post([FromBody]Customer customer)
        {
            var customerObj = customer;
        }

    }
}