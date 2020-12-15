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
        public bool OrderFinished { get; set; }

        public Order(int OrderId, List<OrderHasFood> Foods, List<OrderHasDrink> Drinks, bool OrderFinished)
        {
            this.OrderId = OrderId;
            this.Foods = Foods;
            this.Drinks = Drinks;
            this.OrderFinished = OrderFinished;
        }

        public Order()
        {

        }

    }
}