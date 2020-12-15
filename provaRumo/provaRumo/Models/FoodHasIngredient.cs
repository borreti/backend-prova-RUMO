using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class FoodHasIngredient
    {
        public int FoodId { get; set; }
        protected virtual Food Food { get; set; }

        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}