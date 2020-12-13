using provaRumo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaRumo.Interfaces
{
    interface IWorkStation
    {
        bool Free { get; set; }
        int ItemsFinished { get; set; }

        void ProcessOrder(Order order);
    }
}
