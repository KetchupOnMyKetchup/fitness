using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fitness.DAL;
using Fitness.Models;

namespace Fitness.Service
{
    public class RecipeService : IRecipeService
    {

        /// <summary>
        /// Finds a Recipe by the unique ID
        /// </summary>
        /// <param name="id">The Unique ID for the Recipe</param>
        /// <returns>Recipe with the ID provided, null if not found</returns>
        public Recipe FindRecipeByID(int id)
        {
            DummyRecipeDAL dummyRecipeDAL = new DummyRecipeDAL();
            return dummyRecipeDAL.FindRecipeByID(id);
        }

        /// <summary>
        /// Finds all the Recipes in the system.
        /// </summary>
        /// <returns>All Recipes in the System.  Will return Empty List if no recipes in the System</returns>
        public IList<Recipe> FindAllRecipes()
        {
            DummyRecipeDAL dummyRecipeDAL = new DummyRecipeDAL();
            return dummyRecipeDAL.FindAllRecipes();
        }

        /// <summary>
        /// Save a Recipe to the System.
        /// </summary>
        /// <param name="recipeToSave">The Recipe object to save</param>
        /// <returns>True if save was successful, false if save failed</returns>
        public bool SaveRecipe(Recipe recipeToSave)
        {
            return false;
        }

        /// <summary>
        /// Update a Recipe to the System.
        /// </summary>
        /// <param name="recipeToUpdate">The Recipe object to update</param>
        /// <returns>True if update was successful, false if update failed</returns>
        public bool UpdateRecipe(Recipe recipeToUpdate)
        {
            return false;
        }

        /// <summary>
        /// Delete a Recipe from the System.
        /// </summary>
        /// <param name="recipeToDelete">The Recipe object to delete</param>
        /// <returns>True if delete was successful, false if delete failed</returns>
        public bool DeleteRecipe(Recipe recipeToDelete)
        {
            return false;
        }
    }
}