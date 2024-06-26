using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Recipes
{
    public class GetByCategory
    {

        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IRecipeRepository recipeRepository = new RecipeRepository(chefBestieDBContext);

            List<Recipe> recipe = recipeRepository.GetByCategory("Peixe");

            recipe.ForEach(Console.Write);

        }
    }
}
