using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fitness.Models;

namespace Fitness.DAL
{
    public class RecipeDAL : IRecipeDAL
    {
        private FitnessEntities db = new FitnessEntities();
        public Recipe FindRecipeByID(int id)
        {
            Recipe recipe = db.Recipes.Find(id);
            return recipe;
        }

        public IList<Recipe> FindAllRecipes()
        {
            return (db.Recipes.ToList());

        }
    }
}