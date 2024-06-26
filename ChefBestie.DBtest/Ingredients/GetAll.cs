using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Implementations;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Ingredients
{
    public class GetAll
    {
        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IIngredientRepository ingredientRepository = new IngredientRepository(chefBestieDBContext);

            List<Ingredient> ingredient = ingredientRepository.GetAll();

            ingredient.ForEach(Console.Write);


        }
    }
}
