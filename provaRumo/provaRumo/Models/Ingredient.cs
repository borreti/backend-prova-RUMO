using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }

        public Ingredient(int IngredientId, string Name)
        {
            this.IngredientId = IngredientId;
            this.Name = Name;
        }

        public Ingredient()
        {

        }
    }
}