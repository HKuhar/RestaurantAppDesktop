using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAppDesktop
{
    public class Order
    {
        public int OrderId { get; set; }

        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public DateTime Time { get; set; }

        public Cart Cart { get; set; }

        public override string ToString()
        {
            string returnString = $"Order Id: {OrderId}{Environment.NewLine}Name: {Name}{Environment.NewLine}Address: {Street} {Number}{Environment.NewLine}Time: {Time}{Environment.NewLine}";

            foreach (var item in Cart.cartItems)
            {
                returnString += $"{item.Quantity} x {item.Dish.Name}{Environment.NewLine}";
            }

            returnString += Environment.NewLine;

            return returnString;
        }
    }
}
