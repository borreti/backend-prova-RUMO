using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaRumo.Interfaces
{
    // interface of food and drink
    interface IItem
    {
        string Name { get; set; }
        double Price { get; set; }
        int TimeToPrepare { get; set; } // in miliseconds
    }
}
