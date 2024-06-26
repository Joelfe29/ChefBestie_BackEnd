using ChefBestie.Data.Context;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Recipes
{
    public class RemoveById
    {
        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IRecipeRepository recipeRepository = new RecipeRepository(chefBestieDBContext);

            recipeRepository.RemoveById(26);

            chefBestieDBContext.SaveChanges();
        }
    }
}
