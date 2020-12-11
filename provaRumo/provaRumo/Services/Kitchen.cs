using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using provaRumo.Interfaces;

namespace provaRumo.Models
{
    public class Kitchen: IWorkStation
    {
        public bool Free { get; set; }
        public int ItemsFinished { get; set; }
        // considerei que todos os cozinheiros se dedicam ao mesmo pedido
        public void ProcessOrder(Order order)
        {
            Free = false;
            foreach (Food item in order.ListFoods)
            {
                Thread.Sleep(item.TimeToPrepare);
            }
            Free = true;
            ItemsFinished++;
        }
    }
}