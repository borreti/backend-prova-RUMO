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
        public EntityModel() : base("restaurant16") { }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<FoodHasIngredient> FoodHasIngredients { get; set; }
        public DbSet<OrderHasFood> OrderHasFoods { get; set; }
        public DbSet<OrderHasDrink> OrderHasDrinks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodHasIngredient>().HasKey(sc => new { sc.IngredientId, sc.FoodId });
            modelBuilder.Entity<OrderHasFood>().HasKey(sc => new { sc.OrderId, sc.FoodId });
            modelBuilder.Entity<OrderHasDrink>().HasKey(sc => new { sc.OrderId, sc.DrinkId});
        }
    }
}