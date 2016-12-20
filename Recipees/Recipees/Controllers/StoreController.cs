using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recipees.Controllers
{
    public class StoreController : Controller
    {
        private recipesEntities recipesDB = new recipesEntities();
        // GET: Store
        public ActionResult Index()
        {
            var recipe = this.recipesDB.recipe_ingredient;

            return this.View(recipe);
        }
    }
}