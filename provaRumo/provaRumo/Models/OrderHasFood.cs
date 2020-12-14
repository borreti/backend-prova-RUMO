using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class OrderHasFood
    {
        public int OrderId { get; set; }
        protected virtual Order Order { get; set; }

        public int FoodId { get; set; }
        public virtual Food Food { get; set; }
    }
}