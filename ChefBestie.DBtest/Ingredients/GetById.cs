using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Implementations;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Ingredients
{
    public class GetById
    {
        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IIngredientRepository ingredientRepository = new IngredientRepository(chefBestieDBContext);

            Ingredient ingredient = ingredientRepository.GetById(3);

            Console.Write(ingredient);

        }
    }
}
