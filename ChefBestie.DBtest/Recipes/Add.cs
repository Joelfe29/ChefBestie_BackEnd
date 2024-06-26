using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Recipes
{
    public class Add
    {
        static void Main(string[] args)
        {
            Recipe recipe = new()
            {
                   Title = "Bife com batatas fritas",
                   Description = "gagsmbrjsnbwtjrk",
                   Category = "carne",
                   Difficulty = "fácil",
                   TimeToMake = "20 min",
                   IsApproved = true,        
            };



            ChefBestieDBContext chefBestieDBContext = new();

            IRecipeRepository recipeRepository = new RecipeRepository(chefBestieDBContext);

            recipeRepository.Add(recipe);

            chefBestieDBContext.SaveChanges();
        }
    }
}
