using provaRumo.Interfaces;
using provaRumo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace provaRumo.Controllers
{
    public class IngredientController : ApiController
    {
        [HttpPost]
        public IBasicModel Create(Ingredient ingredient)
        {
            ingredient.Upsert();
            return ingredient;
        }

        [HttpGet]
        public IBasicModel GetById(int Id)
        {
           Ingredient searcher = new Ingredient();
            IBasicModel item = searcher.GetById(Id);
            return item;
        }

        [HttpGet]
        [ActionName("ListItems")]
        public List<IBasicModel> ListItems()
        {
            Ingredient searcher = new Ingredient();
            List <IBasicModel> listItems = searcher.ListItems();
            return listItems;
        }

        [HttpPut]
        public IBasicModel Update(Ingredient ingredient)
        {
            ingredient.Upsert();
            return ingredient;
        }

        [HttpDelete]
        public IBasicModel Delete(int Id)
        {
            Ingredient searcher = new Ingredient();
            IBasicModel item = searcher.GetById(Id);
            item.Delete();
            return item;
        }
    }
}
