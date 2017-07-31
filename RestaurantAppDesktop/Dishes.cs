using System;
using System.Collections.Generic;

namespace RestaurantAppDesktop
{
    public partial class Dishes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            string returnString = $"Dish Id: {Id}{Environment.NewLine}Name: {Name}{Environment.NewLine}Description: {Description}{Environment.NewLine}Price: {Price}{Environment.NewLine}{Environment.NewLine}";

            return returnString;
        }
    }
}