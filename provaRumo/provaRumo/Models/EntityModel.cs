using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace provaRumo.Models
{
    public class EntityModel: DbContext
    {
        public EntityModel() : base("restaurant") { }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}