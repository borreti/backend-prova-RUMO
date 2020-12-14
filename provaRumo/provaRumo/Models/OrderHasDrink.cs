using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class OrderHasDrink
    {
        public int OrderId { get; set; }
        protected virtual Order Order { get; set; }

        public int DrinkId { get; set; }
        public virtual Drink Drink { get; set; }
    }
}