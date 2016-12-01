﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
   public class BasketItem
    {
        public int BasketItemId { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
