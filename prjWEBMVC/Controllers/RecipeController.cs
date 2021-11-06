using prjWEBMVC.Models;
using projectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjWEBMVC.Controllers
{
    public class RecipeController : Controller
    {
        Writers w = new Writers();
        RecipeService recipe = new RecipeService();
        // GET: Recipe
        public ActionResult Index()
        {
            return View(recipe.GetRecipes());
        }

        public PartialViewResult DisplayPartialView()
        {
            return PartialView(w.GetList()); 
        }

        public ActionResult GetRecipeWithWriter(int id) {
            return View(recipe.GetRecipeWithId(id));
        }

        public ActionResult Insert() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(Recipe recipeobj)
        {
            if (ModelState.IsValid && recipe.AddOneRecipe(recipeobj)) {
                return RedirectToAction("Index");
            }
            return View(recipeobj);
        }

        public ActionResult Edit(int id) {
            return View(recipe.GetOneRecipe(id));

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Recipe recipeobj)
        {
            if (ModelState.IsValid && recipe.UpdateOneRecipe(recipeobj))
            {
                return RedirectToAction("Index");
            }
            return View();

        }

        public ActionResult Delete(int id) {
            return View(recipe.GetOneRecipe(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Recipe recipeobj) {
            if (recipe.DeleteOneRecipe(recipeobj.Id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Detail(int id) {
            return View(recipe.GetOneRecipe(id));
        }

    }
}