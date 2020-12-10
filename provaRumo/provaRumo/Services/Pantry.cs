using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using provaRumo.Interfaces;

namespace provaRumo.Models
{
    public class Pantry: IWorkStation
    {
        public bool Free { get; set; }
        public int ItemsFinished { get; set; }

        public void ProcessOrder(Order order)
        {
            Free = false;
            foreach (Drink item in order.ListDrinks)
            {
                Thread.Sleep(item.TimeToPrepare);
            }
            Free = true;
            ItemsFinished++;
        }
    }
}