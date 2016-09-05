using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace OrderTransaction.Models
{
    public class Cart : ModelBase
    {


        Collection<CartLine> _cartLines;
        public Collection<CartLine> CartLines
        {
            get { return _cartLines; }
            set { _cartLines = value; }
        }
    }
}