using ChefBestie.Data.Context;
using ChefBestie.Repositories.Implementations;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Ingredients
{
    public class RemoveById
    {
        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IIngredientRepository ingredientRepository = new IngredientRepository(chefBestieDBContext);

            ingredientRepository.RemoveById(3);

            chefBestieDBContext.SaveChanges();
        }
    }
}
