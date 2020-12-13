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
        public int OrderId { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<Drink> Drinks { get; set; }
        public bool DrinkFinished { get; set; }
        public bool FoodFinished { get; set; }
        public bool OrderFinished { get; set; }

        public Order(int OrderId, List<Food> Foods, List<Drink> Drinks, bool DrinkFinished, bool FoodFinished, bool OrderFinished)
        {
            this.OrderId = OrderId;
            this.Foods = Foods;
            this.Drinks = Drinks;
            this.DrinkFinished = DrinkFinished;
            this.FoodFinished = FoodFinished;
            this.OrderFinished = OrderFinished;
        }

        public Order()
        {

        }
        
        public double TotalPrice()
        {
            double fullPrice = CalcFoodPrice() + CalcDrinkPrice();
            return fullPrice;
        }

        public double CalcFoodPrice()
        {
            double foodPrice = 0;
            foreach (Food item in Foods)
            {
                foodPrice += item.Price;
            }
            return foodPrice;
        }

        public double CalcDrinkPrice()
        {
            double drinkPrice = 0;
            foreach (Drink item in Drinks)
            {
                drinkPrice += item.Price;
            }
            return drinkPrice;
        }

    }
}