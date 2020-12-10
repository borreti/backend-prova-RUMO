using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Food: IItem
    {
        [Key()]
        public int Id { get; set; } [Key()]
        public List<string> Ingredients { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int TimeToPrepare { get; set; }

        public Food(int Id, List<string> Ingredients, string Name, double Price, int TimeToPrepare)
        {
            this.Id = Id;
            this.Ingredients = Ingredients;
        }

        public Food(double Price, string Name, List<string> Ingredients)
        {
            this.Price = Price;
            this.Name = Name;
            this.Ingredients = Ingredients;
        }
    }
}