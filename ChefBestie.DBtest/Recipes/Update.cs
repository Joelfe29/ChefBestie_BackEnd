using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Recipes
{
    public class Update
    {
        static void Main(string[] args)
        {
            Recipe recipe = new()
            {
                Id = 5,
                Title = "Bacalhau com broa",
                Description = "O prato favorito dos portugueses",
                Category = "Peixe",
                Difficulty = "médio",
                TimeToMake = "45 min",
                IsApproved = true,                
            };



            ChefBestieDBContext chefBestieDBContext = new();

            IRecipeRepository recipeRepository = new RecipeRepository(chefBestieDBContext);

            recipeRepository.Update(recipe);

            chefBestieDBContext.SaveChanges();
        }
    }
}
