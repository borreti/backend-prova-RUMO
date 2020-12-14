using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Food: IItem
    {
        public int FoodId { get; set; }
        public virtual ICollection<FoodHasIngredient> HasIngredients { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int TimeToPrepare { get; set; }
        protected virtual ICollection<OrderHasFood> Foods { get; set; }

        public Food(int FoodId, List<FoodHasIngredient> Ingredients, string Name, double Price, int TimeToPrepare)
        {
            this.FoodId = FoodId;
            this.HasIngredients = Ingredients;
            this.Name = Name;
            this.Price = Price;
            this.TimeToPrepare = TimeToPrepare;
        }

        public Food()
        {
            
        }
    }
}