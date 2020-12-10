using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Food: IItem
    {
        public List<string> Ingredients { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Food(double Price, string Name, List<string> Ingredients)
        {
            this.Price = Price;
            this.Name = Name;
            this.Ingredients = Ingredients;
        }
    }
}