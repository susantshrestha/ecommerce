﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.model
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address1 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}
