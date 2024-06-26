using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Implementations;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.NewFolder
{
    public class Add
    {
        static void Main(string[] args)
        {
            Ingredient ingredient = new()
            {
                Name = "limão",
                Quantity = ""
            };



            ChefBestieDBContext chefBestieDBContext = new();

            IIngredientRepository ingredientRepository = new IngredientRepository(chefBestieDBContext);

            ingredientRepository.Add(ingredient);

            chefBestieDBContext.SaveChanges();
        }
    }
}
