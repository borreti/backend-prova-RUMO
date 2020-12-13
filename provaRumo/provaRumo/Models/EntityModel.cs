using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using provaRumo.Interfaces;

namespace provaRumo.Models
{
    public class EntityModel: DbContext
    {
        public EntityModel() : base("restaurant6") { }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}