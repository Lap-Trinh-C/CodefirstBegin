using projectBusiness;
using projectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWEBMVC.Models
{
    public class RecipeService
    {
        BLLRecipe bll = new BLLRecipe();

        public List<Recipe> GetRecipes() {
            return bll.GetDanhSachRecipe();
        }

        public List<Recipe> GetRecipeWithId(int id) {
            return bll.GetRecipesWithWriterId(id);
        }

        public bool AddOneRecipe(Recipe recipe) {
            return bll.AddRecipe(recipe);
        }

        public bool DeleteOneRecipe(int id) {
            return bll.DeleteRecipe(id);
        }

        public bool UpdateOneRecipe(Recipe recipe) {
            return bll.UpdateRecipe(recipe);
        }

        public Recipe GetOneRecipe(int id) {
            return bll.GetRecipe(id);
        }

    }
}