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
        public virtual ICollection<OrderHasFood> Foods { get; set; }
        public virtual ICollection<OrderHasDrink> Drinks { get; set; }
        public bool DrinkFinished { get; set; }
        public bool FoodFinished { get; set; }
        public bool OrderFinished { get; set; }

        public Order(int OrderId, List<OrderHasFood> Foods, List<OrderHasDrink> Drinks, bool DrinkFinished, bool FoodFinished, bool OrderFinished)
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

    }
}