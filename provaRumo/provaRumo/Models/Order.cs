using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Order
    {
        [Key()]
        public int Id { get; set; }
        public List<Food> ListFoods { get; set; }
        public List<Drink> ListDrinks { get; set; }
        public string Status { get; set; }
        public bool FoodFinished { get; set; }
        public bool DrinkFinished { get; set; }
        
        public double totalPrice()
        {
            double fullPrice = calcFoodPrice() + calcDrinkPrice();
            return fullPrice;
        }

        public double calcFoodPrice()
        {
            double foodPrice = 0;
            foreach (Food item in ListFoods)
            {
                foodPrice += item.Price;
            }
            return foodPrice;
        }

        public double calcDrinkPrice()
        {
            double drinkPrice = 0;
            foreach (Drink item in ListDrinks)
            {
                drinkPrice += item.Price;
            }
            return drinkPrice;
        }

    }
}