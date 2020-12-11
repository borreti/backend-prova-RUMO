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

        public Order(int Id, List<Food> ListFoods, List<Drink> ListDrinks, string Status)
        {
            this.Id = Id;
            this.ListFoods = ListFoods;
            this.ListDrinks = ListDrinks;
            this.Status = Status;
        }
        
        public double TotalPrice()
        {
            double fullPrice = CalcFoodPrice() + CalcDrinkPrice();
            return fullPrice;
        }

        public double CalcFoodPrice()
        {
            double foodPrice = 0;
            foreach (Food item in ListFoods)
            {
                foodPrice += item.Price;
            }
            return foodPrice;
        }

        public double CalcDrinkPrice()
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