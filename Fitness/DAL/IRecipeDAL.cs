using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness.Models;

namespace Fitness.DAL
{
    public interface IRecipeDAL
    {
        Recipe FindRecipeByID(int id);

        IList<Recipe> FindAllRecipes();

    }
}
