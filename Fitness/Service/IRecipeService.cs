using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness.Models;

namespace Fitness.Service
{
    public interface IRecipeService
    {
        /// <summary>
        /// Finds a Recipe by the unique ID
        /// </summary>
        /// <param name="id">The Unique ID for the Recipe</param>
        /// <returns>Recipe with the ID provided, null if not found</returns>
        Recipe FindRecipeByID(int id);

        /// <summary>
        /// Finds all the Recipes in the system.
        /// </summary>
        /// <returns>All Recipes in the System.  Will return Empty List if no recipes in the System</returns>
        IList<Recipe> FindAllRecipes();

        /// <summary>
        /// Save a Recipe to the System.
        /// </summary>
        /// <param name="recipeToSave">The Recipe object to save</param>
        /// <returns>True if save was successful, false if save failed</returns>
        bool SaveRecipe(Recipe recipeToSave);

        /// <summary>
        /// Update a Recipe to the System.
        /// </summary>
        /// <param name="recipeToUpdate">The Recipe object to update</param>
        /// <returns>True if update was successful, false if update failed</returns>
        bool UpdateRecipe(Recipe recipeToUpdate);

        /// <summary>
        /// Delete a Recipe from the System.
        /// </summary>
        /// <param name="recipeToDelete">The Recipe object to delete</param>
        /// <returns>True if delete was successful, false if delete failed</returns>
        bool DeleteRecipe(Recipe recipeToDelete);
    }
}
