﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAppDesktop
{
    public class Cart
    {
        public List<CartItem> cartItems;

        public Cart()
        {
            cartItems = new List<CartItem>();
        }
    }
}