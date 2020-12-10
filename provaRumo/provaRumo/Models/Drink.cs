using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Drink : IItem
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public float Alcohool { get; set; }
        public int TimeToPrepare { get; set; }

        public Drink(string Name, double Price, float Alcohool)
        {
            this.Name = Name;
            this.Price = Price;
            this.Alcohool = Alcohool;
        }
    }
}