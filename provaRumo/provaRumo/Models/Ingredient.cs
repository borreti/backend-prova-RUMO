using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Ingredient: IBasicModel
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }

        public Ingredient(int IngredientId, string Name)
        {
            this.IngredientId = IngredientId;
            this.Name = Name;
        }

        public Ingredient()
        {

        }

        public IBasicModel Upsert()
        {
            EntityModel context = new EntityModel();
            Ingredient findedItem = context.Ingredients.FirstOrDefault(x => x.IngredientId == IngredientId);
            if (findedItem == null)
            {
                context.Ingredients.Add(this);
            } else
            {
                findedItem.Name = Name;
            }
            context.SaveChangesAsync();
            return findedItem;
        }

        public IBasicModel GetById(int Id)
        {
            EntityModel context = new EntityModel();
            Ingredient findedItem = context.Ingredients.FirstOrDefault(x => x.IngredientId == Id);
            return findedItem;
        }

        public List<IBasicModel> ListItems()
        {
            EntityModel context = new EntityModel();
            List<IBasicModel> listItems = context.Ingredients.ToList<IBasicModel>();
            return listItems;
        }

        public IBasicModel Delete()
        {
            EntityModel context = new EntityModel();
            Ingredient findedItem = context.Ingredients.First(x => x.IngredientId == IngredientId);
            context.Ingredients.Remove(findedItem);
            context.SaveChangesAsync();
            return findedItem;
        }
    }
}