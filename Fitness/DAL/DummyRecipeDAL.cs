using System;
using System.Collections.Generic;
using Fitness.Models;

namespace Fitness.DAL
{
    public class DummyRecipeDAL
    {
        private List<Recipe> _recipes = new List<Recipe>
            {
                new Recipe() {Title = "Chicken Salad", Directions = "Put lettuce in bowl.\nShred Chicken.\nApply olive oil.", Ingredients = "Lettuce, chicken, olive oil"},
                new Recipe() {Title = "Salmon Fillet", Directions = "Cut salmon, apply butter.\nSeason and let it soak in.", Ingredients = "Salmon, butter, pepper, salt"},
                new Recipe() {Title = "Turkey & Cranberry", Directions = "Bake turkey 2 hours.\nApply cranberry sauce.", Ingredients = "Turkey, cranberry"},
            };

        public List<Recipe> Recipes
        {
            get { return _recipes; }
            set { _recipes = value; }
        }


        public Recipe FindRecipeByID(int id)
        {
            Recipe foundRecipe = null;
            switch (id)
            {
                case 1:
                    foundRecipe = Recipes[0];
                    break;
                case 2:
                    foundRecipe = Recipes[1];
                    break;
                case 3:
                    foundRecipe = Recipes[2];
                    break;                
            }
            return foundRecipe;
        }

        public IList<Recipe> FindAllRecipes()
        {
            return Recipes;
        }

    }
}