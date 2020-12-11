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
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public float Alcohool { get; set; }
        public int TimeToPrepare { get; set; }

        public Drink(int DrinkId, string Name, double Price, float Alcohool, int TimeToPrepare)
        {
            this.DrinkId = DrinkId;
            this.Name = Name;
            this.Price = Price;
            this.Alcohool = Alcohool;
            this.TimeToPrepare = TimeToPrepare;
        }

        public void Create()
        {
            EntityModel context = new EntityModel();
            //Drink drink = new Drink(DrinkId, Name, Price, Alcohool, TimeToPrepare);
            //context.Drinks.Add(drink);
            //context.SaveChanges();
            //return drink;
        }

        public void Get()
        {
            EntityModel context = new EntityModel();
            //Entities.Customer.First(c => c.CustomerId == 20);
        }
    }
}