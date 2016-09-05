using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderTransaction.Models
{
    public class ModelBase
    {
        public bool IsError { get; set; }
        public string Message { get; set; }

        public void SetMessage(string message)
        {
            this.IsError = true;
            this.Message = message;

            if (string.IsNullOrEmpty(message)) this.IsError = false;
        }
    }
}