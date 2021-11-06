using projectAccessData;
using projectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBusiness
{
    public class BLLRecipe
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<Recipe> GetDanhSachRecipe() {
            return db.Recipes.ToList();
        }

        public List<Recipe> GetRecipesWithWriterId(int Id)
        {
            var list = db.Recipes.Where(x => x.WriteId == Id).ToList();
            return list;
        }

        public bool check(int id) {
            var obj = db.Recipes.Where(x => x.Id == id).SingleOrDefault();
            if (obj==null) {
                return true;
            }
            return false;
        }

        public Boolean AddRecipe(Recipe recipe) {
            if (check(recipe.Id))
            {
                db.Recipes.Add(recipe);
                db.SaveChanges();
                return true;
            }
            else return false;
        }

        public Boolean UpdateRecipe(Recipe recipe) {
            var obj = db.Recipes.Where(x => x.Id == recipe.Id).SingleOrDefault();
            if (obj !=null) {
                obj.Title = recipe.Title;
                obj.Content = recipe.Content;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Boolean DeleteRecipe(int id) {
            var obj = db.Recipes.Where(x => x.Id == id).SingleOrDefault();
            if (obj!=null) {
                db.Recipes.Remove(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Recipe GetRecipe(int id) { 
            return db.Recipes.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
