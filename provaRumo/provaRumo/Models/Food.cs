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
        public int FoodId { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int TimeToPrepare { get; set; }

        public Food(int FoodId, List<Ingredient> Ingredients, string Name, double Price, int TimeToPrepare)
        {
            this.FoodId = FoodId;
            this.Ingredients = Ingredients;
            this.Name = Name;
            this.Price = Price;
            this.TimeToPrepare = TimeToPrepare;
        }

        public Food()
        {
            
        }
    }
}